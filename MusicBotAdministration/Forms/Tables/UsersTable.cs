using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.EditData;

namespace MusicBotAdministration.Forms.Tables
{
    public partial class UsersTable : Form
    {
        // Пользователи
        private Users Users { get; set; }

        // Получение списка запросов
        private List<User> UserList
        {
            get => Users.UsersList;
            set => Users.UsersList = value;
        }

        // Создание таблицы и заголовков
        private static DataTable CreateUsersTable()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Пользователь", typeof(string)));
            table.Columns.Add(new DataColumn("Ссылка на VK", typeof(string)));

            return table;
        }

        // Добавление пользователей в таблицу и в DataGridView
        private void LoadUsersTable(object sender, EventArgs e)
        {
            try
            {
                // Создание таблицы
                var table = CreateUsersTable();

                // Добавление запросов в таблицу
                UserList.ForEach((user) => { table.Rows.Add(user.Id, user.FIO, user.Url); });
                // Добавленеи источника данных в DataGridView
                userTable.DataSource = table;

                // Изменение заголовка DataGridView
                userTableLabel.Text = $@"Пользователи ({userTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить пользователи", @"Ошибка");
            }
        }

        public UsersTable()
        {
            InitializeComponent();

            Users = new Users(LoadUsersTable, LoadUsersTable);
            UserList = Users.GetData();
        }

        // Добавление пользователя
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления пользователя
            using (var addUserForm = new EditUser())
            {
                // Если данные не получены из формы
                if (addUserForm.ShowDialog() != DialogResult.OK)
                    return;

                var idUser = DbConnector.Create("Пользователь",
                    "ФамилияИмя, СсылкаНаVK", $"'{addUserForm.FIO}', '{addUserForm.Url}'",
                    "Не удалось добавить данные о пользователе");

                if (idUser != -1)
                {
                    // Добавление в список
                    Users.Add(
                        new User(idUser, addUserForm.FIO, addUserForm.Url));
                }
            }
        }

        // Изменение трека
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных треков
            var selectedUsers = userTable.SelectedRows;

            if (selectedUsers.Count != 1)
            {
                MessageBox.Show(@"Выберите 1 пользователя", @"Ошибка");
                return;
            }

            // Открытие формы для изменения пользователя
            using (var editUserForm = new EditUser())
            {
                editUserForm.Text = @"Изменение пользователя";
                editUserForm.addTrackBtn.Text = @"Изменить";

                // Получение id выбранного пользователя
                var id = Convert.ToInt32(selectedUsers[0].Cells[0].Value);
                // Получение выбранного пользователя
                var selectedUser = UserList.Find((user) => user.Id == id);

                // Заполнение фамилии и имя
                editUserForm.fioInput.Text = selectedUser.FIO;
                editUserForm.fioInput.Enabled = false;
                // Заполнение ссылки на VK
                editUserForm.urlInput.Text = selectedUser.Url;

                // Если данные не получены из формы
                if (editUserForm.ShowDialog() != DialogResult.OK)
                    return;

                var changedUrl = editUserForm.Url;
                var isUrlChanged = false;

                if (selectedUser.Url != changedUrl)
                {
                    isUrlChanged = DbConnector.Update("Пользователь", $"СсылкаНаVK = '{changedUrl}'",
                        "Не удалось изменить данные о пользователе",
                        $"ID = {selectedUser.Id}");
                }

                UserList = UserList.Select((user) =>
                {
                    if (user.Id == id && isUrlChanged)
                    {
                        user.Url = changedUrl;
                    }

                    return user;
                }).ToList();
            }
        }
    }
}