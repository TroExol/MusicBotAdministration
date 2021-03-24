using MusicBotAdministration.Controls;

namespace MusicBotAdministration.Forms.UserActions
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.loginInput = new MusicBotAdministration.Controls.LatinTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginInput
            // 
            this.loginInput.IsCorrect = false;
            this.loginInput.Location = new System.Drawing.Point(95, 48);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(172, 22);
            this.loginInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(95, 99);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(172, 22);
            this.passwordInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(95, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // authorizeBtn
            // 
            this.authorizeBtn.Location = new System.Drawing.Point(136, 139);
            this.authorizeBtn.Name = "authorizeBtn";
            this.authorizeBtn.Size = new System.Drawing.Size(84, 31);
            this.authorizeBtn.TabIndex = 2;
            this.authorizeBtn.Text = "Войти";
            this.authorizeBtn.UseVisualStyleBackColor = true;
            this.authorizeBtn.Click += new System.EventHandler(this.Authorize_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(362, 183);
            this.Controls.Add(this.authorizeBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Auth_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button authorizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordInput;
        private LatinTextBox loginInput;

        #endregion
    }
}