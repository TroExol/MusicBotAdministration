using System;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.UserActions
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            loginInput.Text = "iaklochkovskiy";
            passwordInput.Text = "123456";
        }

        // При нажатии "Войти"
        private void Authorize_Click(object sender, EventArgs e)
        {
            if (loginInput.Text == "")
            {
                MessageBox.Show(@"Укажите логин");
                loginInput.Focus();
                return;
            }

            if (passwordInput.Text == "")
            {
                MessageBox.Show(@"Укажите пароль");
                passwordInput.Focus();
                return;
            }

            var administrators = DbConnector.Read("Администратор",
                "Не удалось получить данные об администраторе", "*",
                $"WHERE Логин = '{loginInput.Text}'").ToList();

            if (administrators.Count <= 0)
            {
                MessageBox.Show(@"Неправильный логин", @"Ошибка");
                return;
            }

            var administrator = administrators[0];

            if (passwordInput.Text != (string) administrator["Пароль"])
            {
                MessageBox.Show(@"Неправильный пароль", @"Ошибка");
                return;
            }

            var mainForm = new MainForm();
            mainForm.FIO = (string) administrator["ФИО"];
            mainForm.Login = (string) administrator["Логин"];
            Hide();
            mainForm.Show();
        }

        // После закрытия главной формы
        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}