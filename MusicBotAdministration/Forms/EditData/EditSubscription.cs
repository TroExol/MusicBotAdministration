using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.EditData
{
    public partial class EditSubscription : Form
    {
        public string SubscriptionName { get; set; }
        public decimal Sum { get; set; }
        public List<QueryType> AvailableQueryTypes { get; set; }

        public EditSubscription()
        {
            InitializeComponent();

            var queryTypeNames = QueryTypes.GetData().Select(queryType => (object) queryType.Name).ToArray();
            // Заполнение доступных типов запросов
            availableQueryTypesInput.Items.AddRange(queryTypeNames);
        }

        private void addSubscriptionBtn_Click(object sender, EventArgs e)
        {
            // Проверка названия
            if (subscriptionNameInput.Text == "")
            {
                MessageBox.Show(@"Укажите название подписки", @"Ошибка");
                subscriptionNameInput.Focus();
                return;
            }

            // Проверка стоимости подписки
            if (!sumInput.IsCorrect)
            {
                MessageBox.Show(@"Укажите стоимость подписки", @"Ошибка");
                sumInput.Focus();
                return;
            }

            // Проверка типов запросов
            var selectedItems = availableQueryTypesInput.SelectedItems.Cast<String>().ToList();
            if (selectedItems.Count < 1)
            {
                MessageBox.Show(@"Выберите хотя бы 1 доступный тип запроса", @"Ошибка");
                availableQueryTypesInput.Focus();
                return;
            }

            SubscriptionName = subscriptionNameInput.Text;
            Sum = sumInput.Value;
            AvailableQueryTypes = QueryTypes.GetData().Where(queryType =>
                selectedItems.Exists(selectedQueryType => selectedQueryType == queryType.Name)).ToList();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}