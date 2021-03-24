using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicBotAdministration.Controls
{
    public partial class NumberBox : TextBox
    {
        // Корректен ли ввод
        public bool IsCorrect { get; set; }

        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // Проверка на ввод только целых чисел
            if (Regex.IsMatch(Text, @"[^\d]"))
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