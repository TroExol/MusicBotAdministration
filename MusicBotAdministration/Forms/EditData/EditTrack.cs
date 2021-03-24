using System;
using System.Windows.Forms;

namespace MusicBotAdministration.Forms.EditData
{
    public partial class EditTrack : Form
    {
        public string TrackName { get; set; }
        public string Author { get; set; }

        public EditTrack()
        {
            InitializeComponent();
        }

        private void addTrackBtn_Click(object sender, EventArgs e)
        {
            // Проверка названия
            if (trackNameInput.Text == "")
            {
                MessageBox.Show(@"Укажите название трека", @"Ошибка");
                trackNameInput.Focus();
                return;
            }

            // Проверка автора
            if (authorInput.Text == "")
            {
                MessageBox.Show(@"Укажите автора", @"Ошибка");
                authorInput.Focus();
                return;
            }

            TrackName = trackNameInput.Text;
            Author = authorInput.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}