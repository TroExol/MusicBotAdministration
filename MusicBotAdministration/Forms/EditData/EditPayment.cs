using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.EditData
{
    public partial class EditPayment : Form
    {
        // Дата оплаты
        public DateTime Date { get; set; }

        // Пользователь
        public User User { get; set; }

        // Подписка
        public Subscription Subscription { get; set; }

        public EditPayment()
        {
            InitializeComponent();

            // Указание формата для даты запроса
            dateInput.Format = DateTimePickerFormat.Custom;
            dateInput.CustomFormat = @"dd/MM/yyyy HH:mm";
            dateInput.Value = DateTime.Now;
            dateInput.MaxDate = DateTime.Now;
            dateInput.MinDate = new DateTime(2020, 03, 29, 20, 20, 20);

            // Подписки
            var subscriptions = Subscriptions.GetData();

            // Добавление подписок в выпадающий список
            var subscriptionsKeyValuePair = subscriptions
                .Select(subscription => new KeyValuePair<int, string>(subscription.Id, subscription.Name))
                .ToList();
            subscriptionInput.DataSource = subscriptionsKeyValuePair;
            subscriptionInput.DisplayMember = "Value";
            subscriptionInput.ValueMember = "Key";
        }

        private void addQueryBtn_Click(object sender, EventArgs e)
        {
            // Проверка ввода даты оплаты
            if (dateInput.Value.ToString(CultureInfo.InvariantCulture) == "")
            {
                MessageBox.Show(@"Укажите дату оплаты", @"Ошибка");
                dateInput.Focus();
                return;
            }

            // Проверка ввода пользователя
            if (!userInput.IsSelected)
            {
                MessageBox.Show(@"Укажите пользователя", @"Ошибка");
                userInput.Focus();
                return;
            }

            // Проверка ввода подписки
            if (subscriptionInput.SelectedItem == null)
            {
                MessageBox.Show(@"Укажите подписку", @"Ошибка");
                subscriptionInput.Focus();
                return;
            }

            Date = dateInput.Value;
            User = userInput.User;

            var subscriptions = Subscriptions.GetData();
            Subscription = subscriptions.Find(subscription =>
                subscription.Id == Convert.ToInt32(subscriptionInput.SelectedValue));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}