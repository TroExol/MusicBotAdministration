using System.ComponentModel;
using MusicBotAdministration.Controls;

namespace MusicBotAdministration.Forms.EditData
{
    partial class EditQueryType
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
            this.queryTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.queryTypeNameInput = new System.Windows.Forms.TextBox();
            this.addQueryTypeBtn = new System.Windows.Forms.Button();
            this.queryTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryTable
            // 
            this.queryTable.ColumnCount = 2;
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.19512F));
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.80488F));
            this.queryTable.Controls.Add(this.dateLabel, 0, 0);
            this.queryTable.Controls.Add(this.queryTypeNameInput, 1, 0);
            this.queryTable.Location = new System.Drawing.Point(12, 12);
            this.queryTable.Name = "queryTable";
            this.queryTable.RowCount = 1;
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.Size = new System.Drawing.Size(410, 65);
            this.queryTable.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.Location = new System.Drawing.Point(3, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(84, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Название";
            // 
            // queryTypeNameInput
            // 
            this.queryTypeNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.queryTypeNameInput.Location = new System.Drawing.Point(93, 7);
            this.queryTypeNameInput.Multiline = true;
            this.queryTypeNameInput.Name = "queryTypeNameInput";
            this.queryTypeNameInput.Size = new System.Drawing.Size(312, 51);
            this.queryTypeNameInput.TabIndex = 0;
            // 
            // addQueryTypeBtn
            // 
            this.addQueryTypeBtn.Location = new System.Drawing.Point(12, 83);
            this.addQueryTypeBtn.Name = "addQueryTypeBtn";
            this.addQueryTypeBtn.Size = new System.Drawing.Size(164, 31);
            this.addQueryTypeBtn.TabIndex = 1;
            this.addQueryTypeBtn.Text = "Добавить тип запроса";
            this.addQueryTypeBtn.UseVisualStyleBackColor = true;
            this.addQueryTypeBtn.Click += new System.EventHandler(this.addQueryTypeBtn_Click);
            // 
            // EditQueryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 123);
            this.Controls.Add(this.addQueryTypeBtn);
            this.Controls.Add(this.queryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditQueryType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление типа запроса";
            this.queryTable.ResumeLayout(false);
            this.queryTable.PerformLayout();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Button addQueryTypeBtn;
        public System.Windows.Forms.TextBox queryTypeNameInput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TableLayoutPanel queryTable;

        #endregion
    }
}