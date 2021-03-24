using System;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.Tables;

namespace MusicBotAdministration.Controls
{
    public partial class SelectUser : UserControl
    {
        // Выбран ли пользователь
        public bool IsSelected { get; set; }

        private User _user;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                if (_user != null)
                {
                    TextBox = _user.FIO;
                }
            }
        }

        public string TextBox
        {
            get => Text;
            set
            {
                Text = value;
                queryUserInput.Text = value;
            }
        }

        public SelectUser()
        {
            InitializeComponent();
        }

        // Открытие формы для выбора пользователя
        private void openSelectUserBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы
            using (var userSelectForm = new UserSelectTable())
            {
                // Если форма не вернула данные
                if (userSelectForm.ShowDialog() != DialogResult.OK)
                    return;

                User = userSelectForm.User;
                TextBox = User.FIO;
                IsSelected = true;
            }
        }
    }
}