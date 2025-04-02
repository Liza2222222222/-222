using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ИС_салона222
{
    public partial class passwordChange: Form
    {
        public passwordChange()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(passwordChange_FormClosing);
        }
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        string oldPass;
        string newPass;
        string appPass;

        private void passwordChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = $"UPDATE users SET password = '{newBox2.Text}' WHERE id = '{ID.value}';";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();

        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
           if(newPass == appPass)
           {
                adminWin admin = new adminWin();
                UserWin user = new UserWin();
                // строка подключения к БД
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                // запрос
                string sql = "SELECT * FROM users";
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(sql, conn);
                // объект для чтения ответа сервера
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while(reader.Read())
                    {
                    if (oldPass == reader["password"].ToString() && reader["id"].ToString() == ID.value)
                    {
                        if (reader["role"].ToString() == "client")
                        {
                            user.Show();
                            this.Hide();
                            return;
                        } 
                        else if (reader["role"].ToString() == "admin")
                        {
                            admin.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Неизвестная роль!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                MessageBox.Show("Такого пароля не существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close(); // закрываем reader
                                // закрываем соединение с БД
                conn.Close();
           }

        }

        private void appBox3_TextChanged(object sender, EventArgs e)
        {
            appPass = appBox3.Text;
            if (newPass != appPass) { warningLbl.Text = "Введенный пароль не совпадает с новым!"; }
            else { warningLbl.Text = ""; }
        }

        private void newBox2_TextChanged(object sender, EventArgs e)
        {
            newPass = newBox2.Text;
        }

        private void oldBox1_TextChanged(object sender, EventArgs e)
        {
            oldPass = oldBox1.Text;
        }
    }
}
