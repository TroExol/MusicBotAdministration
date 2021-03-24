using System.ComponentModel;

namespace MusicBotAdministration.Forms.Tables
{
    partial class UserSelectTable
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
            this.userTable = new System.Windows.Forms.DataGridView();
            this.selectUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(3, 2);
            this.userTable.MultiSelect = false;
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowTemplate.Height = 24;
            this.userTable.Size = new System.Drawing.Size(507, 297);
            this.userTable.TabIndex = 0;
            // 
            // selectUserBtn
            // 
            this.selectUserBtn.Location = new System.Drawing.Point(391, 305);
            this.selectUserBtn.Name = "selectUserBtn";
            this.selectUserBtn.Size = new System.Drawing.Size(119, 32);
            this.selectUserBtn.TabIndex = 1;
            this.selectUserBtn.Text = "Выбрать";
            this.selectUserBtn.UseVisualStyleBackColor = true;
            this.selectUserBtn.Click += new System.EventHandler(this.selectUserBtn_Click);
            // 
            // UserSelectTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.selectUserBtn);
            this.Controls.Add(this.userTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserSelectTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор пользователя";
            ((System.ComponentModel.ISupportInitialize) (this.userTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button selectUserBtn;

        private System.Windows.Forms.DataGridView userTable;

        #endregion
    }
}