using System.ComponentModel;

namespace MusicBotAdministration.Forms.EditData
{
    partial class EditUser
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
            this.addTrackBtn = new System.Windows.Forms.Button();
            this.queryTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fioInput = new System.Windows.Forms.TextBox();
            this.urlInput = new System.Windows.Forms.TextBox();
            this.queryTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTrackBtn
            // 
            this.addTrackBtn.Location = new System.Drawing.Point(12, 97);
            this.addTrackBtn.Name = "addTrackBtn";
            this.addTrackBtn.Size = new System.Drawing.Size(119, 31);
            this.addTrackBtn.TabIndex = 9;
            this.addTrackBtn.Text = "Добавить";
            this.addTrackBtn.UseVisualStyleBackColor = true;
            this.addTrackBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // queryTable
            // 
            this.queryTable.ColumnCount = 2;
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.85388F));
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.14612F));
            this.queryTable.Controls.Add(this.label1, 0, 1);
            this.queryTable.Controls.Add(this.dateLabel, 0, 0);
            this.queryTable.Controls.Add(this.fioInput, 1, 0);
            this.queryTable.Controls.Add(this.urlInput, 1, 1);
            this.queryTable.Location = new System.Drawing.Point(12, 8);
            this.queryTable.Name = "queryTable";
            this.queryTable.RowCount = 2;
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.Size = new System.Drawing.Size(438, 83);
            this.queryTable.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ссылка на VK";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.Location = new System.Drawing.Point(3, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(101, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Фамилия Имя";
            // 
            // fioInput
            // 
            this.fioInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fioInput.Location = new System.Drawing.Point(124, 3);
            this.fioInput.Multiline = true;
            this.fioInput.Name = "fioInput";
            this.fioInput.Size = new System.Drawing.Size(310, 33);
            this.fioInput.TabIndex = 0;
            // 
            // urlInput
            // 
            this.urlInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urlInput.Location = new System.Drawing.Point(124, 44);
            this.urlInput.Multiline = true;
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(310, 33);
            this.urlInput.TabIndex = 1;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 135);
            this.Controls.Add(this.addTrackBtn);
            this.Controls.Add(this.queryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление пользователя";
            this.queryTable.ResumeLayout(false);
            this.queryTable.PerformLayout();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Button addTrackBtn;
        public System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel queryTable;
        public System.Windows.Forms.TextBox fioInput;

        #endregion
    }
}