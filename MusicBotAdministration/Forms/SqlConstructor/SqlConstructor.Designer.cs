using System.ComponentModel;

namespace MusicBotAdministration.Forms.SqlConstructor
{
    partial class SqlConstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.availableFieldsListBox = new System.Windows.Forms.ListBox();
            this.selectedFieldsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFieldBtn = new System.Windows.Forms.Button();
            this.deselectFieldBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldFilterInput = new System.Windows.Forms.ComboBox();
            this.operatorFilterInput = new System.Windows.Forms.ComboBox();
            this.valueFilterInput = new System.Windows.Forms.TextBox();
            this.andFilterInput = new System.Windows.Forms.RadioButton();
            this.orFilterInput = new System.Windows.Forms.RadioButton();
            this.addFilterBtn = new System.Windows.Forms.Button();
            this.executeBtn = new System.Windows.Forms.Button();
            this.sqlFilterInput = new System.Windows.Forms.ListBox();
            this.removeFilterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица";
            // 
            // tableInput
            // 
            this.tableInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableInput.FormattingEnabled = true;
            this.tableInput.Location = new System.Drawing.Point(86, 7);
            this.tableInput.Name = "tableInput";
            this.tableInput.Size = new System.Drawing.Size(211, 24);
            this.tableInput.TabIndex = 1;
            this.tableInput.SelectionChangeCommitted += new System.EventHandler(this.tableInput_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Доступные поля";
            // 
            // availableFieldsListBox
            // 
            this.availableFieldsListBox.FormattingEnabled = true;
            this.availableFieldsListBox.ItemHeight = 16;
            this.availableFieldsListBox.Location = new System.Drawing.Point(14, 76);
            this.availableFieldsListBox.Name = "availableFieldsListBox";
            this.availableFieldsListBox.Size = new System.Drawing.Size(206, 196);
            this.availableFieldsListBox.TabIndex = 3;
            // 
            // selectedFieldsListBox
            // 
            this.selectedFieldsListBox.FormattingEnabled = true;
            this.selectedFieldsListBox.ItemHeight = 16;
            this.selectedFieldsListBox.Location = new System.Drawing.Point(284, 76);
            this.selectedFieldsListBox.Name = "selectedFieldsListBox";
            this.selectedFieldsListBox.Size = new System.Drawing.Size(206, 196);
            this.selectedFieldsListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(284, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отображаемые поля";
            // 
            // selectFieldBtn
            // 
            this.selectFieldBtn.Location = new System.Drawing.Point(235, 125);
            this.selectFieldBtn.Name = "selectFieldBtn";
            this.selectFieldBtn.Size = new System.Drawing.Size(32, 30);
            this.selectFieldBtn.TabIndex = 6;
            this.selectFieldBtn.Text = ">";
            this.selectFieldBtn.UseVisualStyleBackColor = true;
            this.selectFieldBtn.Click += new System.EventHandler(this.selectFieldBtn_Click);
            // 
            // deselectFieldBtn
            // 
            this.deselectFieldBtn.Location = new System.Drawing.Point(235, 176);
            this.deselectFieldBtn.Name = "deselectFieldBtn";
            this.deselectFieldBtn.Size = new System.Drawing.Size(32, 30);
            this.deselectFieldBtn.TabIndex = 7;
            this.deselectFieldBtn.Text = "<";
            this.deselectFieldBtn.UseVisualStyleBackColor = true;
            this.deselectFieldBtn.Click += new System.EventHandler(this.deselectFieldBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Условия";
            // 
            // fieldFilterInput
            // 
            this.fieldFilterInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldFilterInput.FormattingEnabled = true;
            this.fieldFilterInput.Location = new System.Drawing.Point(14, 311);
            this.fieldFilterInput.Name = "fieldFilterInput";
            this.fieldFilterInput.Size = new System.Drawing.Size(206, 24);
            this.fieldFilterInput.TabIndex = 9;
            // 
            // operatorFilterInput
            // 
            this.operatorFilterInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorFilterInput.FormattingEnabled = true;
            this.operatorFilterInput.Location = new System.Drawing.Point(235, 311);
            this.operatorFilterInput.Name = "operatorFilterInput";
            this.operatorFilterInput.Size = new System.Drawing.Size(53, 24);
            this.operatorFilterInput.TabIndex = 10;
            // 
            // valueFilterInput
            // 
            this.valueFilterInput.Location = new System.Drawing.Point(297, 313);
            this.valueFilterInput.Name = "valueFilterInput";
            this.valueFilterInput.Size = new System.Drawing.Size(193, 22);
            this.valueFilterInput.TabIndex = 11;
            // 
            // andFilterInput
            // 
            this.andFilterInput.Checked = true;
            this.andFilterInput.Location = new System.Drawing.Point(14, 341);
            this.andFilterInput.Name = "andFilterInput";
            this.andFilterInput.Size = new System.Drawing.Size(64, 24);
            this.andFilterInput.TabIndex = 13;
            this.andFilterInput.TabStop = true;
            this.andFilterInput.Text = "AND";
            this.andFilterInput.UseVisualStyleBackColor = true;
            this.andFilterInput.CheckedChanged += new System.EventHandler(this.andFilterInput_CheckedChanged);
            // 
            // orFilterInput
            // 
            this.orFilterInput.Location = new System.Drawing.Point(84, 341);
            this.orFilterInput.Name = "orFilterInput";
            this.orFilterInput.Size = new System.Drawing.Size(64, 24);
            this.orFilterInput.TabIndex = 14;
            this.orFilterInput.Text = "OR";
            this.orFilterInput.UseVisualStyleBackColor = true;
            this.orFilterInput.CheckedChanged += new System.EventHandler(this.orFilterInput_CheckedChanged);
            // 
            // addFilterBtn
            // 
            this.addFilterBtn.Location = new System.Drawing.Point(338, 346);
            this.addFilterBtn.Name = "addFilterBtn";
            this.addFilterBtn.Size = new System.Drawing.Size(152, 27);
            this.addFilterBtn.TabIndex = 15;
            this.addFilterBtn.Text = "Добавить условие";
            this.addFilterBtn.UseVisualStyleBackColor = true;
            this.addFilterBtn.Click += new System.EventHandler(this.addFilterBtn_Click);
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(14, 520);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(167, 28);
            this.executeBtn.TabIndex = 16;
            this.executeBtn.Text = "Выполнить запрос";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // sqlFilterInput
            // 
            this.sqlFilterInput.FormattingEnabled = true;
            this.sqlFilterInput.ItemHeight = 16;
            this.sqlFilterInput.Location = new System.Drawing.Point(14, 379);
            this.sqlFilterInput.Name = "sqlFilterInput";
            this.sqlFilterInput.Size = new System.Drawing.Size(475, 132);
            this.sqlFilterInput.TabIndex = 17;
            // 
            // removeFilterBtn
            // 
            this.removeFilterBtn.Location = new System.Drawing.Point(337, 521);
            this.removeFilterBtn.Name = "removeFilterBtn";
            this.removeFilterBtn.Size = new System.Drawing.Size(152, 27);
            this.removeFilterBtn.TabIndex = 18;
            this.removeFilterBtn.Text = "Удалить условие";
            this.removeFilterBtn.UseVisualStyleBackColor = true;
            this.removeFilterBtn.Click += new System.EventHandler(this.removeFilterBtn_Click);
            // 
            // SqlConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 556);
            this.Controls.Add(this.removeFilterBtn);
            this.Controls.Add(this.sqlFilterInput);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.addFilterBtn);
            this.Controls.Add(this.orFilterInput);
            this.Controls.Add(this.andFilterInput);
            this.Controls.Add(this.valueFilterInput);
            this.Controls.Add(this.operatorFilterInput);
            this.Controls.Add(this.fieldFilterInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deselectFieldBtn);
            this.Controls.Add(this.selectFieldBtn);
            this.Controls.Add(this.selectedFieldsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availableFieldsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SqlConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конструктор запросов";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button removeFilterBtn;

        private System.Windows.Forms.ListBox sqlFilterInput;

        private System.Windows.Forms.Button executeBtn;

        private System.Windows.Forms.Button addFilterBtn;

        private System.Windows.Forms.RadioButton andFilterInput;
        private System.Windows.Forms.RadioButton orFilterInput;

        private System.Windows.Forms.TextBox valueFilterInput;

        private System.Windows.Forms.ComboBox operatorFilterInput;

        private System.Windows.Forms.ComboBox fieldFilterInput;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button deselectFieldBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox selectedFieldsListBox;
        private System.Windows.Forms.Button selectFieldBtn;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox availableFieldsListBox;
        private System.Windows.Forms.ComboBox tableInput;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}