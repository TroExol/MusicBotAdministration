using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.EditData;

namespace MusicBotAdministration.Forms.Tables
{
    public partial class PaymentsTable : Form
    {
        private Payments Payments { get; set; }

        // Получение списка запросов
        private List<Payment> PaymentsList
        {
            get => Payments.PaymentsList;
            set => Payments.PaymentsList = value;
        }

        // Создание таблицы и заголовков
        private static DataTable CreatePaymentsTable()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Дата оплаты", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Сумма, руб", typeof(string)));
            table.Columns.Add(new DataColumn("Пользователь", typeof(string)));
            table.Columns.Add(new DataColumn("Ссылка на пользователя", typeof(string)));
            table.Columns.Add(new DataColumn("Подписка", typeof(string)));

            return table;
        }

        // Добавление оплат в таблицу и в DataGridView
        private void LoadPaymentsTable(object sender, EventArgs e)
        {
            try
            {
                // Создание таблицы
                var table = CreatePaymentsTable();

                // Добавление запросов в таблицу
                PaymentsList.ForEach((payment) =>
                {
                    table.Rows.Add(payment.Id, payment.Date, payment.Subscription.Sum,
                        payment.User.FIO, payment.User.Url, payment.Subscription.Name);
                });
                // Добавленеи источника данных в DataGridView
                generalPaymentsTable.DataSource = table;

                // Изменение заголовка DataGridView
                paymentsTableLabel.Text = $@"Оплаты ({generalPaymentsTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить оплаты", @"Ошибка");
            }
        }

        public PaymentsTable()
        {
            InitializeComponent();
            Payments = new Payments(LoadPaymentsTable, LoadPaymentsTable);
            PaymentsList = Payments.GetData();
        }

        // Нажатие на "Добавить" данные об оплате
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления оплаты
            using (var addPaymentForm = new EditPayment())
            {
                addPaymentForm.Text = @"Добавление оплаты";
                addPaymentForm.addPaymentBtn.Text = @"Добавить";

                // Если данные не получены из формы
                if (addPaymentForm.ShowDialog() != DialogResult.OK)
                    return;

                var id = DbConnector.Create("ОплатаПодписки",
                    "ДатаОплаты, ID_Пользователь, ID_Подписка",
                    $"'{addPaymentForm.Date.ToString(CultureInfo.CurrentCulture)}', " +
                    $"{addPaymentForm.User.Id}, {addPaymentForm.Subscription.Id}",
                    "Не удалось добавить данные об оплате");

                if (id != -1)
                {
                    // Добавление в список
                    Payments.Add(new Payment(id, addPaymentForm.Date,
                        addPaymentForm.User, addPaymentForm.Subscription));
                }
            }
        }

        // Нажатие на "Изменить" данные об оплате
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных запросов
            var selectedPayments = generalPaymentsTable.SelectedRows;

            if (selectedPayments.Count != 1)
            {
                MessageBox.Show(@"Выберите 1 оплату", @"Ошибка");
                return;
            }

            // Открытие формы для изменения оплаты
            using (var editPaymentForm = new EditPayment())
            {
                editPaymentForm.Text = @"Изменение оплаты";
                editPaymentForm.addPaymentBtn.Text = @"Изменить";

                // Получение id выбранной оплаты
                var id = Convert.ToInt32(selectedPayments[0].Cells[0].Value);
                // Получение выбранной оплаты
                var selectedPayment = PaymentsList.Find((payment) => payment.Id == id);

                // Заполнение подписки
                foreach (KeyValuePair<int, string> subscriptionItem in editPaymentForm.subscriptionInput.Items)
                {
                    if (subscriptionItem.Key == selectedPayment.Subscription.Id)
                    {
                        editPaymentForm.subscriptionInput.SelectedItem = subscriptionItem;
                        break;
                    }
                }

                editPaymentForm.Subscription = selectedPayment.Subscription;
                // Заполнение даты
                editPaymentForm.dateInput.Value = selectedPayment.Date;
                // Заполнение пользователя
                editPaymentForm.userInput.User = selectedPayment.User;
                editPaymentForm.userInput.IsSelected = true;

                // Если данные не получены из формы
                if (editPaymentForm.ShowDialog() != DialogResult.OK)
                    return;

                var isUpdated = DbConnector.Update("ОплатаПодписки",
                    $"ДатаОплаты = '{editPaymentForm.Date.ToString(CultureInfo.CurrentCulture)}', " +
                    $"ID_Пользователь = {editPaymentForm.User.Id}, ID_Подписка = {editPaymentForm.Subscription.Id}",
                    "Не удалось изменить данные об оплате",
                    $"ID = {selectedPayment.Id}");

                if (isUpdated)
                {
                    // Изменение запроса
                    PaymentsList = PaymentsList.Select(payment =>
                    {
                        if (payment.Id == id)
                        {
                            payment.Date = editPaymentForm.Date;
                            payment.User = editPaymentForm.User;
                            payment.Subscription = editPaymentForm.Subscription;
                        }

                        return payment;
                    }).ToList();
                }
            }
        }

        // Нажатие на "Удалить" данные об оплатах
        private void removeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных оплат
            var selectedPayments = generalPaymentsTable.SelectedRows;

            if (selectedPayments.Count < 1)
            {
                MessageBox.Show(@"Выберите оплаты для удаления", @"Ошибка");
                return;
            }

            // Подтверждение удаления
            if (MessageBox.Show(@"Точно хотите удалить выбранные оплаты?", @"Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            // Получение списка id на удаление
            var removeIds = new List<int>();
            foreach (DataGridViewRow selectedPayment in selectedPayments)
            {
                var id = (int) selectedPayment.Cells[0].Value;
                var isDeleted = DbConnector.Delete("ОплатаПодписки",
                    $"Не удалось удалить данные об оплате с id {id}",
                    $"ID = {id}");
                if (isDeleted)
                {
                    removeIds.Add(id);
                }
            }
            
            // Удаление оплат с выбранными id
            PaymentsList = PaymentsList
                .Where(payment => !removeIds.Exists((id) => payment.Id == id))
                .ToList();
        }
    }
}