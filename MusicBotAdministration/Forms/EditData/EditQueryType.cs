using System;
using System.Windows.Forms;

namespace MusicBotAdministration.Forms.EditData
{
    public partial class EditQueryType : Form
    {
        public string QueryTypeName { get; set; }

        public EditQueryType()
        {
            InitializeComponent();
        }

        private void addQueryTypeBtn_Click(object sender, EventArgs e)
        {
            // Проверка Названия
            if (queryTypeNameInput.Text == "")
            {
                MessageBox.Show(@"Укажите название типа запроса", @"Ошибка");
                queryTypeNameInput.Focus();
                return;
            }

            QueryTypeName = queryTypeNameInput.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}