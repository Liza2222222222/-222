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
using ИС_салон_красоты;
using static ИС_салона222.Program;

namespace ИС_салона222
{
    public partial class adminWin : Form
    {
        public adminWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        string connStr = "server=localhost;user=root;database=salon222;password=root;";
        string glob;
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
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization form1 = new Autorization();
            form1.Show();
        }

      

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //pictureBox1.Visible = false;
            //panel1.Visible = false;
            //dataGridView1.Visible = true;
            //SaveBtn.Visible = true;
            glob = "services";
            try
            {

                DatabaseHelper.LoadDataIntoGrid(dataGridView1, "services");
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //pictureBox1.Visible = false;
            //panel1.Visible = false;
            //dataGridView1.Visible = true;
            //SaveBtn.Visible = true;
            glob = "worker";
            try
            {

                DatabaseHelper.LoadDataIntoGrid(dataGridView1,"worker");
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = true;
            //pictureBox1.Visible = true;
            //panel1.Visible = true;
            //dataGridView1.Visible = false;
            //SaveBtn.Visible = false;
            AddUsers add = new AddUsers();
            add.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = true;
            //pictureBox1.Visible = true;
            //panel1.Visible = true;
            //dataGridView1.Visible = false;
            //SaveBtn.Visible = false;
            DelUsers del = new DelUsers();
            del.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = true;
            //pictureBox1.Visible = true;
            //panel1.Visible = true;
            //dataGridView1.Visible = false;
            //SaveBtn.Visible = false;
            UpdateUsers upd = new UpdateUsers();
            upd.ShowDialog();
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //pictureBox1.Visible = false;
            //panel1.Visible = false;
            //dataGridView1.Visible = true;
            //SaveBtn.Visible = false;
            try
            {
                ShowClienttInGrid("SELECT * FROM users");
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void записьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //pictureBox1.Visible = false;
            //panel1.Visible = false;
            //SaveBtn.Visible = true;
            glob = "sign_up";
            try
            {
                DatabaseHelper.LoadDataIntoGrid(dataGridView1, "sign_up");
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DatabaseHelper.SaveChanges(dataGridView1, glob);
            
        }
    }
}



