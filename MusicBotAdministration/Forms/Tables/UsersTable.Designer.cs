using System.ComponentModel;

namespace MusicBotAdministration.Forms.Tables
{
    partial class UsersTable
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
            this.userTableLabel = new System.Windows.Forms.Label();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.changeRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userTableLabel
            // 
            this.userTableLabel.Location = new System.Drawing.Point(12, 6);
            this.userTableLabel.Name = "userTableLabel";
            this.userTableLabel.Size = new System.Drawing.Size(170, 19);
            this.userTableLabel.TabIndex = 16;
            this.userTableLabel.Text = "Пользователи";
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(12, 25);
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowTemplate.Height = 24;
            this.userTable.Size = new System.Drawing.Size(523, 426);
            this.userTable.TabIndex = 0;
            // 
            // addRowBtn
            // 
            this.addRowBtn.Location = new System.Drawing.Point(12, 457);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(154, 24);
            this.addRowBtn.TabIndex = 17;
            this.addRowBtn.Text = "Добавить запись";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // changeRowBtn
            // 
            this.changeRowBtn.Location = new System.Drawing.Point(172, 457);
            this.changeRowBtn.Name = "changeRowBtn";
            this.changeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.changeRowBtn.TabIndex = 18;
            this.changeRowBtn.Text = "Изменить запись";
            this.changeRowBtn.UseVisualStyleBackColor = true;
            this.changeRowBtn.Click += new System.EventHandler(this.changeRowBtn_Click);
            // 
            // UsersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 487);
            this.Controls.Add(this.changeRowBtn);
            this.Controls.Add(this.addRowBtn);
            this.Controls.Add(this.userTableLabel);
            this.Controls.Add(this.userTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsersTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize) (this.userTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button changeRowBtn;

        private System.Windows.Forms.Button addRowBtn;

        private System.Windows.Forms.Label userTableLabel;
        private System.Windows.Forms.DataGridView userTable;

        #endregion
    }
}