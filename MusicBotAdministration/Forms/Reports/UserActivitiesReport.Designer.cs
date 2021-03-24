using System.ComponentModel;

namespace MusicBotAdministration.Forms.Reports
{
    partial class UserActivitiesReport
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersTableLabel = new System.Windows.Forms.Label();
            this.userActivitiesTable = new System.Windows.Forms.DataGridView();
            this.isDateFilter = new System.Windows.Forms.CheckBox();
            this.dateToInput = new System.Windows.Forms.DateTimePicker();
            this.showBtn = new System.Windows.Forms.Button();
            this.dateFromInput = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.userActivitiesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "По";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "С";
            // 
            // usersTableLabel
            // 
            this.usersTableLabel.Location = new System.Drawing.Point(10, 154);
            this.usersTableLabel.Name = "usersTableLabel";
            this.usersTableLabel.Size = new System.Drawing.Size(417, 19);
            this.usersTableLabel.TabIndex = 39;
            this.usersTableLabel.Text = "Пользователи";
            // 
            // userActivitiesTable
            // 
            this.userActivitiesTable.AllowUserToAddRows = false;
            this.userActivitiesTable.AllowUserToDeleteRows = false;
            this.userActivitiesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.userActivitiesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userActivitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userActivitiesTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.userActivitiesTable.Location = new System.Drawing.Point(12, 176);
            this.userActivitiesTable.Name = "userActivitiesTable";
            this.userActivitiesTable.ReadOnly = true;
            this.userActivitiesTable.RowHeadersVisible = false;
            this.userActivitiesTable.RowTemplate.Height = 24;
            this.userActivitiesTable.Size = new System.Drawing.Size(564, 271);
            this.userActivitiesTable.TabIndex = 38;
            // 
            // isDateFilter
            // 
            this.isDateFilter.Location = new System.Drawing.Point(12, 13);
            this.isDateFilter.Name = "isDateFilter";
            this.isDateFilter.Size = new System.Drawing.Size(146, 24);
            this.isDateFilter.TabIndex = 37;
            this.isDateFilter.Text = "Фильтр по дате";
            this.isDateFilter.UseVisualStyleBackColor = true;
            // 
            // dateToInput
            // 
            this.dateToInput.Location = new System.Drawing.Point(47, 69);
            this.dateToInput.Name = "dateToInput";
            this.dateToInput.Size = new System.Drawing.Size(233, 22);
            this.dateToInput.TabIndex = 36;
            this.dateToInput.ValueChanged += new System.EventHandler(this.dateToInput_ValueChanged);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(10, 106);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(142, 34);
            this.showBtn.TabIndex = 35;
            this.showBtn.Text = "Показать";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // dateFromInput
            // 
            this.dateFromInput.Location = new System.Drawing.Point(47, 45);
            this.dateFromInput.Name = "dateFromInput";
            this.dateFromInput.Size = new System.Drawing.Size(233, 22);
            this.dateFromInput.TabIndex = 34;
            this.dateFromInput.ValueChanged += new System.EventHandler(this.dateFromInput_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "Выгрузить в excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserActivitiesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usersTableLabel);
            this.Controls.Add(this.userActivitiesTable);
            this.Controls.Add(this.isDateFilter);
            this.Controls.Add(this.dateToInput);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.dateFromInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserActivitiesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Активность пользователей";
            ((System.ComponentModel.ISupportInitialize) (this.userActivitiesTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DateTimePicker dateFromInput;
        private System.Windows.Forms.DateTimePicker dateToInput;
        private System.Windows.Forms.CheckBox isDateFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView userActivitiesTable;
        private System.Windows.Forms.Label usersTableLabel;
        private System.Windows.Forms.Button showBtn;

        #endregion
    }
}