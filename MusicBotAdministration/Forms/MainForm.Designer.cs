using System.ComponentModel;

namespace MusicBotAdministration.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderMenu = new System.Windows.Forms.MenuStrip();
            this.администрироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workTypesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workSubsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workPaymentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workMusicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыЗапросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активныеПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конструкторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FooterStatus = new System.Windows.Forms.StatusStrip();
            this.LoginStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FIOStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ChangeToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changePassMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitUserMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRowBtn = new System.Windows.Forms.Button();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.removeRowBtn = new System.Windows.Forms.Button();
            this.queriesTable = new System.Windows.Forms.DataGridView();
            this.queriesTableLabel = new System.Windows.Forms.Label();
            this.HeaderMenu.SuspendLayout();
            this.FooterStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.queriesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.администрироватьToolStripMenuItem, this.отчетToolStripMenuItem, this.конструкторToolStripMenuItem, this.toolStripSeparator1, this.оПрограммеToolStripMenuItem});
            this.HeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.HeaderMenu.Name = "HeaderMenu";
            this.HeaderMenu.Size = new System.Drawing.Size(1116, 28);
            this.HeaderMenu.TabIndex = 2;
            this.HeaderMenu.Text = "Верхнее меню";
            // 
            // администрироватьToolStripMenuItem
            // 
            this.администрироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.workTypesMenuItem, this.workSubsMenuItem, this.workUsersMenuItem, this.workPaymentsMenuItem, this.workMusicMenuItem});
            this.администрироватьToolStripMenuItem.Name = "администрироватьToolStripMenuItem";
            this.администрироватьToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.администрироватьToolStripMenuItem.Text = "Администрировать";
            // 
            // workTypesMenuItem
            // 
            this.workTypesMenuItem.Name = "workTypesMenuItem";
            this.workTypesMenuItem.Size = new System.Drawing.Size(263, 24);
            this.workTypesMenuItem.Text = "Работа с типами запросов";
            this.workTypesMenuItem.Click += new System.EventHandler(this.workTypesMenuItem_Click);
            // 
            // workSubsMenuItem
            // 
            this.workSubsMenuItem.Name = "workSubsMenuItem";
            this.workSubsMenuItem.Size = new System.Drawing.Size(263, 24);
            this.workSubsMenuItem.Text = "Работа с подписками";
            this.workSubsMenuItem.Click += new System.EventHandler(this.workSubsMenuItem_Click);
            // 
            // workUsersMenuItem
            // 
            this.workUsersMenuItem.Name = "workUsersMenuItem";
            this.workUsersMenuItem.Size = new System.Drawing.Size(263, 24);
            this.workUsersMenuItem.Text = "Работа с пользователями";
            this.workUsersMenuItem.Click += new System.EventHandler(this.workUsersMenuItem_Click);
            // 
            // workPaymentsMenuItem
            // 
            this.workPaymentsMenuItem.Name = "workPaymentsMenuItem";
            this.workPaymentsMenuItem.Size = new System.Drawing.Size(263, 24);
            this.workPaymentsMenuItem.Text = "Работа с оплатами";
            this.workPaymentsMenuItem.Click += new System.EventHandler(this.workPaymentsMenuItem_Click);
            // 
            // workMusicMenuItem
            // 
            this.workMusicMenuItem.Name = "workMusicMenuItem";
            this.workMusicMenuItem.Size = new System.Drawing.Size(263, 24);
            this.workMusicMenuItem.Text = "Работа с треками";
            this.workMusicMenuItem.Click += new System.EventHandler(this.workMusicMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.запросыToolStripMenuItem, this.оплатыToolStripMenuItem, this.типыЗапросовToolStripMenuItem, this.активныеПользователиToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.запросыToolStripMenuItem.Text = "Запросы";
            this.запросыToolStripMenuItem.Click += new System.EventHandler(this.запросыToolStripMenuItem_Click);
            // 
            // оплатыToolStripMenuItem
            // 
            this.оплатыToolStripMenuItem.Name = "оплатыToolStripMenuItem";
            this.оплатыToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.оплатыToolStripMenuItem.Text = "Доходы с продаж подписок";
            this.оплатыToolStripMenuItem.Click += new System.EventHandler(this.оплатыToolStripMenuItem_Click);
            // 
            // типыЗапросовToolStripMenuItem
            // 
            this.типыЗапросовToolStripMenuItem.Name = "типыЗапросовToolStripMenuItem";
            this.типыЗапросовToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.типыЗапросовToolStripMenuItem.Text = "Популярность типов запросов";
            this.типыЗапросовToolStripMenuItem.Click += new System.EventHandler(this.типыЗапросовToolStripMenuItem_Click);
            // 
            // активныеПользователиToolStripMenuItem
            // 
            this.активныеПользователиToolStripMenuItem.Name = "активныеПользователиToolStripMenuItem";
            this.активныеПользователиToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.активныеПользователиToolStripMenuItem.Text = "Активность пользователей";
            this.активныеПользователиToolStripMenuItem.Click += new System.EventHandler(this.активныеПользователиToolStripMenuItem_Click);
            // 
            // конструкторToolStripMenuItem
            // 
            this.конструкторToolStripMenuItem.Name = "конструкторToolStripMenuItem";
            this.конструкторToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.конструкторToolStripMenuItem.Text = "Конструктор";
            this.конструкторToolStripMenuItem.Click += new System.EventHandler(this.конструкторToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.aboutProgMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // aboutProgMenuItem
            // 
            this.aboutProgMenuItem.Name = "aboutProgMenuItem";
            this.aboutProgMenuItem.Size = new System.Drawing.Size(182, 24);
            this.aboutProgMenuItem.Text = "О программе...";
            this.aboutProgMenuItem.Click += new System.EventHandler(this.AboutProgMenuItem_Click);
            // 
            // FooterStatus
            // 
            this.FooterStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.LoginStatusLabel, this.FIOStatusLabel, this.ChangeToolStripDropDownButton});
            this.FooterStatus.Location = new System.Drawing.Point(0, 691);
            this.FooterStatus.Name = "FooterStatus";
            this.FooterStatus.Size = new System.Drawing.Size(1116, 26);
            this.FooterStatus.SizingGrip = false;
            this.FooterStatus.TabIndex = 3;
            this.FooterStatus.Text = "Нижний статус";
            // 
            // LoginStatusLabel
            // 
            this.LoginStatusLabel.Name = "LoginStatusLabel";
            this.LoginStatusLabel.Size = new System.Drawing.Size(52, 21);
            this.LoginStatusLabel.Text = "Логин";
            // 
            // FIOStatusLabel
            // 
            this.FIOStatusLabel.Name = "FIOStatusLabel";
            this.FIOStatusLabel.Size = new System.Drawing.Size(42, 21);
            this.FIOStatusLabel.Text = "ФИО";
            // 
            // ChangeToolStripDropDownButton
            // 
            this.ChangeToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChangeToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.changePassMenuItem, this.exitUserMenuStrip});
            this.ChangeToolStripDropDownButton.Image = ((System.Drawing.Image) (resources.GetObject("ChangeToolStripDropDownButton.Image")));
            this.ChangeToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeToolStripDropDownButton.Name = "ChangeToolStripDropDownButton";
            this.ChangeToolStripDropDownButton.Size = new System.Drawing.Size(132, 24);
            this.ChangeToolStripDropDownButton.Text = "Администратор";
            // 
            // changePassMenuItem
            // 
            this.changePassMenuItem.Name = "changePassMenuItem";
            this.changePassMenuItem.Size = new System.Drawing.Size(262, 24);
            this.changePassMenuItem.Text = "Изменить пароль";
            this.changePassMenuItem.Click += new System.EventHandler(this.ChangePassMenuItem_Click);
            // 
            // exitUserMenuStrip
            // 
            this.exitUserMenuStrip.Name = "exitUserMenuStrip";
            this.exitUserMenuStrip.Size = new System.Drawing.Size(262, 24);
            this.exitUserMenuStrip.Text = "Выйти из администратора";
            this.exitUserMenuStrip.Click += new System.EventHandler(this.ExitUser_Click);
            // 
            // changeRowBtn
            // 
            this.changeRowBtn.Location = new System.Drawing.Point(172, 655);
            this.changeRowBtn.Name = "changeRowBtn";
            this.changeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.changeRowBtn.TabIndex = 1;
            this.changeRowBtn.Text = "Изменить запись";
            this.changeRowBtn.UseVisualStyleBackColor = true;
            this.changeRowBtn.Click += new System.EventHandler(this.changeRowBtn_Click);
            // 
            // addRowBtn
            // 
            this.addRowBtn.Location = new System.Drawing.Point(12, 655);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(154, 24);
            this.addRowBtn.TabIndex = 0;
            this.addRowBtn.Text = "Добавить запись";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // removeRowBtn
            // 
            this.removeRowBtn.Location = new System.Drawing.Point(332, 655);
            this.removeRowBtn.Name = "removeRowBtn";
            this.removeRowBtn.Size = new System.Drawing.Size(154, 24);
            this.removeRowBtn.TabIndex = 2;
            this.removeRowBtn.Text = "Удалить записи";
            this.removeRowBtn.UseVisualStyleBackColor = true;
            this.removeRowBtn.Click += new System.EventHandler(this.removeRowBtn_Click);
            // 
            // queriesTable
            // 
            this.queriesTable.AllowUserToAddRows = false;
            this.queriesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.queriesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.queriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.queriesTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.queriesTable.Location = new System.Drawing.Point(0, 55);
            this.queriesTable.Name = "queriesTable";
            this.queriesTable.ReadOnly = true;
            this.queriesTable.RowTemplate.Height = 24;
            this.queriesTable.Size = new System.Drawing.Size(1116, 594);
            this.queriesTable.TabIndex = 8;
            // 
            // queriesTableLabel
            // 
            this.queriesTableLabel.Location = new System.Drawing.Point(12, 36);
            this.queriesTableLabel.Name = "queriesTableLabel";
            this.queriesTableLabel.Size = new System.Drawing.Size(169, 19);
            this.queriesTableLabel.TabIndex = 9;
            this.queriesTableLabel.Text = "Запросы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 717);
            this.Controls.Add(this.queriesTableLabel);
            this.Controls.Add(this.queriesTable);
            this.Controls.Add(this.removeRowBtn);
            this.Controls.Add(this.addRowBtn);
            this.Controls.Add(this.changeRowBtn);
            this.Controls.Add(this.FooterStatus);
            this.Controls.Add(this.HeaderMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.HeaderMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.HeaderMenu.ResumeLayout(false);
            this.HeaderMenu.PerformLayout();
            this.FooterStatus.ResumeLayout(false);
            this.FooterStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.queriesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem конструкторToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem активныеПользователиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem типыЗапросовToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатыToolStripMenuItem;

        private System.Windows.Forms.Label queriesTableLabel;

        private System.Windows.Forms.DataGridView queriesTable;

        private System.Windows.Forms.Button removeRowBtn;

        private System.Windows.Forms.Button addRowBtn;

        private System.Windows.Forms.Button changeRowBtn;

        private System.Windows.Forms.ToolStripMenuItem exitUserMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem workMusicMenuItem;

        private System.Windows.Forms.ToolStripMenuItem workPaymentsMenuItem;

        private System.Windows.Forms.ToolStripMenuItem workUsersMenuItem;

        private System.Windows.Forms.ToolStripMenuItem workSubsMenuItem;

        private System.Windows.Forms.ToolStripMenuItem workTypesMenuItem;

        private System.Windows.Forms.ToolStripMenuItem aboutProgMenuItem;

        private System.Windows.Forms.ToolStripMenuItem администрироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem changePassMenuItem;

        private System.Windows.Forms.ToolStripDropDownButton ChangeToolStripDropDownButton;

        private System.Windows.Forms.ToolStripStatusLabel LoginStatusLabel;

        private System.Windows.Forms.ToolStripStatusLabel FIOStatusLabel;

        private System.Windows.Forms.StatusStrip FooterStatus;

        private System.Windows.Forms.MenuStrip HeaderMenu;

        #endregion
    }
}