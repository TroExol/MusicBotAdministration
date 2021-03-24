using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MusicBotAdministration.Classes;
using Author = MusicBotAdministration.Classes.Author;
using DataTable = System.Data.DataTable;

namespace MusicBotAdministration.Forms.Reports
{
    public partial class QueriesReport : Form
    {
        public QueriesReport()
        {
            InitializeComponent();

            // Указание формата для даты запроса
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

            var queryTypes = QueryTypes.GetData();
            // Добавление типов запросов в выпадающий список
            var queryTypesKeyValuePair = queryTypes
                .Select(type => new KeyValuePair<int, string>(type.Id, type.Name))
                .ToList();

            queryTypeInput.DataSource = queryTypesKeyValuePair;
            queryTypeInput.DisplayMember = "Value";
            queryTypeInput.ValueMember = "Key";
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
            var isQueryType = isQueryTypeFilter.Checked;
            var isUser = isUserFilter.Checked;
            var dateFromFilter = dateFromInput.Value;
            var dateToFilter = dateToInput.Value;
            var queryTypeFilter = Convert.ToInt32(queryTypeInput.SelectedValue);
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
                whereStr += $" AND ДатаЗапроса >= '{dateFromFilter.ToString(CultureInfo.CurrentCulture)}' AND" +
                            $" ДатаЗапроса <= '{dateToFilter.ToString(CultureInfo.CurrentCulture)}' ";
            }

            if (isQueryType)
            {
                whereStr += $" AND ID_ТипЗапроса = {queryTypeFilter} ";
            }

            if (isUser)
            {
                whereStr += $" AND ID_Пользователь = {userFilter.Id} ";
            }
            
            var queriesFromDb = DbConnector.Read("Запрос",
                    "Не удалось получить данные о запросах",
                    "Запрос.ID, ДатаЗапроса, КоличествоТреков, ЗапрашиваемыйАвтор, ID_Пользователь," +
                    " Пользователь.ФамилияИмя, Пользователь.СсылкаНаVK, ID_ТипЗапроса, ТипЗапроса.Название",
                    " INNER JOIN Пользователь ON Запрос.ID_Пользователь = Пользователь.ID" + whereStr +
                    " LEFT JOIN ТипЗапроса ON Запрос.ID_ТипЗапроса = ТипЗапроса.ID")
                .Select(query =>
                {
                    var id = Convert.ToInt32(query["ID"]);
                    var date = Convert.ToDateTime(query["ДатаЗапроса"]);
                    var countTracks = Convert.ToInt32(query["КоличествоТреков"]);
                    var requiredAuthor = query["ЗапрашиваемыйАвтор"].ToString();
                    var idUser = Convert.ToInt32(query["ID_Пользователь"]);
                    var fio = query["ФамилияИмя"].ToString();
                    var url = query["СсылкаНаVK"].ToString();
                    var idQueryType = Convert.ToInt32(query["ID_ТипЗапроса"]);
                    var queryTypeName = query["Название"].ToString();

                    var tracksFromDb = DbConnector.Read("ПолученныйТрек",
                        "Не удалось получить данные о полученных треках для запроса",
                        "Трек.ID, Трек.Название, ID_Автор, Автор.ИмяАвтора",
                        $"INNER JOIN Трек ON ПолученныйТрек.ID_Трек = Трек.ID AND ПолученныйТрек.ID_Запрос = {id}" +
                        " LEFT JOIN Автор ON Трек.ID_Автор = Автор.ID");
                    var tracks = tracksFromDb
                        .Select(track =>
                            new Track(Convert.ToInt32(track["ID"]), track["Название"].ToString(),
                                new Author(Convert.ToInt32(track["ID_Автор"]), track["ИмяАвтора"].ToString())))
                        .ToList();

                    return new Query(id, date, countTracks, requiredAuthor,
                        new User(idUser, fio, url), new QueryType(idQueryType, queryTypeName), tracks);
                }).ToList();
            
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Дата запроса", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Количество треков", typeof(int)));
            table.Columns.Add(new DataColumn("Запрашиваемый автор", typeof(string)));
            table.Columns.Add(new DataColumn("Пользователь", typeof(string)));
            table.Columns.Add(new DataColumn("Ссылка на пользователя", typeof(string)));
            table.Columns.Add(new DataColumn("Тип запроса", typeof(string)));
            table.Columns.Add(new DataColumn("Полученные треки", typeof(string)));
            
            try
            {
                // Добавление запросов в таблицу
                queriesFromDb.ForEach((query) =>
                {
                    var receivedTracks =
                        String.Join("," + Environment.NewLine,
                            query.ReceivedTracks.Select(track => $"{track.Author.Name} - {track.Name}").ToArray());
                    table.Rows.Add(query.Id, query.Date, query.CountMusic, query.Author,
                        query.User.FIO, query.User.Url, query.QueryType.Name, receivedTracks);
                });
                // Добавленеи источника данных в DataGridView
                queriesReportTable.DataSource = table;

                // Изменение заголовка DataGridView
                queriesTableLabel.Text = $@"Запросы ({queriesReportTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить запросы", @"Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            _Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Запросы";
            for (var i = 1; i < queriesReportTable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = queriesReportTable.Columns[i - 1].HeaderText;
            }

            for (var i = 0; i < queriesReportTable.Rows.Count; i++)
            {
                for (var j = 0; j < queriesReportTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = queriesReportTable.Rows[i].Cells[j].Value.ToString();
                }
            }

            try
            {
                workbook.SaveAs("Запросы.xls", Type.Missing, Type.Missing,
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