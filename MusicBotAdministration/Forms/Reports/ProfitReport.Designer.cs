using System.ComponentModel;

namespace MusicBotAdministration.Forms.Reports
{
    partial class ProfitReport
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
            this.isUserFilter = new System.Windows.Forms.CheckBox();
            this.isSubscriptionFilter = new System.Windows.Forms.CheckBox();
            this.isDateFilter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateToInput = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.userInput = new MusicBotAdministration.Controls.SelectUser();
            this.subscriptionInput = new System.Windows.Forms.ComboBox();
            this.dateFromInput = new System.Windows.Forms.DateTimePicker();
            this.queriesTableLabel = new System.Windows.Forms.Label();
            this.profitReportTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.profitReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // isUserFilter
            // 
            this.isUserFilter.Location = new System.Drawing.Point(624, 12);
            this.isUserFilter.Name = "isUserFilter";
            this.isUserFilter.Size = new System.Drawing.Size(221, 24);
            this.isUserFilter.TabIndex = 23;
            this.isUserFilter.Text = "Фильтр по пользователю";
            this.isUserFilter.UseVisualStyleBackColor = true;
            // 
            // isSubscriptionFilter
            // 
            this.isSubscriptionFilter.Location = new System.Drawing.Point(311, 12);
            this.isSubscriptionFilter.Name = "isSubscriptionFilter";
            this.isSubscriptionFilter.Size = new System.Drawing.Size(202, 24);
            this.isSubscriptionFilter.TabIndex = 22;
            this.isSubscriptionFilter.Text = "Фильтр по подписке";
            this.isSubscriptionFilter.UseVisualStyleBackColor = true;
            // 
            // isDateFilter
            // 
            this.isDateFilter.Location = new System.Drawing.Point(10, 12);
            this.isDateFilter.Name = "isDateFilter";
            this.isDateFilter.Size = new System.Drawing.Size(146, 24);
            this.isDateFilter.TabIndex = 21;
            this.isDateFilter.Text = "Фильтр по дате";
            this.isDateFilter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "По";
            // 
            // dateToInput
            // 
            this.dateToInput.Location = new System.Drawing.Point(45, 68);
            this.dateToInput.Name = "dateToInput";
            this.dateToInput.Size = new System.Drawing.Size(233, 22);
            this.dateToInput.TabIndex = 19;
            this.dateToInput.ValueChanged += new System.EventHandler(this.dateToInput_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "С";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(8, 105);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(142, 34);
            this.showBtn.TabIndex = 17;
            this.showBtn.Text = "Показать";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // userInput
            // 
            this.userInput.IsSelected = false;
            this.userInput.Location = new System.Drawing.Point(624, 42);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(384, 53);
            this.userInput.TabIndex = 16;
            this.userInput.TextBox = "";
            this.userInput.User = null;
            // 
            // subscriptionInput
            // 
            this.subscriptionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionInput.FormattingEnabled = true;
            this.subscriptionInput.Location = new System.Drawing.Point(311, 44);
            this.subscriptionInput.Name = "subscriptionInput";
            this.subscriptionInput.Size = new System.Drawing.Size(286, 24);
            this.subscriptionInput.TabIndex = 15;
            // 
            // dateFromInput
            // 
            this.dateFromInput.Location = new System.Drawing.Point(45, 44);
            this.dateFromInput.Name = "dateFromInput";
            this.dateFromInput.Size = new System.Drawing.Size(233, 22);
            this.dateFromInput.TabIndex = 14;
            this.dateFromInput.ValueChanged += new System.EventHandler(this.dateFromInput_ValueChanged);
            // 
            // queriesTableLabel
            // 
            this.queriesTableLabel.Location = new System.Drawing.Point(8, 153);
            this.queriesTableLabel.Name = "queriesTableLabel";
            this.queriesTableLabel.Size = new System.Drawing.Size(533, 19);
            this.queriesTableLabel.TabIndex = 25;
            this.queriesTableLabel.Text = "Прибыль";
            // 
            // profitReportTable
            // 
            this.profitReportTable.AllowUserToAddRows = false;
            this.profitReportTable.AllowUserToDeleteRows = false;
            this.profitReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profitReportTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.profitReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profitReportTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.profitReportTable.Location = new System.Drawing.Point(10, 175);
            this.profitReportTable.Name = "profitReportTable";
            this.profitReportTable.ReadOnly = true;
            this.profitReportTable.RowHeadersVisible = false;
            this.profitReportTable.RowTemplate.Height = 24;
            this.profitReportTable.Size = new System.Drawing.Size(998, 498);
            this.profitReportTable.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Выгрузить в excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queriesTableLabel);
            this.Controls.Add(this.profitReportTable);
            this.Controls.Add(this.isUserFilter);
            this.Controls.Add(this.isSubscriptionFilter);
            this.Controls.Add(this.isDateFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateToInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.subscriptionInput);
            this.Controls.Add(this.dateFromInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfitReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доходы с продаж подписок";
            ((System.ComponentModel.ISupportInitialize) (this.profitReportTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridView profitReportTable;
        private System.Windows.Forms.Label queriesTableLabel;

        private System.Windows.Forms.DateTimePicker dateFromInput;
        private System.Windows.Forms.DateTimePicker dateToInput;
        private System.Windows.Forms.CheckBox isDateFilter;
        private System.Windows.Forms.CheckBox isSubscriptionFilter;
        private System.Windows.Forms.CheckBox isUserFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox subscriptionInput;
        private System.Windows.Forms.Button showBtn;
        private MusicBotAdministration.Controls.SelectUser userInput;

        #endregion
    }
}