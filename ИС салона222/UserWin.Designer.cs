namespace ИС_салона222
{
    partial class UserWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWin));
            this.BtnExit = new System.Windows.Forms.Button();
            this.specialistBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.workerBox = new System.Windows.Forms.TextBox();
            this.servicesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.DataTimeBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.Color.Khaki;
            this.BtnExit.Location = new System.Drawing.Point(972, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(129, 36);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Выйти";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnAuthorization_Click);
            // 
            // specialistBtn
            // 
            this.specialistBtn.BackColor = System.Drawing.Color.SlateGray;
            this.specialistBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialistBtn.ForeColor = System.Drawing.Color.Khaki;
            this.specialistBtn.Location = new System.Drawing.Point(0, 168);
            this.specialistBtn.Name = "specialistBtn";
            this.specialistBtn.Size = new System.Drawing.Size(169, 105);
            this.specialistBtn.TabIndex = 2;
            this.specialistBtn.Text = "Выбрать Специалиста";
            this.specialistBtn.UseVisualStyleBackColor = false;
            this.specialistBtn.Click += new System.EventHandler(this.specialistBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SignUpBtn);
            this.panel1.Controls.Add(this.workerBox);
            this.panel1.Controls.Add(this.servicesBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(168, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 404);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(625, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Специалист:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(625, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Услуга:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(625, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Укажите дату и время,\r\nкоторые не заняты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "*В таблице представлены дата и время,которые уже заняты";
            this.label3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(594, 314);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.SignUpBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Khaki;
            this.SignUpBtn.Location = new System.Drawing.Point(637, 329);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(181, 63);
            this.SignUpBtn.TabIndex = 7;
            this.SignUpBtn.Text = "Создать запись";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // workerBox
            // 
            this.workerBox.Location = new System.Drawing.Point(628, 151);
            this.workerBox.Multiline = true;
            this.workerBox.Name = "workerBox";
            this.workerBox.ReadOnly = true;
            this.workerBox.Size = new System.Drawing.Size(207, 42);
            this.workerBox.TabIndex = 5;
            // 
            // servicesBox
            // 
            this.servicesBox.Location = new System.Drawing.Point(628, 63);
            this.servicesBox.Multiline = true;
            this.servicesBox.Name = "servicesBox";
            this.servicesBox.ReadOnly = true;
            this.servicesBox.Size = new System.Drawing.Size(207, 42);
            this.servicesBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(134, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(638, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добро пожаловать в систему салона!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 1;
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.BackColor = System.Drawing.Color.SlateGray;
            this.ServicesBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesBtn.ForeColor = System.Drawing.Color.Khaki;
            this.ServicesBtn.Location = new System.Drawing.Point(0, 21);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(166, 113);
            this.ServicesBtn.TabIndex = 6;
            this.ServicesBtn.Text = "Выбрать услуги";
            this.ServicesBtn.UseVisualStyleBackColor = false;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
            // 
            // DataTimeBtn
            // 
            this.DataTimeBtn.BackColor = System.Drawing.Color.SlateGray;
            this.DataTimeBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataTimeBtn.ForeColor = System.Drawing.Color.Khaki;
            this.DataTimeBtn.Location = new System.Drawing.Point(-4, 317);
            this.DataTimeBtn.Name = "DataTimeBtn";
            this.DataTimeBtn.Size = new System.Drawing.Size(170, 92);
            this.DataTimeBtn.TabIndex = 7;
            this.DataTimeBtn.Text = "Выбрать дату и время*";
            this.DataTimeBtn.UseVisualStyleBackColor = false;
            this.DataTimeBtn.Click += new System.EventHandler(this.DataTimeBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(23, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 455);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ServicesBtn);
            this.tabPage1.Controls.Add(this.DataTimeBtn);
            this.tabPage1.Controls.Add(this.specialistBtn);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запись";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "О нас";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(8, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1013, 408);
            this.label7.TabIndex = 0;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Khaki;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1034, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Контакты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(432, 198);
            this.label8.TabIndex = 0;
            this.label8.Text = "Контактная информация:\r\nАдрес: Пушкина 23\r\nТелефон: +7 (903) 666-44\r\nЧасы работы:" +
    " Пн-Пт: 10.00-18.00\r\nСб-Вс: Выходной\r\n\r\n";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "укажите дату и время";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(628, 225);
            this.dateTimePicker.MaxDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2025, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(207, 27);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.TabStop = false;
            this.dateTimePicker.Value = new System.DateTime(2025, 4, 23, 15, 32, 16, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // UserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1103, 534);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnExit);
            this.Name = "UserWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button specialistBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button DataTimeBtn;
        private System.Windows.Forms.TextBox workerBox;
        private System.Windows.Forms.TextBox servicesBox;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
