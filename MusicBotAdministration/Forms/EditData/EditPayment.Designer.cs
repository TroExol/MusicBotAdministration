using System.ComponentModel;

namespace MusicBotAdministration.Forms.EditData
{
    partial class EditPayment
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
            this.addPaymentBtn = new System.Windows.Forms.Button();
            this.queryTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.userInput = new MusicBotAdministration.Controls.SelectUser();
            this.subscriptionInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.queryTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPaymentBtn
            // 
            this.addPaymentBtn.Location = new System.Drawing.Point(12, 138);
            this.addPaymentBtn.Name = "addPaymentBtn";
            this.addPaymentBtn.Size = new System.Drawing.Size(164, 31);
            this.addPaymentBtn.TabIndex = 3;
            this.addPaymentBtn.Text = "Добавить оплату";
            this.addPaymentBtn.UseVisualStyleBackColor = true;
            this.addPaymentBtn.Click += new System.EventHandler(this.addQueryBtn_Click);
            // 
            // queryTable
            // 
            this.queryTable.ColumnCount = 2;
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80038F));
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.19962F));
            this.queryTable.Controls.Add(this.dateLabel, 0, 0);
            this.queryTable.Controls.Add(this.dateInput, 1, 0);
            this.queryTable.Controls.Add(this.label3, 0, 1);
            this.queryTable.Controls.Add(this.userInput, 1, 1);
            this.queryTable.Controls.Add(this.subscriptionInput, 1, 2);
            this.queryTable.Controls.Add(this.label4, 0, 2);
            this.queryTable.Location = new System.Drawing.Point(12, 12);
            this.queryTable.Name = "queryTable";
            this.queryTable.RowCount = 3;
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.72093F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.27907F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.queryTable.Size = new System.Drawing.Size(506, 120);
            this.queryTable.TabIndex = 6;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.Location = new System.Drawing.Point(3, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(114, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата оплаты";
            // 
            // dateInput
            // 
            this.dateInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateInput.Location = new System.Drawing.Point(123, 3);
            this.dateInput.MaxDate = new System.DateTime(2021, 12, 16, 0, 0, 0, 0);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(379, 22);
            this.dateInput.TabIndex = 0;
            this.dateInput.Value = new System.DateTime(2021, 3, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пользователь";
            // 
            // userInput
            // 
            this.userInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userInput.IsSelected = false;
            this.userInput.Location = new System.Drawing.Point(123, 32);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(379, 51);
            this.userInput.TabIndex = 1;
            this.userInput.TextBox = "";
            this.userInput.User = null;
            // 
            // subscriptionInput
            // 
            this.subscriptionInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subscriptionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionInput.FormattingEnabled = true;
            this.subscriptionInput.Location = new System.Drawing.Point(123, 91);
            this.subscriptionInput.Name = "subscriptionInput";
            this.subscriptionInput.Size = new System.Drawing.Size(379, 24);
            this.subscriptionInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Подписка";
            // 
            // EditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 176);
            this.Controls.Add(this.addPaymentBtn);
            this.Controls.Add(this.queryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление оплаты";
            this.queryTable.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Button addPaymentBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.TableLayoutPanel queryTable;
        public System.Windows.Forms.ComboBox subscriptionInput;
        public MusicBotAdministration.Controls.SelectUser userInput;

        #endregion
    }
}