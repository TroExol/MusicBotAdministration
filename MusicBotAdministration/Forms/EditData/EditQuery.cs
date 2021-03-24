using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.EditData
{
    public partial class EditQuery : Form
    {
        public DateTime Date { get; set; }
        public int CountMusic { get; set; }
        public string Author { get; set; }
        public User User { get; set; }
        public QueryType QueryType { get; set; }
        private string QueryTypeName { get; set; }
        public List<Track> ReceivedTracks { get; set; }

        public EditQuery()
        {
            InitializeComponent();

            // Указание формата для даты запроса
            queryDateTimeInput.Format = DateTimePickerFormat.Custom;
            queryDateTimeInput.CustomFormat = @"dd/MM/yyyy HH:mm";
            queryDateTimeInput.Value = DateTime.Now;
            queryDateTimeInput.MaxDate = DateTime.Now;
            queryDateTimeInput.MinDate = new DateTime(2020, 03, 29, 20, 20, 20);

            // Типы запросов
            var queryTypes = QueryTypes.GetData();

            // Добавление типов запросов в выпадающий список
            var queryTypesKeyValuePair = queryTypes
                .Select(type => new KeyValuePair<int, string>(type.Id, type.Name))
                .ToList();

            queryTypeInput.DataSource = queryTypesKeyValuePair;
            queryTypeInput.DisplayMember = "Value";
            queryTypeInput.ValueMember = "Key";

            var allTracks = Tracks.GetData();
            receivedTracksInput.AllTracks = allTracks;
        }

        // Отправка запроса в первую форму
        private void addQueryBtn_Click(object sender, EventArgs e)
        {
            // Проверка ввода даты запроса
            if (queryDateTimeInput.Value.ToString(CultureInfo.CurrentCulture) == "")
            {
                MessageBox.Show(@"Укажите дату запроса", @"Ошибка");
                queryDateTimeInput.Focus();
                return;
            }

            // Проверка ввода количества треков
            if (QueryTypeName != "Функции" && !queryCountMusicInput.IsCorrect)
            {
                MessageBox.Show(@"Количество треков должно быть целым числом", @"Ошибка");
                queryCountMusicInput.Focus();
                return;
            }

            if (QueryTypeName != "Функции" && queryCountMusicInput.Text == "")
            {
                MessageBox.Show(@"Укажите количество треков", @"Ошибка");
                queryCountMusicInput.Focus();
                return;
            }

            // Проверка ввода пользователя
            if (!queryUserInput.IsSelected)
            {
                MessageBox.Show(@"Укажите пользователя", @"Ошибка");
                return;
            }

            if (QueryTypeName != "Функции" && receivedTracksInput.SelectedTracks.Count == 0)
            {
                receivedTracksInput.Focus();
                MessageBox.Show(@"Укажите полученные треки", @"Ошибка");
                return;
            }

            // Проверка ввода типа запроса
            if (queryTypeInput.SelectedItem == null)
            {
                MessageBox.Show(@"Укажите тип запроса", @"Ошибка");
                queryTypeInput.Focus();
                return;
            }

            Date = queryDateTimeInput.Value;
            CountMusic = queryCountMusicInput.Text != "" && QueryTypeName != "Функции"
                ? Convert.ToInt32(queryCountMusicInput.Text)
                : 0;
            Author = QueryTypeName != "Функции" ? queryAuthorInput.Text : "";
            User = queryUserInput.User;
            QueryType = new QueryType(Convert.ToInt32(queryTypeInput.SelectedValue), QueryTypeName);
            ReceivedTracks = QueryTypeName != "Функции" ? receivedTracksInput.SelectedTracks : new List<Track>();

            DialogResult = DialogResult.OK;
            Close();
        }

        // При изменении выбора типа запросов
        private void queryTypeInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryTypeName = ((KeyValuePair<int, string>) queryTypeInput.SelectedItem).Value;

            if (QueryTypeName == "Функции")
            {
                queryCountMusicInput.Text = "";
                queryAuthorInput.Text = "";
                queryCountMusicInput.Enabled = false;
                queryAuthorInput.Enabled = false;
                receivedTracksInput.Enabled = false;
                receivedTracksInput.selectTracksTable.ForeColor = Color.SlateGray;
                receivedTracksInput.SelectedTracks = new List<Track>();
                receivedTracksInput.selectTracksTable.ClearSelection();
            }
            else
            {
                queryCountMusicInput.Enabled = true;
                queryAuthorInput.Enabled = true;
                receivedTracksInput.Enabled = true;
                receivedTracksInput.selectTracksTable.ForeColor = Color.Black;
            }
        }
    }
}