using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicBotAdministration.Controls
{
    public partial class DecimalBox : TextBox
    {
        // Корректен ли ввод
        public bool IsCorrect { get; set; }

        // Значение поля ввода
        private decimal _value;

        public decimal Value
        {
            get => _value;
            set => _value = Math.Round(Convert.ToDecimal(value));
        }

        public DecimalBox()
        {
            InitializeComponent();
        }

        public DecimalBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // Проверка на ввод числа
            if (decimal.TryParse(Text, out var value))
            {
                IsCorrect = true;
                Value = value;
                ForeColor = Color.Black;
            }
            else
            {
                IsCorrect = false;
                ForeColor = Color.Red;
            }

            base.OnTextChanged(e);
        }
    }
}