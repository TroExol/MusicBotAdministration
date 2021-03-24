using System.ComponentModel;

namespace MusicBotAdministration.Forms.Tables
{
    partial class SubscriptionsTable
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
            this.subscriptionsTableLabel = new System.Windows.Forms.Label();
            this.generalSubscriptionsTable = new System.Windows.Forms.DataGridView();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.changeRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.generalSubscriptionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // subscriptionsTableLabel
            // 
            this.subscriptionsTableLabel.Location = new System.Drawing.Point(12, 8);
            this.subscriptionsTableLabel.Name = "subscriptionsTableLabel";
            this.subscriptionsTableLabel.Size = new System.Drawing.Size(169, 19);
            this.subscriptionsTableLabel.TabIndex = 18;
            this.subscriptionsTableLabel.Text = "Подписки";
            // 
            // generalSubscriptionsTable
            // 
            this.generalSubscriptionsTable.AllowUserToAddRows = false;
            this.generalSubscriptionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generalSubscriptionsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.generalSubscriptionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.generalSubscriptionsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.generalSubscriptionsTable.Location = new System.Drawing.Point(12, 27);
            this.generalSubscriptionsTable.Name = "generalSubscriptionsTable";
            this.generalSubscriptionsTable.ReadOnly = true;
            this.generalSubscriptionsTable.RowTemplate.Height = 24;
            this.generalSubscriptionsTable.Size = new System.Drawing.Size(586, 426);
            this.generalSubscriptionsTable.TabIndex = 17;
            // 
            // addRowBtn
            // 
            this.addRowBtn.Location = new System.Drawing.Point(12, 459);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(154, 24);
            this.addRowBtn.TabIndex = 0;
            this.addRowBtn.Text = "Добавить запись";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // changeRowBtn
            // 
            this.changeRowBtn.Location = new System.Drawing.Point(172, 459);
            this.changeRowBtn.Name = "changeRowBtn";
            this.changeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.changeRowBtn.TabIndex = 1;
            this.changeRowBtn.Text = "Изменить запись";
            this.changeRowBtn.UseVisualStyleBackColor = true;
            this.changeRowBtn.Click += new System.EventHandler(this.changeRowBtn_Click);
            // 
            // SubscriptionsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 494);
            this.Controls.Add(this.subscriptionsTableLabel);
            this.Controls.Add(this.generalSubscriptionsTable);
            this.Controls.Add(this.addRowBtn);
            this.Controls.Add(this.changeRowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SubscriptionsTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подписки";
            ((System.ComponentModel.ISupportInitialize) (this.generalSubscriptionsTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.Button changeRowBtn;
        private System.Windows.Forms.Label subscriptionsTableLabel;
        private System.Windows.Forms.DataGridView generalSubscriptionsTable;

        #endregion
    }
}