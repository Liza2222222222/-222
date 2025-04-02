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
using ИС_салон_красоты;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ИС_салона222
{
    public partial class UserWin : Form
    {
        public UserWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = $"select name, surname, number from users where id = {ID.value}";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                name = reader["name"].ToString();
                surname = reader["surname"].ToString();
                number = reader["number"].ToString();
            }
        }
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        string stat;
        string name;
        string surname;
        string number;
        void ShowClienttInGrid(string comm)//шаблон показа таблиц
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = comm;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void BtnAuthorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization form1 = new Autorization();
            form1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void specialistBtn_Click(object sender, EventArgs e)
        {
            
            //вывод строк специалистов со значением айди услуги, выбранной в предыдущем шаге, ID выясняется либо посредством запроса по названию, либо записывается изначально
            stat = "worker";
            try
            {

                ShowClienttInGrid("select id, name,post from worker;");
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void DataTimeBtn_Click(object sender, EventArgs e)
        {
            //вывести даты из таблицы, где статус "запланировано", добавить пометку, что пользователь может записать любую дату, кроме этой
            label3.Visible = true;
            stat = "sign_up";
            try
            {

                ShowClienttInGrid("SELECT worker, data_time FROM sign_up");
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            //Вызываем таблицу услуги 
            //если это возможно, то при нажатии на ячейку записывать ID  в отдельную переменную, чтобы после по ней делать поиск
            

            stat = "services";
            try
            {

                ShowClienttInGrid("select id, name,description from services;");
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                switch (stat)
                {
                    case "services":

                        var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string value = cell.Value?.ToString() ?? "Пусто";
                        servicesBox.Text = $"{value}";
                        return;
                    case "worker":
                        var celll = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string valuee = celll.Value?.ToString() ?? "Пусто";
                       workerBox.Text = $"{valuee}";
                        return;
                    

                }
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(servicesBox.Text) ||
        string.IsNullOrWhiteSpace(workerBox.Text) ||
        string.IsNullOrWhiteSpace(dataTimeBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into sign_up (services, worker, data_time) value ('{servicesBox.Text}', '{workerBox.Text}', '{dataTimeBox.Text}');";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новая запись создана!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось создать новую запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            servicesBox.Clear();
            workerBox.Clear();
            dataTimeBox.Clear();
            
        }
    }
}
    



