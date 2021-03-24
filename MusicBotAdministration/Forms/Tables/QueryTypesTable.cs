using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.EditData;

namespace MusicBotAdministration.Forms.Tables
{
    public partial class QueryTypesTable : Form
    {
        // Типы запросов
        private QueryTypes QueryTypes { get; set; }

        public bool IsChanged { get; set; }

        // Получение списка запросов
        private List<QueryType> QueryTypesList
        {
            get => QueryTypes.QueryTypesList;
            set => QueryTypes.QueryTypesList = value;
        }

        // Создание таблицы и заголовков
        private static DataTable CreateQueryTypesTable()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Название", typeof(string)));

            return table;
        }

        // Добавление типов запросов в таблицу и в DataGridView
        private void LoadQueryTypesTable(object sender, EventArgs e)
        {
            try
            {
                // Создание таблицы
                var table = CreateQueryTypesTable();

                // Добавление типов запросов в таблицу
                QueryTypesList.ForEach((query) => { table.Rows.Add(query.Id, query.Name); });
                // Добавленеи источника данных в DataGridView
                typesTable.DataSource = table;

                // Изменение заголовка DataGridView
                queryTypesTableLabel.Text = $@"Типы запросов ({typesTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить типы запросов", @"Ошибка");
            }
        }

        public QueryTypesTable()
        {
            InitializeComponent();

            QueryTypes = new QueryTypes(LoadQueryTypesTable, LoadQueryTypesTable);
            QueryTypesList = QueryTypes.GetData();
        }

        // Добавление типа запроса
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления типа запроса
            using (var addQueryTypeForm = new EditQueryType())
            {
                addQueryTypeForm.Text = @"Добавление типа запроса";
                addQueryTypeForm.addQueryTypeBtn.Text = @"Добавить";

                // Если данные не получены из формы
                if (addQueryTypeForm.ShowDialog() != DialogResult.OK)
                    return;

                var id = DbConnector.Create("ТипЗапроса", "Название",
                    $"'{addQueryTypeForm.QueryTypeName}'",
                    "Не удалось добавить данные о типе запроса");

                if (id != -1)
                {
                    // Добавление типа запроса в список типов запросов
                    QueryTypes.Add(new QueryType(id, addQueryTypeForm.QueryTypeName));
                }

                IsChanged = true;
            }
        }

        // Изменение типа запроса
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных типов запросов
            var selectedQueryTypes = typesTable.SelectedRows;

            if (selectedQueryTypes.Count != 1)
            {
                MessageBox.Show(@"Выберите 1 тип запроса", @"Ошибка");
                return;
            }

            // Открытие формы для изменения типа запроса
            using (var editQueryTypeForm = new EditQueryType())
            {
                editQueryTypeForm.Text = @"Изменение типа запроса";
                editQueryTypeForm.addQueryTypeBtn.Text = @"Изменить";

                // Получение id выбранного типа запроса
                var id = Convert.ToInt32(selectedQueryTypes[0].Cells[0].Value);
                // Получение выбранного типа запроса
                var selectedQueryType = QueryTypesList.Find((queryType) => queryType.Id == id);

                // Заполнение названия
                editQueryTypeForm.queryTypeNameInput.Text = selectedQueryType.Name;

                // Если данные не получены из формы
                if (editQueryTypeForm.ShowDialog() != DialogResult.OK)
                    return;

                var isNameChanged = false;
                if (editQueryTypeForm.QueryTypeName != selectedQueryType.Name)
                {
                    isNameChanged = DbConnector.Update("ТипЗапроса",
                        $"Название = '{editQueryTypeForm.QueryTypeName}'",
                        "Не удалось изменить данные о типе запроса",
                        $"ID = {selectedQueryType.Id}");
                }

                if (isNameChanged)
                {
                    // Изменение типа запроса
                    QueryTypesList = QueryTypesList.Select((queryType) =>
                    {
                        if (queryType.Id == id)
                        {
                            queryType.Name = editQueryTypeForm.QueryTypeName;
                        }

                        return queryType;
                    }).ToList();
                }

                IsChanged = true;
            }
        }

        private void QueryTypesTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}