using System.ComponentModel;

namespace MusicBotAdministration.Forms.Tables
{
    partial class TracksTable
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
            this.tracksTableLabel = new System.Windows.Forms.Label();
            this.generalTracksTable = new System.Windows.Forms.DataGridView();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.changeRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.generalTracksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tracksTableLabel
            // 
            this.tracksTableLabel.Location = new System.Drawing.Point(12, 10);
            this.tracksTableLabel.Name = "tracksTableLabel";
            this.tracksTableLabel.Size = new System.Drawing.Size(169, 19);
            this.tracksTableLabel.TabIndex = 22;
            this.tracksTableLabel.Text = "Треки";
            // 
            // generalTracksTable
            // 
            this.generalTracksTable.AllowUserToAddRows = false;
            this.generalTracksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generalTracksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalTracksTable.Location = new System.Drawing.Point(12, 29);
            this.generalTracksTable.Name = "generalTracksTable";
            this.generalTracksTable.ReadOnly = true;
            this.generalTracksTable.RowTemplate.Height = 24;
            this.generalTracksTable.Size = new System.Drawing.Size(474, 426);
            this.generalTracksTable.TabIndex = 21;
            // 
            // addRowBtn
            // 
            this.addRowBtn.Location = new System.Drawing.Point(12, 461);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(154, 24);
            this.addRowBtn.TabIndex = 0;
            this.addRowBtn.Text = "Добавить запись";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // changeRowBtn
            // 
            this.changeRowBtn.Location = new System.Drawing.Point(172, 461);
            this.changeRowBtn.Name = "changeRowBtn";
            this.changeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.changeRowBtn.TabIndex = 1;
            this.changeRowBtn.Text = "Изменить запись";
            this.changeRowBtn.UseVisualStyleBackColor = true;
            this.changeRowBtn.Click += new System.EventHandler(this.changeRowBtn_Click);
            // 
            // TracksTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 491);
            this.Controls.Add(this.tracksTableLabel);
            this.Controls.Add(this.generalTracksTable);
            this.Controls.Add(this.addRowBtn);
            this.Controls.Add(this.changeRowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TracksTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Треки";
            ((System.ComponentModel.ISupportInitialize) (this.generalTracksTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.Button changeRowBtn;
        private System.Windows.Forms.DataGridView generalTracksTable;
        private System.Windows.Forms.Label tracksTableLabel;

        #endregion
    }
}