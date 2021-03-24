using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace MusicBotAdministration.Forms.SqlConstructor
{
    public partial class DataView : Form
    {
        private List<Dictionary<string, object>> _data;

        public List<Dictionary<string, object>> Data
        {
            get => _data;
            set
            {
                _data = value;
                var table = new DataTable();

                _data.ForEach(dictionary =>
                {
                    if (table.Columns.Count == 0)
                    {
                        var columns = dictionary.Keys.ToList();
                        columns.ForEach(column => table.Columns.Add(new DataColumn(column, typeof(string))));
                    }

                    var values = dictionary.Values.ToArray();
                    table.Rows.Add(values);
                });

                dataTable.DataSource = table;
            }
        }

        public DataView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            _Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Просмотр результатов";
            for (var i = 1; i < dataTable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataTable.Columns[i - 1].HeaderText;
            }

            for (var i = 0; i < dataTable.Rows.Count; i++)
            {
                for (var j = 0; j < dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i].Cells[j].Value.ToString();
                }
            }

            try
            {
                workbook.SaveAs("Результаты.xls", Type.Missing, Type.Missing,
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