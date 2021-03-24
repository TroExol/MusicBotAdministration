using System.ComponentModel;

namespace MusicBotAdministration.Forms.Tables
{
    partial class QueryTypesTable
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
            this.queryTypesTableLabel = new System.Windows.Forms.Label();
            this.typesTable = new System.Windows.Forms.DataGridView();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.changeRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.typesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // queryTypesTableLabel
            // 
            this.queryTypesTableLabel.Location = new System.Drawing.Point(12, 13);
            this.queryTypesTableLabel.Name = "queryTypesTableLabel";
            this.queryTypesTableLabel.Size = new System.Drawing.Size(169, 19);
            this.queryTypesTableLabel.TabIndex = 14;
            this.queryTypesTableLabel.Text = "Типы запросов";
            // 
            // typesTable
            // 
            this.typesTable.AllowUserToAddRows = false;
            this.typesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesTable.Location = new System.Drawing.Point(12, 32);
            this.typesTable.Name = "typesTable";
            this.typesTable.ReadOnly = true;
            this.typesTable.RowTemplate.Height = 24;
            this.typesTable.Size = new System.Drawing.Size(474, 426);
            this.typesTable.TabIndex = 13;
            // 
            // addRowBtn
            // 
            this.addRowBtn.Location = new System.Drawing.Point(12, 464);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(154, 24);
            this.addRowBtn.TabIndex = 0;
            this.addRowBtn.Text = "Добавить запись";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // changeRowBtn
            // 
            this.changeRowBtn.Location = new System.Drawing.Point(172, 464);
            this.changeRowBtn.Name = "changeRowBtn";
            this.changeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.changeRowBtn.TabIndex = 1;
            this.changeRowBtn.Text = "Изменить запись";
            this.changeRowBtn.UseVisualStyleBackColor = true;
            this.changeRowBtn.Click += new System.EventHandler(this.changeRowBtn_Click);
            // 
            // QueryTypesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 496);
            this.Controls.Add(this.queryTypesTableLabel);
            this.Controls.Add(this.typesTable);
            this.Controls.Add(this.addRowBtn);
            this.Controls.Add(this.changeRowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QueryTypesTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы запросов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryTypesTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.typesTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.Button changeRowBtn;
        private System.Windows.Forms.DataGridView typesTable;
        private System.Windows.Forms.Label queryTypesTableLabel;

        #endregion
    }
}