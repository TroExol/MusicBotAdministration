using System.ComponentModel;
using MusicBotAdministration.Controls;

namespace MusicBotAdministration.Forms.EditData
{
    partial class EditQuery
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
            this.queryTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.queryTypeInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.queryDateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.queryCountMusicInput = new MusicBotAdministration.Controls.NumberBox(this.components);
            this.queryAuthorInput = new System.Windows.Forms.TextBox();
            this.queryUserInput = new MusicBotAdministration.Controls.SelectUser();
            this.receivedTracksInput = new MusicBotAdministration.Controls.SelectTracks();
            this.addQueryBtn = new System.Windows.Forms.Button();
            this.queryTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryTable
            // 
            this.queryTable.ColumnCount = 2;
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.77509F));
            this.queryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.22491F));
            this.queryTable.Controls.Add(this.label5, 0, 5);
            this.queryTable.Controls.Add(this.queryTypeInput, 1, 4);
            this.queryTable.Controls.Add(this.label4, 0, 4);
            this.queryTable.Controls.Add(this.dateLabel, 0, 0);
            this.queryTable.Controls.Add(this.label1, 0, 1);
            this.queryTable.Controls.Add(this.label2, 0, 2);
            this.queryTable.Controls.Add(this.label3, 0, 3);
            this.queryTable.Controls.Add(this.queryDateTimeInput, 1, 0);
            this.queryTable.Controls.Add(this.queryCountMusicInput, 1, 1);
            this.queryTable.Controls.Add(this.queryAuthorInput, 1, 2);
            this.queryTable.Controls.Add(this.queryUserInput, 1, 3);
            this.queryTable.Controls.Add(this.receivedTracksInput, 1, 5);
            this.queryTable.Location = new System.Drawing.Point(12, 12);
            this.queryTable.Name = "queryTable";
            this.queryTable.RowCount = 6;
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.queryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.queryTable.Size = new System.Drawing.Size(589, 554);
            this.queryTable.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Location = new System.Drawing.Point(3, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Полученные треки";
            // 
            // queryTypeInput
            // 
            this.queryTypeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.queryTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryTypeInput.FormattingEnabled = true;
            this.queryTypeInput.Location = new System.Drawing.Point(207, 159);
            this.queryTypeInput.Name = "queryTypeInput";
            this.queryTypeInput.Size = new System.Drawing.Size(379, 24);
            this.queryTypeInput.TabIndex = 4;
            this.queryTypeInput.SelectedIndexChanged += new System.EventHandler(this.queryTypeInput_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип запроса";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.Location = new System.Drawing.Point(3, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(107, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата запроса";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество треков";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Запрашиваемый автор";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пользователь";
            // 
            // queryDateTimeInput
            // 
            this.queryDateTimeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.queryDateTimeInput.Location = new System.Drawing.Point(207, 3);
            this.queryDateTimeInput.MaxDate = new System.DateTime(2021, 12, 16, 0, 0, 0, 0);
            this.queryDateTimeInput.Name = "queryDateTimeInput";
            this.queryDateTimeInput.Size = new System.Drawing.Size(379, 22);
            this.queryDateTimeInput.TabIndex = 0;
            this.queryDateTimeInput.Value = new System.DateTime(2021, 3, 7, 0, 0, 0, 0);
            // 
            // queryCountMusicInput
            // 
            this.queryCountMusicInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.queryCountMusicInput.IsCorrect = false;
            this.queryCountMusicInput.Location = new System.Drawing.Point(207, 34);
            this.queryCountMusicInput.Name = "queryCountMusicInput";
            this.queryCountMusicInput.Size = new System.Drawing.Size(379, 22);
            this.queryCountMusicInput.TabIndex = 1;
            // 
            // queryAuthorInput
            // 
            this.queryAuthorInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.queryAuthorInput.Location = new System.Drawing.Point(207, 66);
            this.queryAuthorInput.Name = "queryAuthorInput";
            this.queryAuthorInput.Size = new System.Drawing.Size(379, 22);
            this.queryAuthorInput.TabIndex = 2;
            // 
            // queryUserInput
            // 
            this.queryUserInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.queryUserInput.IsSelected = false;
            this.queryUserInput.Location = new System.Drawing.Point(207, 97);
            this.queryUserInput.Name = "queryUserInput";
            this.queryUserInput.Size = new System.Drawing.Size(379, 50);
            this.queryUserInput.TabIndex = 3;
            this.queryUserInput.TextBox = "";
            this.queryUserInput.User = null;
            // 
            // receivedTracksInput
            // 
            this.receivedTracksInput.Location = new System.Drawing.Point(207, 194);
            this.receivedTracksInput.Name = "receivedTracksInput";
            this.receivedTracksInput.SelectedTracks = null;
            this.receivedTracksInput.Size = new System.Drawing.Size(379, 357);
            this.receivedTracksInput.TabIndex = 5;
            // 
            // addQueryBtn
            // 
            this.addQueryBtn.Location = new System.Drawing.Point(12, 572);
            this.addQueryBtn.Name = "addQueryBtn";
            this.addQueryBtn.Size = new System.Drawing.Size(164, 31);
            this.addQueryBtn.TabIndex = 5;
            this.addQueryBtn.Text = "Добавить запрос";
            this.addQueryBtn.UseVisualStyleBackColor = true;
            this.addQueryBtn.Click += new System.EventHandler(this.addQueryBtn_Click);
            // 
            // EditQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 611);
            this.Controls.Add(this.addQueryBtn);
            this.Controls.Add(this.queryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление запроса";
            this.queryTable.ResumeLayout(false);
            this.queryTable.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;

        public MusicBotAdministration.Controls.SelectTracks receivedTracksInput;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public MusicBotAdministration.Controls.NumberBox queryCountMusicInput;
        public System.Windows.Forms.DateTimePicker queryDateTimeInput;
        public System.Windows.Forms.ComboBox queryTypeInput;
        public MusicBotAdministration.Controls.SelectUser queryUserInput;

        public System.Windows.Forms.Button addQueryBtn;
        public System.Windows.Forms.TextBox queryAuthorInput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TableLayoutPanel queryTable;

        #endregion
    }
}