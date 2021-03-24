using System;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.UserActions
{
    public partial class ChangePass : Form
    {
        public string Login { get; set; }
        
        public ChangePass()
        {
            InitializeComponent();
        }

        // При нажатии на изменить пароль
        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            if (newPassInput.Text.Length < 6 || newPassInput.Text.Length > 20)
            {
                MessageBox.Show(@"Длина нового пароля не может быть меньше 6 и больше 20");
                newPassInput.Focus();
                return;
            }

            if (newPassInput.Text == oldPassInput.Text)
            {
                MessageBox.Show(@"Новый пароль должен отличаться от старого");
                newPassInput.Focus();
                return;
            }
            
            var administrators = DbConnector.Read("Администратор",
                "Не удалось получить данные об администраторе", "*",
                $"WHERE Логин = '{Login}'").ToList();

            if (administrators.Count <= 0)
            {
                return;
            }

            var administrator = administrators[0];

            if (oldPassInput.Text != (string) administrator["Пароль"])
            {
                MessageBox.Show(@"Старый пароль указан неверно", @"Ошибка");
                return;
            }

            var isUpdated = DbConnector.Update("Администратор",
                $"Пароль = '{newPassInput.Text}'",
                "Не удалось изменить пароль администратора",
                $"Логин = '{Login}'");

            if (isUpdated)
            {
                MessageBox.Show(@"Пароль успешно изменен");
                newPassInput.Text = "";
                oldPassInput.Text = "";
            }
        }
    }
}