using System.ComponentModel;

namespace MusicBotAdministration.Controls
{
    partial class SelectTracks
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTracksTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.selectTracksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(110, 0);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(243, 43);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск треков:";
            // 
            // selectTracksTable
            // 
            this.selectTracksTable.AllowUserToAddRows = false;
            this.selectTracksTable.AllowUserToDeleteRows = false;
            this.selectTracksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.selectTracksTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.selectTracksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectTracksTable.Location = new System.Drawing.Point(0, 49);
            this.selectTracksTable.Name = "selectTracksTable";
            this.selectTracksTable.ReadOnly = true;
            this.selectTracksTable.RowHeadersVisible = false;
            this.selectTracksTable.RowTemplate.Height = 24;
            this.selectTracksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectTracksTable.Size = new System.Drawing.Size(352, 306);
            this.selectTracksTable.TabIndex = 1;
            this.selectTracksTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.selectTracksTable_DataBindingComplete);
            this.selectTracksTable.Click += new System.EventHandler(this.selectTracksTable_SelectionChanged);
            // 
            // SelectTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectTracksTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Name = "SelectTracks";
            this.Size = new System.Drawing.Size(353, 356);
            ((System.ComponentModel.ISupportInitialize) (this.selectTracksTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.DataGridView selectTracksTable;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;

        #endregion
    }
}