using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.EditData;

namespace MusicBotAdministration.Forms.Tables
{
    public partial class TracksTable : Form
    {
        // Треки
        private Tracks Tracks { get; set; }

        // Получение списка треков
        private List<Track> TracksList
        {
            get => Tracks.TracksList;
            set => Tracks.TracksList = value;
        }

        // Создание таблицы и заголовков
        private static DataTable CreateTracksTable()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Название", typeof(string)));
            table.Columns.Add(new DataColumn("Автор", typeof(string)));

            return table;
        }

        // Добавление треков в таблицу и в DataGridView
        private void LoadTracksTable(object sender, EventArgs e)
        {
            try
            {
                // Создание таблицы
                var table = CreateTracksTable();

                // Добавление треков в таблицу
                TracksList.ForEach((track) => { table.Rows.Add(track.Id, track.Name, track.Author.Name); });
                // Добавление источника данных в DataGridView
                generalTracksTable.DataSource = table;

                // Изменение заголовка DataGridView
                tracksTableLabel.Text = $@"Треки ({generalTracksTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить треки", @"Ошибка");
            }
        }

        public TracksTable()
        {
            InitializeComponent();

            Tracks = new Tracks(LoadTracksTable, LoadTracksTable);
            TracksList = Tracks.GetData();
        }

        // Добавление треков
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления треков
            using (var addTrackForm = new EditTrack())
            {
                addTrackForm.Text = @"Добавление треков";
                addTrackForm.addTrackBtn.Text = @"Добавить";

                // Если данные не получены из формы
                if (addTrackForm.ShowDialog() != DialogResult.OK)
                    return;

                var author = DbConnector.Read("Автор",
                    "Не удалось получить автора", "*",
                    $"WHERE ИмяАвтора = '{addTrackForm.Author}'").ToList();
                int idAuthor;

                if (author.Count > 0)
                {
                    idAuthor = Convert.ToInt32(author[0]["ID"]);
                }
                else
                {
                    idAuthor = DbConnector.Create("Автор",
                        "ИмяАвтора", $"'{addTrackForm.Author}'",
                        "Не удалось добавить данные об авторе");
                }

                if (idAuthor != -1)
                {
                    var idTrack = DbConnector.Create("Трек",
                        "Название, ID_Автор", $"'{addTrackForm.TrackName}', {idAuthor}",
                        "Не удалось добавить данные о треке");

                    if (idTrack != -1)
                    {
                        // Добавление в список
                        Tracks.Add(
                            new Track(idTrack, addTrackForm.TrackName, new Author(idAuthor, addTrackForm.Author)));
                    }
                }
            }
        }

        // Изменение трека
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных треков
            var selectedTracks = generalTracksTable.SelectedRows;

            if (selectedTracks.Count != 1)
            {
                MessageBox.Show(@"Выберите 1 трек", @"Ошибка");
                return;
            }

            // Открытие формы для изменения трека
            using (var editTrackForm = new EditTrack())
            {
                editTrackForm.Text = @"Изменение трека";
                editTrackForm.addTrackBtn.Text = @"Изменить";

                // Получение id выбранного трека
                var id = Convert.ToInt32(selectedTracks[0].Cells[0].Value);
                // Получение выбранного трека
                var selectedTrack = TracksList.Find((track) => track.Id == id);

                // Заполнение названия
                editTrackForm.trackNameInput.Text = selectedTrack.Name;
                // Заполнение автора
                editTrackForm.authorInput.Text = selectedTrack.Author.Name;

                // Если данные не получены из формы
                if (editTrackForm.ShowDialog() != DialogResult.OK)
                    return;

                // Изменение трека
                var changedName = editTrackForm.TrackName;
                var changedAuthor = editTrackForm.Author;
                bool isTrackChanged = false;
                bool isAuthorChanged = false;
                int idAuthor = -1;

                if (selectedTrack.Name != changedName)
                {
                    isTrackChanged = DbConnector.Update("Трек", $"Название = '{changedName}'",
                        "Не удалось изменить данные о треке",
                        $"ID = {selectedTrack.Id}");
                }

                if (selectedTrack.Author.Name != changedAuthor)
                {
                    var author = DbConnector.Read("Автор",
                        "Не удалось изменить данные об авторе", "*",
                        $"WHERE ИмяАвтора = '{changedAuthor}'").ToList();

                    if (author.Count > 0)
                    {
                        idAuthor = Convert.ToInt32(author[0]["ID"]);
                        isAuthorChanged = true;
                    }
                    else
                    {
                        idAuthor = DbConnector.Create("Автор", "ИмяАвтора",
                            $"'{changedAuthor}'",
                            "Не удалось изменить данные об авторе");
                    }

                    if (idAuthor != -1)
                    {
                        isAuthorChanged = DbConnector.Update("Трек", $"ID_Автор = {idAuthor}",
                            "Не удалось изменить данные об авторе",
                            $"ID = {selectedTrack.Author.Id}");
                    }
                }

                TracksList = TracksList.Select((subscription) =>
                {
                    if (subscription.Id == id)
                    {
                        if (isTrackChanged)
                        {
                            subscription.Name = changedName;
                        }

                        if (isAuthorChanged)
                        {
                            subscription.Author = new Author(idAuthor, changedAuthor);
                        }
                    }

                    return subscription;
                }).ToList();
            }
        }
    }
}