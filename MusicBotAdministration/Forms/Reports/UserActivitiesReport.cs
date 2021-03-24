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
    public partial class UserActivitiesReport : Form
    {
        public UserActivitiesReport()
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
            var dateFromFilter = dateFromInput.Value;
            var dateToFilter = dateToInput.Value;

            var whereStr = "";
            if (isDate)
            {
                whereStr += $" AND ДатаЗапроса >= '{dateFromFilter.ToString(CultureInfo.CurrentCulture)}' AND" +
                            $" ДатаЗапроса <= '{dateToFilter.ToString(CultureInfo.CurrentCulture)}' ";
            }

            var queriesFromDb = DbConnector.Read("Запрос",
                    "Не удалось получить данные о пользователях",
                    "ФамилияИмя, СсылкаНаVK, COUNT(Запрос.ID_Пользователь) AS КолвоЗапросов",
                    " INNER JOIN Пользователь ON Запрос.ID_Пользователь = Пользователь.ID" + whereStr +
                    " GROUP BY ФамилияИмя, СсылкаНаVK ORDER BY КолвоЗапросов DESC")
                .Select(query =>
                {
                    var dictionary = new Dictionary<string, object>();
                    dictionary.Add("ФамилияИмя", query["ФамилияИмя"]);
                    dictionary.Add("СсылкаНаVK", query["СсылкаНаVK"]);
                    dictionary.Add("КолвоЗапросов", query["КолвоЗапросов"]);
                    return dictionary;
                }).ToList();

            var table = new DataTable();
            table.Columns.Add(new DataColumn("Пользователь", typeof(string)));
            table.Columns.Add(new DataColumn("Ссылка на VK", typeof(string)));
            table.Columns.Add(new DataColumn("Кол-во запросов", typeof(int)));

            try
            {
                // Добавление оплат в таблицу
                queriesFromDb.ForEach((query) =>
                {
                    var fio = query["ФамилияИмя"].ToString();
                    var url = query["СсылкаНаVK"].ToString();
                    var countQueries = Convert.ToInt32(query["КолвоЗапросов"]);
                    table.Rows.Add(fio, url, countQueries);
                });
                // Добавленеи источника данных в DataGridView
                userActivitiesTable.DataSource = table;

                // Изменение заголовка DataGridView
                decimal totalQueries = queriesFromDb.Count > 0
                    ? queriesFromDb.Sum(query =>
                    Convert.ToInt32(query["КолвоЗапросов"]))
                    : 0;

                usersTableLabel.Text = $@"Пользователи ({totalQueries} запросов)";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить пользователей", @"Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            _Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Активность пользователей";
            for (var i = 1; i < userActivitiesTable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = userActivitiesTable.Columns[i - 1].HeaderText;
            }

            for (var i = 0; i < userActivitiesTable.Rows.Count; i++)
            {
                for (var j = 0; j < userActivitiesTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = userActivitiesTable.Rows[i].Cells[j].Value.ToString();
                }
            }

            try
            {
                workbook.SaveAs("Активность пользователей.xls", Type.Missing, Type.Missing,
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