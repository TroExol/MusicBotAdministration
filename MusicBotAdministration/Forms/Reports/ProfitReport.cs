using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MusicBotAdministration.Classes;
using DataTable = System.Data.DataTable;

namespace MusicBotAdministration.Forms.Reports
{
    public partial class ProfitReport : Form
    {
        public ProfitReport()
        {
            InitializeComponent();
            
            // Указание формата для даты
            dateFromInput.Format = DateTimePickerFormat.Custom;
            dateFromInput.CustomFormat = @"dd/MM/yyyy HH:mm";
            dateFromInput.Value = DateTime.Now.AddDays(-7);
            dateFromInput.MaxDate = DateTime.Now;
            dateFromInput.MinDate = new DateTime(2020, 03, 29, 20, 20, 20);

            dateToInput.Format = DateTimePickerFormat.Custom;
            dateToInput.CustomFormat = @"dd/MM/yyyy HH:mm";
            dateToInput.Value = DateTime.Now;
            dateToInput.MaxDate = DateTime.Now;
            dateToInput.MinDate = new DateTime(2020, 03, 29, 20, 20, 20);

            var subscriptions = Subscriptions.GetData();
            // Добавление подписок в выпадающий список
            var subscriptionsKeyValuePair = subscriptions
                .Select(subscription => new KeyValuePair<int, string>(subscription.Id, subscription.Name))
                .ToList();

            subscriptionInput.DataSource = subscriptionsKeyValuePair;
            subscriptionInput.DisplayMember = "Value";
            subscriptionInput.ValueMember = "Key";
        }
        
        private void dateFromInput_ValueChanged(object sender, EventArgs e)
        {
            if (dateFromInput.Value.ToString(CultureInfo.CurrentCulture) != "")
            {
                dateToInput.MinDate = dateFromInput.Value;
            }
        }

        private void dateToInput_ValueChanged(object sender, EventArgs e)
        {
            if (dateToInput.Value.ToString(CultureInfo.CurrentCulture) != "")
            {
                dateFromInput.MaxDate = dateToInput.Value;
            }
        }
        
        private void showBtn_Click(object sender, EventArgs e)
        {
            var isDate = isDateFilter.Checked;
            var isSubscription = isSubscriptionFilter.Checked;
            var isUser = isUserFilter.Checked;
            var dateFromFilter = dateFromInput.Value;
            var dateToFilter = dateToInput.Value;
            var subscriptionFilter = Convert.ToInt32(subscriptionInput.SelectedValue);
            var userFilter = userInput.User;

            // Проверка ввода пользователя
            if (isUser && !userInput.IsSelected)
            {
                MessageBox.Show(@"Укажите фильтр пользователя", @"Ошибка");
                return;
            }

            var whereStr = "";
            if (isDate)
            {
                whereStr += $" AND ДатаОплаты >= '{dateFromFilter.ToString(CultureInfo.CurrentCulture)}' AND" +
                            $" ДатаОплаты <= '{dateToFilter.ToString(CultureInfo.CurrentCulture)}' ";
            }

            if (isSubscription)
            {
                whereStr += $" AND ID_Подписка = {subscriptionFilter} ";
            }

            if (isUser)
            {
                whereStr += $" AND ID_Пользователь = {userFilter.Id} ";
            }
            
            var paymentsFromDb = DbConnector.Read("ОплатаПодписки",
                    "Не удалось получить данные об оплатах",
                    "ISNULL(CONVERT(CHAR(10),ДатаОплаты,104), 'Итог') AS ДатаОплаты," +
                    " ISNULL(Подписка.Название, 'Итог') AS Подписка, Count(Подписка.ID) AS КолвоПодписок," +
                    " sum(Стоимость) AS Прибыль",
                    " INNER JOIN Подписка ON ОплатаПодписки.ID_Подписка = Подписка.ID" + whereStr +
                    @" OUTER APPLY (
                        Select TOP 1 *
                        From СтоимостьПодписки 
                        WHERE СтоимостьПодписки.ID_Подписка = Подписка.ID
		                    AND ДатаДобавленияСтоимости <= ДатаОплаты
	                    ORDER BY ДатаДобавленияСтоимости DESC
                        ) Стоимость
                    GROUP BY CONVERT(CHAR(10), ДатаОплаты, 104), Подписка.Название WITH ROLLUP
                    ORDER BY CONVERT(DATETIME, CONVERT(CHAR(10), ДатаОплаты, 104), 104) DESC")
                .Select(payment =>
                {
                    var dictionary = new Dictionary<string, object>();
                    dictionary.Add("ДатаОплаты", payment["ДатаОплаты"]);
                    dictionary.Add("Подписка", payment["Подписка"]);
                    dictionary.Add("КолвоПодписок", payment["КолвоПодписок"]);
                    dictionary.Add("Прибыль", payment["Прибыль"]);
                    return dictionary;
                }).ToList();
            
            var table = new DataTable();
            table.Columns.Add(new DataColumn("Дата оплаты", typeof(string)));
            table.Columns.Add(new DataColumn("Подписка", typeof(string)));
            table.Columns.Add(new DataColumn("Куплено подписок", typeof(int)));
            table.Columns.Add(new DataColumn("Прибыль", typeof(decimal)));
            
            try
            {
                // Добавление оплат в таблицу
                paymentsFromDb.ForEach((payment) =>
                {
                    var date = payment["ДатаОплаты"].ToString();
                    var subscription = payment["Подписка"].ToString();
                    var countSubscriptions = Convert.ToInt32(payment["КолвоПодписок"]);
                    var profit = Convert.ToDecimal(payment["Прибыль"]);
                    table.Rows.Add(date, subscription, countSubscriptions, profit);
                });
                // Добавленеи источника данных в DataGridView
                profitReportTable.DataSource = table;

                // Изменение заголовка DataGridView
                decimal totalProfit = 0;
                if (paymentsFromDb.Count > 0)
                {
                    totalProfit = Convert.ToDecimal(paymentsFromDb.Last()["Прибыль"]);
                }
                queriesTableLabel.Text = $@"Прибыль ({totalProfit} руб.)";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить оплаты", @"Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            _Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Прибыль";
            for (var i = 1; i < profitReportTable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = profitReportTable.Columns[i - 1].HeaderText;
            }

            for (var i = 0; i < profitReportTable.Rows.Count; i++)
            {
                for (var j = 0; j < profitReportTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = profitReportTable.Rows[i].Cells[j].Value.ToString();
                }
            }

            try
            {
                workbook.SaveAs("Прибыль с подписок.xls", Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing,
                    XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                    Type.Missing,
                    Type.Missing);
            }
            catch
            {
                // ignored
            }
        }
    }
}