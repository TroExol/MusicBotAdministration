using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicBotAdministration.Controls
{
    public partial class LatinTextBox : TextBox
    {
        // Корректен ли ввод
        private bool _isCorrect;

        public bool IsCorrect
        {
            get => _isCorrect;
            set => _isCorrect = value;
        }

        public LatinTextBox()
        {
            InitializeComponent();
        }

        public LatinTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // Проверка на ввод только англ. букв и цифр
            if (Regex.IsMatch(Text, @"[^\da-zA-Z]"))
            {
                IsCorrect = false;
                ForeColor = Color.Red;
            }
            else
            {
                IsCorrect = true;
                ForeColor = Color.Black;
            }

            base.OnTextChanged(e);
        }
    }
}