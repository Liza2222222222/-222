namespace ИС_салона222
{
    partial class passwordChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.appBox3 = new System.Windows.Forms.TextBox();
            this.newBox2 = new System.Windows.Forms.TextBox();
            this.oldBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.warningLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.warningLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChangePassword);
            this.groupBox1.Controls.Add(this.appBox3);
            this.groupBox1.Controls.Add(this.newBox2);
            this.groupBox1.Controls.Add(this.oldBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(44, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Измените выданный пароль";
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.ChangePassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.ChangePassword.Location = new System.Drawing.Point(93, 353);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(172, 64);
            this.ChangePassword.TabIndex = 3;
            this.ChangePassword.Text = "Изменить";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // appBox3
            // 
            this.appBox3.Location = new System.Drawing.Point(78, 289);
            this.appBox3.Name = "appBox3";
            this.appBox3.Size = new System.Drawing.Size(205, 23);
            this.appBox3.TabIndex = 2;
            this.appBox3.TextChanged += new System.EventHandler(this.appBox3_TextChanged);
            // 
            // newBox2
            // 
            this.newBox2.Location = new System.Drawing.Point(78, 181);
            this.newBox2.Name = "newBox2";
            this.newBox2.Size = new System.Drawing.Size(205, 23);
            this.newBox2.TabIndex = 1;
            this.newBox2.TextChanged += new System.EventHandler(this.newBox2_TextChanged);
            // 
            // oldBox1
            // 
            this.oldBox1.Location = new System.Drawing.Point(78, 71);
            this.oldBox1.Name = "oldBox1";
            this.oldBox1.Size = new System.Drawing.Size(205, 23);
            this.oldBox1.TabIndex = 0;
            this.oldBox1.TextChanged += new System.EventHandler(this.oldBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите старый пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите новый пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Подтвертите новый пароль:";
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.Location = new System.Drawing.Point(75, 315);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(0, 17);
            this.warningLbl.TabIndex = 7;
            // 
            // passwordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "passwordChange";
            this.Text = "Смена пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.passwordChange_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.TextBox appBox3;
        private System.Windows.Forms.TextBox newBox2;
        private System.Windows.Forms.TextBox oldBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warningLbl;
    }
}