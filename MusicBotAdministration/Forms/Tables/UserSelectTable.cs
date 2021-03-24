using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.Tables
{
    public partial class UserSelectTable : Form
    {
        // Выбранный пользователь
        public User User { get; set; }

        // Список пользователей
        private List<User> _users { get; set; }

        public UserSelectTable()
        {
            InitializeComponent();

            // Создание таблицы пользователей
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Пользователь", typeof(string)));
            table.Columns.Add(new DataColumn("Ссылка на пользователя", typeof(string)));

            _users = Users.GetData();

            // Добавление данных о пользователях
            _users.ForEach((user) => table.Rows.Add(user.Id, user.FIO, user.Url));

            userTable.DataSource = table;
        }

        // При нажатии на "Выбрать" пользователя
        private void selectUserBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных строк
            var selectedRows = userTable.SelectedRows;

            if (selectedRows.Count > 0)
            {
                // Добавление выбранного пользователя
                User = _users.Find((user) => user.Id == (int) selectedRows[0].Cells[0].Value);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(@"Выберите пользователя");
            }
        }
    }
}