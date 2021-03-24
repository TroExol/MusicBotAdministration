using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MusicBotAdministration.Classes;

namespace MusicBotAdministration.Forms.SqlConstructor
{
    public partial class SqlConstructor : Form
    {
        public SqlConstructor()
        {
            InitializeComponent();

            var tables = DbConnector.Read("INFORMATION_SCHEMA.TABLES",
                "Не удалось получить список таблиц",
                "TABLE_NAME",
                "WHERE TABLE_NAME != 'sysdiagrams'").ToList();

            tables.ForEach(table => tableInput.Items.Add(table["TABLE_NAME"]));

            object[] boolOperators = {"=", "!=", "<", ">", "<=", ">="};
            operatorFilterInput.Items.AddRange(boolOperators);
            operatorFilterInput.SelectedIndex = 0;
        }

        private void tableInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var table = tableInput.SelectedItem;

            var columns = DbConnector.Read("INFORMATION_SCHEMA.COLUMNS",
                "Не удалось получить список полей",
                "COLUMN_NAME",
                $"WHERE TABLE_NAME = '{table}'").ToList();

            availableFieldsListBox.Items.Clear();
            selectedFieldsListBox.Items.Clear();
            fieldFilterInput.Items.Clear();
            sqlFilterInput.Items.Clear();
            valueFilterInput.Text = "";
            operatorFilterInput.SelectedIndex = 0;

            columns.ForEach(column =>
            {
                availableFieldsListBox.Items.Add(column["COLUMN_NAME"].ToString());
                fieldFilterInput.Items.Add(column["COLUMN_NAME"].ToString());
            });

            fieldFilterInput.SelectedItem = columns.First()["COLUMN_NAME"].ToString();
        }

        private void selectFieldBtn_Click(object sender, EventArgs e)
        {
            var selectedField = availableFieldsListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedField))
            {
                return;
            }

            selectedFieldsListBox.Items.Add(selectedField);
            availableFieldsListBox.Items.Remove(selectedField);
            if (availableFieldsListBox.Items.Count > 0)
            {
                availableFieldsListBox.SelectedIndex = 0;
            }
        }

        private void deselectFieldBtn_Click(object sender, EventArgs e)
        {
            var deselectedField = selectedFieldsListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(deselectedField))
            {
                return;
            }

            availableFieldsListBox.Items.Add(deselectedField);
            selectedFieldsListBox.Items.Remove(deselectedField);
            if (selectedFieldsListBox.Items.Count > 0)
            {
                selectedFieldsListBox.SelectedIndex = 0;
            }
        }

        private void addFilterBtn_Click(object sender, EventArgs e)
        {
            var field = fieldFilterInput.SelectedItem?.ToString();
            var operatorFilter = operatorFilterInput.SelectedItem?.ToString();
            var value = valueFilterInput.Text;
            var isAnd = andFilterInput.Checked;

            if (string.IsNullOrEmpty(field))
            {
                MessageBox.Show(@"Укажите поле для фильтрации", @"Ошибка");
                return;
            }

            if (string.IsNullOrEmpty(operatorFilter))
            {
                MessageBox.Show(@"Укажите оператор для фильтрации", @"Ошибка");
                return;
            }

            if (value == "")
            {
                MessageBox.Show(@"Укажите значение для фильтрации", @"Ошибка");
                return;
            }

            var sqlString = "";

            if (sqlFilterInput.Items.Count > 0)
            {
                sqlString += isAnd ? " AND" : " OR";
            }

            sqlString += $" {field} {operatorFilter} '{value}'";


            sqlFilterInput.Items.Add(sqlString);
        }

        private void removeFilterBtn_Click(object sender, EventArgs e)
        {
            if (sqlFilterInput.Items.Count < 1)
            {
                MessageBox.Show(@"Нечего удалять", @"Ошибка");
                return;
            }

            if (sqlFilterInput.SelectedIndex == -1)
            {
                MessageBox.Show(@"Выберите условие для удаления", @"Ошибка");
                return;
            }

            var selectedIndex = sqlFilterInput.SelectedIndex;
            sqlFilterInput.Items.RemoveAt(selectedIndex);

            if (selectedIndex == 0 && sqlFilterInput.Items.Count > 0)
            {
                sqlFilterInput.Items[0] =
                    Regex.Replace(sqlFilterInput.Items[0].ToString(), @"^ (AND|OR)", "");
            }
        }

        private void andFilterInput_CheckedChanged(object sender, EventArgs e)
        {
            orFilterInput.Checked = !andFilterInput.Checked;
        }

        private void orFilterInput_CheckedChanged(object sender, EventArgs e)
        {
            andFilterInput.Checked = !orFilterInput.Checked;
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            var table = tableInput.SelectedItem?.ToString();
            var select = string.Join(",", selectedFieldsListBox.Items.Cast<string>());
            var where = sqlFilterInput.Items.Count > 0
                ? $"WHERE {string.Join("", sqlFilterInput.Items.Cast<string>())}"
                : "";

            if (table == null)
            {
                MessageBox.Show(@"Выберите таблицу", @"Ошибка");
                return;
            }

            if (selectedFieldsListBox.Items.Count < 1)
            {
                MessageBox.Show(@"Выберите поля для отображения", @"Ошибка");
                return;
            }

            var data = DbConnector.Read(table, "DEBUG", select, where).ToList();

            new DataView {Data = data}.ShowDialog();
        }
    }
}