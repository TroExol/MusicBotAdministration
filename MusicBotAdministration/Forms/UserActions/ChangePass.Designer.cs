using System.ComponentModel;

namespace MusicBotAdministration.Forms.UserActions
{
    partial class ChangePass
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
            this.oldPassInput = new System.Windows.Forms.TextBox();
            this.newPassInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите старый пароль";
            // 
            // oldPassInput
            // 
            this.oldPassInput.Location = new System.Drawing.Point(102, 46);
            this.oldPassInput.Name = "oldPassInput";
            this.oldPassInput.PasswordChar = '*';
            this.oldPassInput.Size = new System.Drawing.Size(176, 22);
            this.oldPassInput.TabIndex = 0;
            // 
            // newPassInput
            // 
            this.newPassInput.Location = new System.Drawing.Point(102, 105);
            this.newPassInput.Name = "newPassInput";
            this.newPassInput.PasswordChar = '*';
            this.newPassInput.Size = new System.Drawing.Size(176, 22);
            this.newPassInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(102, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите новый пароль";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(136, 142);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(106, 31);
            this.changePassBtn.TabIndex = 2;
            this.changePassBtn.Text = "Изменить";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.ChangePassBtn_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 197);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.newPassInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPassInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassInput;

        private System.Windows.Forms.TextBox oldPassInput;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}