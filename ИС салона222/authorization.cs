using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ИС_салон_красоты;
using ИС_салона222;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using System.Net;
namespace ИС_салон_красоты
{
    public partial class Autorization : Form

    {
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        string login;
        string password;
        int block = 3;
        int auth = 1;
        bool schet = true;
        public Autorization()
        {
            InitializeComponent();
            //закрытие других форм просле закрытия этой
            this.FormClosing += new FormClosingEventHandler(Autorization_FormClosing);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //проверка пустых полей
            login = loginBox.Text.Trim();
            password = passwordBox.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль обязательны для заполнения!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            //// читаем результат
            while (reader.Read())
            {
                //обработка ошибки
                try
                {
                    //если логин и пароль равны
                    if (reader["login"].ToString() == login && reader["password"].ToString() == password)
                    {
                        ID.value= reader["id"].ToString();
                        //если аккаунт забанен
                        if (reader["ban"].ToString() == "0")
                        {
                            MessageBox.Show("Этот аккаунт был заблокирован за чрезмерное количество неправильных попыток входа!\nОбратитесь к администратору.", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else //если не забанен
                        { // если роль читается как администратор
                            if (reader["role"].ToString() == "admin")
                            {
                                adminWin adm = new adminWin();
                                MessageBox.Show("Вы успешно авторизовались, администратор!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                adm.Show();
                                this.Hide();
                                return;
                            }
                            else //если читается роль пользователя, по желанию можно разнообразить теми же swithc case
                            {
                                UserWin user = new UserWin();
                                passwordChange pass = new passwordChange();
                                MessageBox.Show("Вы успешно авторизовались, пользователь!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (reader["auth"].ToString() == "0") //если это первая аутентификация(парметр равен нулю)
                                {
                                    pass.Show();
                                }
                                else//иначе просто открываем форму
                                {
                                    user.Show();
                                }
                                this.Hide();
                                return;
                            }
                        }

                    }
                    else if (reader["login"].ToString() == login && reader["password"].ToString() != password)
                    {
                        if (schet)//костыль первого совпадения
                        {
                            block = Convert.ToInt32(reader["ban"]);
                            schet = false;
                        }
                        //проверка на блокировку
                        block--;
                        if (block == 2)
                        {
                            MessageBox.Show("Логин или пароль введён неверно,осталось " + block + " попытки до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (block == 1)
                        {
                            MessageBox.Show("Логин или пароль введён неверно,осталась " + block + " попытка до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            loginBox.Enabled = false;
                            passwordBox.Enabled = false;
                            MessageBox.Show("Вы заблокированы. \nОбратитесь к администратору!", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        return;

                    }

                }
                //если что-то на этапах неудалось, выдает ошибку
                catch { MessageBox.Show("Проблема чтения с БД!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();

        }
        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            Application.Exit();
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            //создаем запрос обновления параметра бана и аутентификации
            string query = $"update users SET ban = {block}, auth = {auth} WHERE login = '{loginBox.Text}';";
            MySqlCommand command = new MySqlCommand(query, conn);
            // выполняем запрос
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
} 

