using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Controls
{
    public partial class SelectTracks : UserControl
    {
        // private List<Track> _tracks;

        private List<Track> _allTracks;

        public List<Track> AllTracks
        {
            get => _allTracks;
            set
            {
                _allTracks = value;

                if (_allTracks == null)
                {
                    return;
                }

                var table = new DataTable();

                table.Columns.Add(new DataColumn("ID", typeof(int)));
                table.Columns.Add(new DataColumn("Название", typeof(string)));
                table.Columns.Add(new DataColumn("Автор", typeof(string)));

                _allTracks.ForEach(track => table.Rows.Add(track.Id, track.Name, track.Author.Name));

                selectTracksTable.DataSource = table;
            }
        }

        private List<Track> _selectedTracks;

        public List<Track> SelectedTracks
        {
            get => _selectedTracks;
            set
            {
                _selectedTracks = value;

                if (_selectedTracks != null)
                {
                    foreach (DataGridViewRow row in selectTracksTable.Rows)
                    {
                        row.Selected = _selectedTracks
                            .Exists(track => track.Id == Convert.ToInt32(row.Cells[0].Value));
                    }
                }
            }
        }

        public SelectTracks()
        {
            InitializeComponent();
        }

        // private int indexRow;

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedTracks == null)
            {
                SelectedTracks = new List<Track>();
            }

            string searchText = searchBox.Text.ToLower().Trim();
            selectTracksTable.CurrentCell = null;

            foreach (DataGridViewRow row in selectTracksTable.Rows)
            {
                if (((string) row.Cells[1].Value).Trim().ToLower().Contains(searchText)
                    || ((string) row.Cells[2].Value).Trim().ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

            foreach (DataGridViewRow row in selectTracksTable.Rows)
            {
                row.Selected = SelectedTracks.Exists(track => track.Id == Convert.ToInt32(row.Cells[0].Value));
            }
        }

        private void selectTracksTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedTracks == null)
            {
                SelectedTracks = new List<Track>();
            }
            
            var changedRow = selectTracksTable?.CurrentRow;

            if (changedRow == null || AllTracks == null)
            {
                return;
            }

            var id = Convert.ToInt32(changedRow.Cells[0].Value);
            var isSelected = !SelectedTracks.Exists(track => track.Id == id);

            if (isSelected)
            {
                SelectedTracks.Add(AllTracks.Find(track => track.Id == id));
            }
            else
            {
                var indexRemoveTrack = SelectedTracks.FindIndex(track => track.Id == id);
                SelectedTracks.RemoveAt(indexRemoveTrack);
                changedRow.Selected = false;
            }

            var rows = selectTracksTable.Rows;
            foreach (DataGridViewRow row in rows)
            {
                row.Selected = SelectedTracks.Exists(track => track.Id == Convert.ToInt32(row.Cells[0].Value));
            }
        }

        private void selectTracksTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            selectTracksTable.ClearSelection();
            selectTracksTable.CurrentCell = null;
            SelectedTracks = SelectedTracks;
        }
    }
}