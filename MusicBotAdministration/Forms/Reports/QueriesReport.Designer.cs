using System.ComponentModel;

namespace MusicBotAdministration.Forms.Reports
{
    partial class QueriesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateFromInput = new System.Windows.Forms.DateTimePicker();
            this.queryTypeInput = new System.Windows.Forms.ComboBox();
            this.userInput = new MusicBotAdministration.Controls.SelectUser();
            this.queriesReportTable = new System.Windows.Forms.DataGridView();
            this.showBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateToInput = new System.Windows.Forms.DateTimePicker();
            this.isDateFilter = new System.Windows.Forms.CheckBox();
            this.isQueryTypeFilter = new System.Windows.Forms.CheckBox();
            this.isUserFilter = new System.Windows.Forms.CheckBox();
            this.queriesTableLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.queriesReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFromInput
            // 
            this.dateFromInput.Location = new System.Drawing.Point(49, 45);
            this.dateFromInput.Name = "dateFromInput";
            this.dateFromInput.Size = new System.Drawing.Size(233, 22);
            this.dateFromInput.TabIndex = 0;
            this.dateFromInput.ValueChanged += new System.EventHandler(this.dateFromInput_ValueChanged);
            // 
            // queryTypeInput
            // 
            this.queryTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryTypeInput.FormattingEnabled = true;
            this.queryTypeInput.Location = new System.Drawing.Point(315, 45);
            this.queryTypeInput.Name = "queryTypeInput";
            this.queryTypeInput.Size = new System.Drawing.Size(286, 24);
            this.queryTypeInput.TabIndex = 1;
            // 
            // userInput
            // 
            this.userInput.IsSelected = false;
            this.userInput.Location = new System.Drawing.Point(628, 43);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(384, 53);
            this.userInput.TabIndex = 2;
            this.userInput.TextBox = "";
            this.userInput.User = null;
            // 
            // queriesReportTable
            // 
            this.queriesReportTable.AllowUserToAddRows = false;
            this.queriesReportTable.AllowUserToDeleteRows = false;
            this.queriesReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.queriesReportTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.queriesReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.queriesReportTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.queriesReportTable.Location = new System.Drawing.Point(14, 179);
            this.queriesReportTable.Name = "queriesReportTable";
            this.queriesReportTable.ReadOnly = true;
            this.queriesReportTable.RowHeadersVisible = false;
            this.queriesReportTable.RowTemplate.Height = 24;
            this.queriesReportTable.Size = new System.Drawing.Size(1136, 498);
            this.queriesReportTable.TabIndex = 6;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(12, 106);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(142, 34);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "Показать";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "С";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "По";
            // 
            // dateToInput
            // 
            this.dateToInput.Location = new System.Drawing.Point(49, 69);
            this.dateToInput.Name = "dateToInput";
            this.dateToInput.Size = new System.Drawing.Size(233, 22);
            this.dateToInput.TabIndex = 8;
            this.dateToInput.ValueChanged += new System.EventHandler(this.dateToInput_ValueChanged);
            // 
            // isDateFilter
            // 
            this.isDateFilter.Location = new System.Drawing.Point(14, 13);
            this.isDateFilter.Name = "isDateFilter";
            this.isDateFilter.Size = new System.Drawing.Size(146, 24);
            this.isDateFilter.TabIndex = 11;
            this.isDateFilter.Text = "Фильтр по дате";
            this.isDateFilter.UseVisualStyleBackColor = true;
            // 
            // isQueryTypeFilter
            // 
            this.isQueryTypeFilter.Location = new System.Drawing.Point(315, 13);
            this.isQueryTypeFilter.Name = "isQueryTypeFilter";
            this.isQueryTypeFilter.Size = new System.Drawing.Size(202, 24);
            this.isQueryTypeFilter.TabIndex = 12;
            this.isQueryTypeFilter.Text = "Фильтр по типу запроса";
            this.isQueryTypeFilter.UseVisualStyleBackColor = true;
            // 
            // isUserFilter
            // 
            this.isUserFilter.Location = new System.Drawing.Point(628, 13);
            this.isUserFilter.Name = "isUserFilter";
            this.isUserFilter.Size = new System.Drawing.Size(221, 24);
            this.isUserFilter.TabIndex = 13;
            this.isUserFilter.Text = "Фильтр по пользователю";
            this.isUserFilter.UseVisualStyleBackColor = true;
            // 
            // queriesTableLabel
            // 
            this.queriesTableLabel.Location = new System.Drawing.Point(12, 157);
            this.queriesTableLabel.Name = "queriesTableLabel";
            this.queriesTableLabel.Size = new System.Drawing.Size(563, 19);
            this.queriesTableLabel.TabIndex = 14;
            this.queriesTableLabel.Text = "Запросы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 36;
            this.button1.Text = "Выгрузить в excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QueriesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queriesTableLabel);
            this.Controls.Add(this.isUserFilter);
            this.Controls.Add(this.isQueryTypeFilter);
            this.Controls.Add(this.isDateFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateToInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.queriesReportTable);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.queryTypeInput);
            this.Controls.Add(this.dateFromInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QueriesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о запросах";
            ((System.ComponentModel.ISupportInitialize) (this.queriesReportTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label queriesTableLabel;

        private System.Windows.Forms.CheckBox isUserFilter;

        private System.Windows.Forms.CheckBox isDateFilter;
        private System.Windows.Forms.CheckBox isQueryTypeFilter;

        private System.Windows.Forms.DateTimePicker dateToInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button showBtn;

        private System.Windows.Forms.ComboBox queryTypeInput;
        private System.Windows.Forms.DataGridView queriesReportTable;
        private System.Windows.Forms.DateTimePicker dateFromInput;
        private MusicBotAdministration.Controls.SelectUser userInput;

        #endregion
    }
}