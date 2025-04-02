using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_салона222
{
    public partial class UpdateUsers: Form
    {
        string ban;
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        public UpdateUsers()
        {
            InitializeComponent();
            //очищение боксов
            SelectUsBox.Items.Clear();
            RoleBox.Items.Clear();
            BanBox.Items.Clear();
            BanBox.Items.Add("Да");
            BanBox.Items.Add("Нет");
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //добавление вариантов для бокса с логинами
            while (reader.Read())
            {
                SelectUsBox.Items.Add(reader["login"].ToString());
            }
            connection.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = $"UPDATE users SET password = '{PasswordBox.Text}', role = '{RoleBox.Text}', ban = '{ban}' WHERE login = '{SelectUsBox.Text}';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("Информация пользователя обновлена!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectUsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = $"SELECT * FROM users;";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //заполнение ролей, если они не совпадают с теми, что уже есть в боксе
                if (!RoleBox.Items.Contains(reader["role"].ToString()))
                {
                    RoleBox.Items.Add(reader["role"].ToString());
                }
                //если логин из БД совпадает с выбранным, то поля заполняются данными
                if (reader["login"].ToString() == SelectUsBox.Text)
                {
                    PasswordBox.Text = reader["password"].ToString();
                    RoleBox.Text = reader["role"].ToString();
                    if (Convert.ToInt32(reader["ban"]) > 0)
                    {
                        BanBox.Text = "Нет";
                        ban = "3";
                    }
                    else
                    {
                        BanBox.Text = "Да";
                        ban = "0";
                    }
                }
            }
            connection.Close();
        }
    }
}
