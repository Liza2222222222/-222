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
    public partial class DelUsers: Form
    {
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        public DelUsers()
        {
            InitializeComponent();
            DelBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT * FROM users";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["login"].ToString();
                DelBox.Items.Add(name);
            }
            connection.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try//удачное удаление пользователя
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string qu = $"DELETE FROM users WHERE login = '{DelBox.Text}'";
                MySqlCommand comm = new MySqlCommand(qu, conn);
                MySqlDataReader read = comm.ExecuteReader();
                conn.Close();
                MessageBox.Show("Пользователь удален!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //обновление списка
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                string query = "SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DelBox.Items.Clear();
                while (reader.Read())
                {
                    string name = reader["login"].ToString();
                    DelBox.Items.Add(name);
                }
                connection.Close();
            }
            catch (Exception ex)//неудачное удаление пользователя
            {
                MessageBox.Show(ex.ToString(), "Ошибка подключения к БД!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
