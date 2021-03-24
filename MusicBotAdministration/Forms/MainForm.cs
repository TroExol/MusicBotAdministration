using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.EditData;
using MusicBotAdministration.Forms.Reports;
using MusicBotAdministration.Forms.Tables;
using MusicBotAdministration.Forms.UserActions;

namespace MusicBotAdministration.Forms
{
    public partial class MainForm : Form
    {
        // ФИО администратора
        private string _fio;

        // Логин администратора
        private string _login;

        public string FIO
        {
            get => _fio;
            set
            {
                _fio = value;
                // Установить ФИО в статус
                FIOStatusLabel.Text = value;
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                // Установить логин в статус
                LoginStatusLabel.Text = value;
            }
        }

        // Запросы
        private Queries Queries { get; set; }

        // Получение списка запросов
        private List<Query> QueriesList
        {
            get => Queries.QueriesList;
            set => Queries.QueriesList = value;
        }

        // Создание таблицы и заголовков
        private static DataTable CreateQueriesTable()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Дата запроса", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Количество треков", typeof(int)));
            table.Columns.Add(new DataColumn("Запрашиваемый автор", typeof(string)));
            table.Columns.Add(new DataColumn("Пользователь", typeof(string)));
            table.Columns.Add(new DataColumn("Ссылка на пользователя", typeof(string)));
            table.Columns.Add(new DataColumn("Тип запроса", typeof(string)));
            table.Columns.Add(new DataColumn("Полученные треки", typeof(string)));

            return table;
        }

        // Добавление запросов в таблицу и в DataGridView
        private void LoadQueriesTable(object sender, EventArgs e)
        {
            try
            {
                // Создание таблицы
                var table = CreateQueriesTable();

                // Добавление запросов в таблицу
                QueriesList.ForEach((query) =>
                {
                    var receivedTracks =
                        String.Join("," + Environment.NewLine,
                            query.ReceivedTracks.Select(track => $"{track.Author.Name} - {track.Name}").ToArray());
                    table.Rows.Add(query.Id, query.Date, query.CountMusic, query.Author,
                        query.User.FIO, query.User.Url, query.QueryType.Name, receivedTracks);
                });
                // Добавленеи источника данных в DataGridView
                queriesTable.DataSource = table;

                // Изменение заголовка DataGridView
                queriesTableLabel.Text = $@"Запросы ({queriesTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить запросы", @"Ошибка");
            }
        }

        public MainForm()
        {
            InitializeComponent();

            Queries = new Queries(LoadQueriesTable, LoadQueriesTable);
            QueriesList = Queries.GetData();
        }

        // Нажатие на "О программе"
        private void AboutProgMenuItem_Click(object sender, EventArgs e)
        {
            var aboutProgForm = new AboutProgram();
            aboutProgForm.ShowDialog();
        }

        // Нажатие на "Выйти из администратора"
        private void ExitUser_Click(object sender, EventArgs e)
        {
            // Подтверждение выхода
            if (MessageBox.Show(@"Точно хотите выйти из администратора?", @"Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var authForm = new Auth();
            Hide();
            authForm.Show();
        }

        // Нажатие на "Изменить пароль"
        private void ChangePassMenuItem_Click(object sender, EventArgs e)
        {
            var changePassForm = new ChangePass {Login = Login};
            changePassForm.ShowDialog();
        }

        // Нажатие на "Добавить" данные о запросе
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления запроса
            using (var addQueryForm = new EditQuery())
            {
                addQueryForm.Text = @"Добавление запроса";
                addQueryForm.addQueryBtn.Text = @"Добавить";

                // Если данные не получены из формы
                if (addQueryForm.ShowDialog() != DialogResult.OK)
                    return;

                var date = addQueryForm.Date;
                var countTrack = addQueryForm.CountMusic;
                var requiredAuthor = addQueryForm.Author;
                var user = addQueryForm.User;
                var queryType = addQueryForm.QueryType;
                var receivedTracks = addQueryForm.ReceivedTracks;
                var receivedTracksAdded = new List<Track>();

                var id = DbConnector.Create("Запрос",
                    "ДатаЗапроса, КоличествоТреков, ЗапрашиваемыйАвтор, ID_Пользователь, ID_ТипЗапроса",
                    $"'{date.ToString(CultureInfo.CurrentCulture)}', {countTrack}, '{requiredAuthor}'," +
                    $"{user.Id}, {queryType.Id}",
                    "Не удалось добавить данные о запросе");

                if (id != -1)
                {
                    receivedTracks.ForEach(track =>
                    {
                        var idTrack = DbConnector.Create("ПолученныйТрек",
                            "ID_Трек, ID_Запрос", $"{track.Id}, {id}",
                            $"Не удалось добавить данные о полученном треке {track.Name}");

                        if (idTrack != -1)
                        {
                            receivedTracksAdded.Add(track);
                        }
                    });

                    // Добавление запроса в список запросов
                    Queries.Add(new Query(id, date, countTrack, requiredAuthor,
                        user, queryType, receivedTracksAdded));
                }
            }
        }

        // Нажатие на "Изменить" данные о запросе
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных запросов
            var selectedQueries = queriesTable.SelectedRows;

            if (selectedQueries.Count != 1)
            {
                MessageBox.Show(@"Выберите 1 запрос", @"Ошибка");
                return;
            }

            // Открытие формы для изменения запроса
            using (var editQueryForm = new EditQuery())
            {
                editQueryForm.Text = @"Изменение запроса";
                editQueryForm.addQueryBtn.Text = @"Изменить";

                // Получение id выбранного запроса
                var id = Convert.ToInt32(selectedQueries[0].Cells[0].Value);
                // Получение выбранного запроса
                var selectedQuery = QueriesList.Find((query) => query.Id == id);

                // Заполнение типа запроса
                foreach (KeyValuePair<int, string> typeItem in editQueryForm.queryTypeInput.Items)
                {
                    if (typeItem.Key == selectedQuery.QueryType.Id)
                    {
                        editQueryForm.queryTypeInput.SelectedItem = typeItem;
                        break;
                    }
                }

                // Заполнение полученных треков
                editQueryForm.receivedTracksInput.SelectedTracks =
                    selectedQuery.ReceivedTracks.Select(track => track).ToList();

                editQueryForm.QueryType = selectedQuery.QueryType;
                // Заполнение даты
                editQueryForm.queryDateTimeInput.Value = selectedQuery.Date;
                // Заполнение кол-ва треков
                editQueryForm.queryCountMusicInput.Text = selectedQuery.CountMusic.ToString();
                // Заполнение автора
                editQueryForm.queryAuthorInput.Text = selectedQuery.Author;
                // Заполнение пользователя
                editQueryForm.queryUserInput.User = selectedQuery.User;
                editQueryForm.queryUserInput.IsSelected = true;

                // Если данные не получены из формы
                if (editQueryForm.ShowDialog() != DialogResult.OK)
                    return;

                var date = editQueryForm.Date;
                var countTracks = editQueryForm.CountMusic;
                var requiredAuthor = editQueryForm.Author;
                var user = editQueryForm.User;
                var queryType = editQueryForm.QueryType;
                var receivedTracks = editQueryForm.ReceivedTracks;
                var newReceivedTracks = editQueryForm.ReceivedTracks;

                var isQueryUpdated = DbConnector.Update("Запрос",
                    $"ДатаЗапроса = '{date.ToString(CultureInfo.CurrentCulture)}'," +
                    $"КоличествоТреков = {countTracks}, ЗапрашиваемыйАвтор = '{requiredAuthor}'," +
                    $"ID_Пользователь = {user.Id}, ID_ТипЗапроса = {queryType.Id}",
                    "Не удалось изменить данные о запросе",
                    $"ID = {selectedQuery.Id}");

                if (isQueryUpdated)
                {
                    if (!Misc.ListsAreEqual(selectedQuery.ReceivedTracks, receivedTracks))
                    {
                        var toDelete = selectedQuery.ReceivedTracks.Where(track =>
                            !receivedTracks.Exists(changedTrack =>
                                changedTrack.Id == track.Id)).ToList();
                        var toCreate = receivedTracks.Where(changedTrack =>
                            !selectedQuery.ReceivedTracks.Exists(track =>
                                changedTrack.Id == track.Id)).ToList();

                        toDelete.ForEach(track =>
                        {
                            var isDeleted = DbConnector.Delete("ПолученныйТрек", "",
                                $"ID_Трек = {track.Id} AND ID_Запрос = {selectedQuery.Id}");

                            if (!isDeleted)
                            {
                                newReceivedTracks.Add(track);
                            }
                        });

                        toCreate.ForEach(track =>
                        {
                            var idCreate = DbConnector.Create("ПолученныйТрек",
                                "ID_Запрос, ID_Трек",
                                $"{selectedQuery.Id}, {track.Id}", "");

                            if (idCreate == -1)
                            {
                                newReceivedTracks.RemoveAt(
                                    receivedTracks
                                        .FindIndex(findTrack => findTrack.Id == track.Id)
                                );
                            }
                        });
                    }

                    // Изменение запроса
                    QueriesList = QueriesList.Select((query) =>
                    {
                        if (query.Id == id)
                        {
                            query.Date = date;
                            query.CountMusic = countTracks;
                            query.Author = requiredAuthor;
                            query.User = user;
                            query.QueryType = queryType;
                            query.ReceivedTracks = newReceivedTracks;

                            if (!Misc.ListsAreEqual(receivedTracks, newReceivedTracks))
                            {
                                MessageBox.Show(@"Не удалось изменить весь список полученных треков",
                                    @"Предупреждение");
                            }
                        }

                        return query;
                    }).ToList();
                }
            }
        }

        // Нажатие на "Удалить" данные о запросах
        private void removeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных запросов
            var selectedQueries = queriesTable.SelectedRows;

            if (selectedQueries.Count < 1)
            {
                MessageBox.Show(@"Выберите запросы для удаления", @"Ошибка");
                return;
            }

            // Подтверждение удаления
            if (MessageBox.Show(@"Точно хотите удалить выбранные запросы?", @"Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            // Получение списка id на удаление
            var removeIds = new List<int>();
            foreach (DataGridViewRow selectedQuery in selectedQueries)
            {
                var id = (int) selectedQuery.Cells[0].Value;
                var isDeleted = DbConnector.Delete("Запрос",
                    $"Не удалось удалить данные о запросе с id {id}",
                    $"ID = {id}");
                if (isDeleted)
                {
                    removeIds.Add(id);
                }
            }

            // Удаление запросов с выбранными id
            QueriesList = QueriesList
                .Where((query) => !removeIds.Exists((id) => query.Id == id))
                .ToList();
        }

        private void workTypesMenuItem_Click(object sender, EventArgs e)
        {
            // Открытие формы для изменения типа запроса
            using (var queryTypesTableForm = new QueryTypesTable())
            {
                // При закрытии формы
                if (queryTypesTableForm.ShowDialog() != DialogResult.OK)
                    return;

                // Если типы запросов изменились
                if (queryTypesTableForm.IsChanged)
                {
                    // Загрузка запросов
                    QueriesList = Queries.GetData();
                }
            }
        }

        private void workUsersMenuItem_Click(object sender, EventArgs e)
        {
            new UsersTable().Show();
        }

        private void workSubsMenuItem_Click(object sender, EventArgs e)
        {
            new SubscriptionsTable().Show();
        }

        private void workMusicMenuItem_Click(object sender, EventArgs e)
        {
            new TracksTable().Show();
        }

        private void workPaymentsMenuItem_Click(object sender, EventArgs e)
        {
            new PaymentsTable().Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QueriesReport().Show();
        }

        private void оплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProfitReport().Show();
        }

        private void типыЗапросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PopularQueryTypesReport().Show();
        }

        private void активныеПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserActivitiesReport().Show();
        }

        private void конструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SqlConstructor.SqlConstructor().ShowDialog();
        }
    }
}