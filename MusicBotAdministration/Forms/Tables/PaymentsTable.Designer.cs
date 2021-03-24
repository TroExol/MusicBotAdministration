using System.ComponentModel;

namespace MusicBotAdministration.Forms.Tables
{
    partial class PaymentsTable
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
            this.paymentsTableLabel = new System.Windows.Forms.Label();
            this.generalPaymentsTable = new System.Windows.Forms.DataGridView();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.changeRowBtn = new System.Windows.Forms.Button();
            this.removeRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.generalPaymentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsTableLabel
            // 
            this.paymentsTableLabel.Location = new System.Drawing.Point(12, 9);
            this.paymentsTableLabel.Name = "paymentsTableLabel";
            this.paymentsTableLabel.Size = new System.Drawing.Size(169, 19);
            this.paymentsTableLabel.TabIndex = 18;
            this.paymentsTableLabel.Text = "Оплаты";
            // 
            // generalPaymentsTable
            // 
            this.generalPaymentsTable.AllowUserToAddRows = false;
            this.generalPaymentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.generalPaymentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalPaymentsTable.Location = new System.Drawing.Point(12, 28);
            this.generalPaymentsTable.Name = "generalPaymentsTable";
            this.generalPaymentsTable.ReadOnly = true;
            this.generalPaymentsTable.RowTemplate.Height = 24;
            this.generalPaymentsTable.Size = new System.Drawing.Size(835, 426);
            this.generalPaymentsTable.TabIndex = 17;
            // 
            // addRowBtn
            // 
            this.addRowBtn.Location = new System.Drawing.Point(12, 460);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(154, 24);
            this.addRowBtn.TabIndex = 0;
            this.addRowBtn.Text = "Добавить запись";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // changeRowBtn
            // 
            this.changeRowBtn.Location = new System.Drawing.Point(172, 460);
            this.changeRowBtn.Name = "changeRowBtn";
            this.changeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.changeRowBtn.TabIndex = 1;
            this.changeRowBtn.Text = "Изменить запись";
            this.changeRowBtn.UseVisualStyleBackColor = true;
            this.changeRowBtn.Click += new System.EventHandler(this.changeRowBtn_Click);
            // 
            // removeRowBtn
            // 
            this.removeRowBtn.Location = new System.Drawing.Point(332, 460);
            this.removeRowBtn.Name = "removeRowBtn";
            this.removeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.removeRowBtn.TabIndex = 2;
            this.removeRowBtn.Text = "Удалить записи";
            this.removeRowBtn.UseVisualStyleBackColor = true;
            this.removeRowBtn.Click += new System.EventHandler(this.removeRowBtn_Click);
            // 
            // PaymentsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.removeRowBtn);
            this.Controls.Add(this.paymentsTableLabel);
            this.Controls.Add(this.generalPaymentsTable);
            this.Controls.Add(this.addRowBtn);
            this.Controls.Add(this.changeRowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaymentsTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплаты";
            ((System.ComponentModel.ISupportInitialize) (this.generalPaymentsTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button removeRowBtn;

        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.Button changeRowBtn;
        private System.Windows.Forms.Label paymentsTableLabel;
        private System.Windows.Forms.DataGridView generalPaymentsTable;

        #endregion
    }
}