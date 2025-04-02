using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ИС_салон_красоты;

namespace ИС_салона222
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorization());
        }
        public static class DatabaseHelper
        {
            // Общая строка подключения
            public static string ConnectionString { get; set; } = "Server=localhost;Port=3306;Database=salon222;Username=root;Password=root;";
            public static void SaveChanges(DataGridView dataGridView, string tableName)
            {
                try
                {
                    if (dataGridView.DataSource is DataTable dataTable)
                    {
                        using (var connection = new MySqlConnection(ConnectionString))
                        {
                            string query = $"SELECT * FROM `{tableName}`";
                            var adapter = new MySqlDataAdapter(query, connection);
                            var commandBuilder = new MySqlCommandBuilder(adapter);
                            adapter.Update(dataTable);
                        }

                    }
                    MessageBox.Show("Данные успешно сохранены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void LoadDataIntoGrid(DataGridView dataGridView, string tableName)
            {
                try
                {
                    using (var connection = new MySqlConnection(ConnectionString))
                    {
                        string query = $"SELECT * FROM `{tableName}`";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.Invoke((MethodInvoker)delegate
                        {
                            dataGridView.DataSource = dataTable;
                        });
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
    static class ID
    {
        public static string value { get; set; }
    }
}
