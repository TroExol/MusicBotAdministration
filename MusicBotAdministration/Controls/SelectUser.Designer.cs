using System.ComponentModel;

namespace MusicBotAdministration.Controls
{
    partial class SelectUser
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.queryUserInput = new System.Windows.Forms.TextBox();
            this.openSelectUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryUserInput
            // 
            this.queryUserInput.Enabled = false;
            this.queryUserInput.Location = new System.Drawing.Point(0, 0);
            this.queryUserInput.Margin = new System.Windows.Forms.Padding(0);
            this.queryUserInput.Multiline = true;
            this.queryUserInput.Name = "queryUserInput";
            this.queryUserInput.ReadOnly = true;
            this.queryUserInput.Size = new System.Drawing.Size(253, 50);
            this.queryUserInput.TabIndex = 0;
            this.queryUserInput.TabStop = false;
            // 
            // openSelectUserBtn
            // 
            this.openSelectUserBtn.Location = new System.Drawing.Point(259, 0);
            this.openSelectUserBtn.Margin = new System.Windows.Forms.Padding(0);
            this.openSelectUserBtn.Name = "openSelectUserBtn";
            this.openSelectUserBtn.Size = new System.Drawing.Size(121, 51);
            this.openSelectUserBtn.TabIndex = 0;
            this.openSelectUserBtn.Text = "Выбрать пользователя";
            this.openSelectUserBtn.UseVisualStyleBackColor = true;
            this.openSelectUserBtn.Click += new System.EventHandler(this.openSelectUserBtn_Click);
            // 
            // SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openSelectUserBtn);
            this.Controls.Add(this.queryUserInput);
            this.Name = "SelectUser";
            this.Size = new System.Drawing.Size(379, 50);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button openSelectUserBtn;

        private System.Windows.Forms.TextBox queryUserInput;

        #endregion
    }
}