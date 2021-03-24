using System;
using System.Windows.Forms;

namespace MusicBotAdministration.Forms.EditData
{
    public partial class EditUser : Form
    {
        public string FIO { get; set; }
        public string Url { get; set; }
        
        public EditUser()
        {
            InitializeComponent();
        }
        
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            // Проверка ФИО
            if (fioInput.Text == "")
            {
                MessageBox.Show(@"Укажите фамилию и имя", @"Ошибка");
                fioInput.Focus();
                return;
            }

            // Проверка ссылки на VK
            if (urlInput.Text == "")
            {
                MessageBox.Show(@"Укажите ссылку на VK", @"Ошибка");
                urlInput.Focus();
                return;
            }

            FIO = fioInput.Text;
            Url = urlInput.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}