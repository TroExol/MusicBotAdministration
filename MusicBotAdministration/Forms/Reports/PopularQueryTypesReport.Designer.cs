using System.ComponentModel;

namespace MusicBotAdministration.Forms.Reports
{
    partial class PopularQueryTypesReport
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
            this.queryTypesTableLabel = new System.Windows.Forms.Label();
            this.popularReportTable = new System.Windows.Forms.DataGridView();
            this.isDateFilter = new System.Windows.Forms.CheckBox();
            this.dateToInput = new System.Windows.Forms.DateTimePicker();
            this.showBtn = new System.Windows.Forms.Button();
            this.dateFromInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.popularReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // queryTypesTableLabel
            // 
            this.queryTypesTableLabel.Location = new System.Drawing.Point(10, 153);
            this.queryTypesTableLabel.Name = "queryTypesTableLabel";
            this.queryTypesTableLabel.Size = new System.Drawing.Size(417, 19);
            this.queryTypesTableLabel.TabIndex = 31;
            this.queryTypesTableLabel.Text = "Типы запросов";
            // 
            // popularReportTable
            // 
            this.popularReportTable.AllowUserToAddRows = false;
            this.popularReportTable.AllowUserToDeleteRows = false;
            this.popularReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.popularReportTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.popularReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.popularReportTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.popularReportTable.Location = new System.Drawing.Point(12, 175);
            this.popularReportTable.Name = "popularReportTable";
            this.popularReportTable.ReadOnly = true;
            this.popularReportTable.RowHeadersVisible = false;
            this.popularReportTable.RowTemplate.Height = 24;
            this.popularReportTable.Size = new System.Drawing.Size(415, 271);
            this.popularReportTable.TabIndex = 30;
            // 
            // isDateFilter
            // 
            this.isDateFilter.Location = new System.Drawing.Point(12, 12);
            this.isDateFilter.Name = "isDateFilter";
            this.isDateFilter.Size = new System.Drawing.Size(146, 24);
            this.isDateFilter.TabIndex = 29;
            this.isDateFilter.Text = "Фильтр по дате";
            this.isDateFilter.UseVisualStyleBackColor = true;
            // 
            // dateToInput
            // 
            this.dateToInput.Location = new System.Drawing.Point(47, 68);
            this.dateToInput.Name = "dateToInput";
            this.dateToInput.Size = new System.Drawing.Size(233, 22);
            this.dateToInput.TabIndex = 28;
            this.dateToInput.ValueChanged += new System.EventHandler(this.dateToInput_ValueChanged);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(10, 105);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(142, 34);
            this.showBtn.TabIndex = 27;
            this.showBtn.Text = "Показать";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // dateFromInput
            // 
            this.dateFromInput.Location = new System.Drawing.Point(47, 44);
            this.dateFromInput.Name = "dateFromInput";
            this.dateFromInput.Size = new System.Drawing.Size(233, 22);
            this.dateFromInput.TabIndex = 26;
            this.dateFromInput.ValueChanged += new System.EventHandler(this.dateFromInput_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "По";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "С";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 34;
            this.button1.Text = "Выгрузить в excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PopularQueryTypesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.queryTypesTableLabel);
            this.Controls.Add(this.popularReportTable);
            this.Controls.Add(this.isDateFilter);
            this.Controls.Add(this.dateToInput);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.dateFromInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PopularQueryTypesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Популярность типов запросов";
            ((System.ComponentModel.ISupportInitialize) (this.popularReportTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.DateTimePicker dateFromInput;
        private System.Windows.Forms.DateTimePicker dateToInput;
        private System.Windows.Forms.CheckBox isDateFilter;
        private System.Windows.Forms.DataGridView popularReportTable;
        private System.Windows.Forms.Label queryTypesTableLabel;
        private System.Windows.Forms.Button showBtn;

        #endregion
    }
}