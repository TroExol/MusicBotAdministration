using System.ComponentModel;

namespace MusicBotAdministration.Forms.EditData
{
    partial class EditSubscription
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
            this.components = new System.ComponentModel.Container();
            this.dateLabel = new System.Windows.Forms.Label();
            this.subscriptionNameInput = new System.Windows.Forms.TextBox();
            this.addSubscriptionBtn = new System.Windows.Forms.Button();
            this.queryTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.availableQueryTypesInput = new System.Windows.Forms.ListBox();
            this.sumInput = new MusicBotAdministration.Controls.DecimalBox(this.components);
            this.queryTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.Location = new System.Drawing.Point(3, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(84, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Название";
            // 
            // subscriptionNameInput
            // 
            this.subscriptionNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subscriptionNameInput.Location = new System.Drawing.Point(130, 3);
            this.subscriptionNameInput.Multiline = true;
            this.subscriptionNameInput.Name = "subscriptionNameInput";
            this.subscriptionNameInput.Size = new System.Drawing.Size(277, 23);
            this.subscriptionNameInput.TabIndex = 0;
            // 
            // addSubscriptionBtn
            // 
            this.addSubscriptionBtn.Location = new System.Drawing.Point(15, 359);
            this.addSubscriptionBtn.Name = "addSubscriptionBtn";
            this.addSubscriptionBtn.Size = new System.Drawing.Size(164, 31);
            this.addSubscriptionBtn.TabIndex = 3;
            this.addSubscriptionBtn.Text = "Добавить подписку";
            this.addSubscriptionBtn.UseVisualStyleBackColor = true;
            this.addSubscriptionBtn.Click += new System.EventHandler(this.addSubscriptionBtn_Click);
            // 
            // queryTable
            // 
            this.queryTable.ColumnCount = 2;
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.97561F));
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.02439F));
            this.queryTable.Controls.Add(this.label2, 0, 1);
            this.queryTable.Controls.Add(this.dateLabel, 0, 0);
            this.queryTable.Controls.Add(this.subscriptionNameInput, 1, 0);
            this.queryTable.Controls.Add(this.label1, 0, 2);
            this.queryTable.Controls.Add(this.availableQueryTypesInput, 1, 2);
            this.queryTable.Controls.Add(this.sumInput, 1, 1);
            this.queryTable.Location = new System.Drawing.Point(12, 12);
            this.queryTable.Name = "queryTable";
            this.queryTable.RowCount = 3;
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.queryTable.Size = new System.Drawing.Size(410, 341);
            this.queryTable.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Стоимость, руб";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Доступные типы запросов";
            // 
            // availableQueryTypesInput
            // 
            this.availableQueryTypesInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.availableQueryTypesInput.FormattingEnabled = true;
            this.availableQueryTypesInput.ItemHeight = 16;
            this.availableQueryTypesInput.Location = new System.Drawing.Point(130, 61);
            this.availableQueryTypesInput.Name = "availableQueryTypesInput";
            this.availableQueryTypesInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.availableQueryTypesInput.Size = new System.Drawing.Size(277, 276);
            this.availableQueryTypesInput.TabIndex = 2;
            // 
            // sumInput
            // 
            this.sumInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sumInput.ForeColor = System.Drawing.Color.Red;
            this.sumInput.IsCorrect = false;
            this.sumInput.Location = new System.Drawing.Point(130, 32);
            this.sumInput.Name = "sumInput";
            this.sumInput.Size = new System.Drawing.Size(277, 22);
            this.sumInput.TabIndex = 1;
            this.sumInput.Value = new decimal(new int[] {0, 0, 0, 0});
            // 
            // EditSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 399);
            this.Controls.Add(this.addSubscriptionBtn);
            this.Controls.Add(this.queryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditSubscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление подписки";
            this.queryTable.ResumeLayout(false);
            this.queryTable.PerformLayout();
            this.ResumeLayout(false);
        }

        public MusicBotAdministration.Controls.DecimalBox sumInput;
        private System.Windows.Forms.Label label2;

        public System.Windows.Forms.ListBox availableQueryTypesInput;

        private System.Windows.Forms.Label label1;

        public System.Windows.Forms.Button addSubscriptionBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TableLayoutPanel queryTable;
        public System.Windows.Forms.TextBox subscriptionNameInput;

        #endregion
    }
}