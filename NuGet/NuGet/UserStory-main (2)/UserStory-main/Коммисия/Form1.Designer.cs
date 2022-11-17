namespace Коммисия
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Change2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete2 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_Program = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Change = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl150 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaObucheniya_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matem_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rus_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inf_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.Change2,
            this.Delete2});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // Change2
            // 
            this.Change2.Name = "Change2";
            this.Change2.Size = new System.Drawing.Size(128, 22);
            this.Change2.Text = "Изменить";
            this.Change2.Click += new System.EventHandler(this.Change2_Click);
            // 
            // Delete2
            // 
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(128, 22);
            this.Delete2.Text = "Удалить";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_Program});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // About_Program
            // 
            this.About_Program.Name = "About_Program";
            this.About_Program.Size = new System.Drawing.Size(151, 22);
            this.About_Program.Text = "О Программе";
            this.About_Program.Click += new System.EventHandler(this.About_Program_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Change,
            this.Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(920, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(83, 24);
            this.Add.Text = "Добавить";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.Enabled = false;
            this.Change.Image = ((System.Drawing.Image)(resources.GetObject("Change.Image")));
            this.Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(85, 24);
            this.Change.Text = "Изменить";
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 24);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus,
            this.lbl150});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(920, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = false;
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(315, 21);
            this.lblstatus.Text = "Всего абитуриентов: 0";
            // 
            // lbl150
            // 
            this.lbl150.AutoSize = false;
            this.lbl150.Name = "lbl150";
            this.lbl150.Size = new System.Drawing.Size(315, 21);
            this.lbl150.Text = "Студенты, набравшие больше 150 баллов: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName_Column,
            this.Gender_Column,
            this.Birthday_Column,
            this.FormaObucheniya_Column,
            this.Matem_Column,
            this.Rus_Column,
            this.Inf_Column,
            this.Sum_Column});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(919, 423);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(919, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(919, 423);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FullName_Column
            // 
            this.FullName_Column.DataPropertyName = "FullName";
            this.FullName_Column.HeaderText = "ФИО";
            this.FullName_Column.MinimumWidth = 6;
            this.FullName_Column.Name = "FullName_Column";
            this.FullName_Column.ReadOnly = true;
            this.FullName_Column.Width = 125;
            // 
            // Gender_Column
            // 
            this.Gender_Column.DataPropertyName = "Gender";
            this.Gender_Column.HeaderText = "Пол";
            this.Gender_Column.MinimumWidth = 6;
            this.Gender_Column.Name = "Gender_Column";
            this.Gender_Column.ReadOnly = true;
            this.Gender_Column.Width = 125;
            // 
            // Birthday_Column
            // 
            this.Birthday_Column.DataPropertyName = "Birthday";
            this.Birthday_Column.HeaderText = "Дата рождения";
            this.Birthday_Column.MinimumWidth = 6;
            this.Birthday_Column.Name = "Birthday_Column";
            this.Birthday_Column.ReadOnly = true;
            this.Birthday_Column.Width = 125;
            // 
            // FormaObucheniya_Column
            // 
            this.FormaObucheniya_Column.DataPropertyName = "FormaObucheniya";
            this.FormaObucheniya_Column.HeaderText = "Форма обучения";
            this.FormaObucheniya_Column.MinimumWidth = 6;
            this.FormaObucheniya_Column.Name = "FormaObucheniya_Column";
            this.FormaObucheniya_Column.ReadOnly = true;
            this.FormaObucheniya_Column.Width = 125;
            // 
            // Matem_Column
            // 
            this.Matem_Column.DataPropertyName = "Matem";
            this.Matem_Column.HeaderText = "Баллы ЕГЭ по математике";
            this.Matem_Column.MinimumWidth = 6;
            this.Matem_Column.Name = "Matem_Column";
            this.Matem_Column.ReadOnly = true;
            this.Matem_Column.Width = 125;
            // 
            // Rus_Column
            // 
            this.Rus_Column.DataPropertyName = "Rus";
            this.Rus_Column.HeaderText = "Баллы ЕГЭ по русскому";
            this.Rus_Column.MinimumWidth = 6;
            this.Rus_Column.Name = "Rus_Column";
            this.Rus_Column.ReadOnly = true;
            this.Rus_Column.Width = 125;
            // 
            // Inf_Column
            // 
            this.Inf_Column.DataPropertyName = "Inf";
            this.Inf_Column.HeaderText = "Баллы ЕГЭ по информатике";
            this.Inf_Column.MinimumWidth = 6;
            this.Inf_Column.Name = "Inf_Column";
            this.Inf_Column.ReadOnly = true;
            this.Inf_Column.Width = 125;
            // 
            // Sum_Column
            // 
            this.Sum_Column.DataPropertyName = "Sum";
            this.Sum_Column.HeaderText = "Общая сумма баллов";
            this.Sum_Column.MinimumWidth = 6;
            this.Sum_Column.Name = "Sum_Column";
            this.Sum_Column.ReadOnly = true;
            this.Sum_Column.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(936, 545);
            this.MinimumSize = new System.Drawing.Size(936, 545);
            this.Name = "Form1";
            this.Text = "Приемная комиссия";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Change2;
        private System.Windows.Forms.ToolStripMenuItem Delete2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_Program;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton Change;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.ToolStripStatusLabel lbl150;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaObucheniya_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matem_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rus_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inf_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum_Column;
    }
}

