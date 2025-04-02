namespace ИС_салон_красоты

{
    partial class Autorization
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labPassword = new System.Windows.Forms.Label();
            this.labLogin = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.log_in_system = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.labPassword);
            this.groupBox1.Controls.Add(this.labLogin);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.loginBox);
            this.groupBox1.Controls.Add(this.log_in_system);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(57, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLogin.Location = new System.Drawing.Point(198, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 49);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labPassword.Location = new System.Drawing.Point(112, 208);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(70, 22);
            this.labPassword.TabIndex = 6;
            this.labPassword.Text = "Пароль";
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labLogin.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labLogin.Location = new System.Drawing.Point(112, 114);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(60, 22);
            this.labLogin.TabIndex = 5;
            this.labLogin.Text = "Логин";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(198, 205);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(166, 30);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(198, 111);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(166, 30);
            this.loginBox.TabIndex = 3;
            // 
            // log_in_system
            // 
            this.log_in_system.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_in_system.AutoSize = true;
            this.log_in_system.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_in_system.ForeColor = System.Drawing.Color.LightSlateGray;
            this.log_in_system.Location = new System.Drawing.Point(75, 26);
            this.log_in_system.Name = "log_in_system";
            this.log_in_system.Size = new System.Drawing.Size(390, 44);
            this.log_in_system.TabIndex = 2;
            this.log_in_system.Text = "Войдите в систему!";
            // 
            // Autorization
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(647, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно авторизации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autorization_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label log_in_system;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}
