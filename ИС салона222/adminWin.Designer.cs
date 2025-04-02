namespace ИС_салона222
{
    partial class adminWin
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.редакцияБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользователиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(1061, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 258);
            this.dataGridView1.TabIndex = 7;
            // 
            // редакцияБДToolStripMenuItem
            // 
            this.редакцияБДToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.редакцияБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.услугиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.записьToolStripMenuItem});
            this.редакцияБДToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.редакцияБДToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.редакцияБДToolStripMenuItem.Name = "редакцияБДToolStripMenuItem";
            this.редакцияБДToolStripMenuItem.Size = new System.Drawing.Size(215, 40);
            this.редакцияБДToolStripMenuItem.Text = "Редакция БД";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.услугиToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.услугиToolStripMenuItem.Text = "Список услуг";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.сотрудникиToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // записьToolStripMenuItem
            // 
            this.записьToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.записьToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.записьToolStripMenuItem.Name = "записьToolStripMenuItem";
            this.записьToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.записьToolStripMenuItem.Text = "Записи";
            this.записьToolStripMenuItem.Click += new System.EventHandler(this.записьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакцияБДToolStripMenuItem,
            this.пользователиToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 44);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользователиToolStripMenuItem1
            // 
            this.пользователиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.показатьToolStripMenuItem});
            this.пользователиToolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пользователиToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.пользователиToolStripMenuItem1.Name = "пользователиToolStripMenuItem1";
            this.пользователиToolStripMenuItem1.Size = new System.Drawing.Size(232, 40);
            this.пользователиToolStripMenuItem1.Text = "Пользователи";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.добавитьToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(233, 40);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(233, 40);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.изменитьToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(233, 40);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.показатьToolStripMenuItem.ForeColor = System.Drawing.Color.LightSlateGray;
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(233, 40);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.показатьToolStripMenuItem_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Khaki;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.SaveBtn.Location = new System.Drawing.Point(883, 511);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(256, 54);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить изменения";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // adminWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1188, 662);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem редакцияБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem записьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.Button SaveBtn;
    }
}