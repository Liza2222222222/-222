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
    public partial class AddUsers: Form
    {
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        public AddUsers()
        {
            InitializeComponent();
            RoleBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT distinct role FROM users";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["role"].ToString();
                RoleBox.Items.Add(name);
            }
            connection.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into users (name,surname,number,role,login, password, ban, auth) value ('{NameBox.Text}','{SurnameBox.Text}','{NumberBox.Text}','{RoleBox.Text}','{LogBox.Text}', '{PassBox.Text}', 3, 0);;";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый пользватель добавлен!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось добавить нового пользователя!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
