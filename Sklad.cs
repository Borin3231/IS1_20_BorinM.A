using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS1_20_BorinM.A
{
    public partial class Sklad : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        string connStr = "server = chuc.sdlik.ru;port=33333;user=st_1_20_4;database=is_1_20_st4_KURS;password=32006333;";
        DataTable dt = new DataTable();
        MySqlDataAdapter yyy = new MySqlDataAdapter();
        BindingSource aaa = new BindingSource();
        public Sklad()
        {
            InitializeComponent();
        }
        private DataTable GetProducts()
        {
            string connStr = "SELECT Tovar.id_Tovara AS 'ID', Tovar.Product_name AS 'Название', Tovar.Price AS 'Цена', Tovar.Kolichestvo AS 'Количество' FROM Tovar";
            SqlConnection connection = new SqlConnection(connStr);
            // Создаем SQL-запрос для получения данных из базы данных
            MySqlCommand cmd = new MySqlCommand(connStr, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            return dt;
        }



        private void Prodazi_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            string jkl = "SELECT Tovar.id_Tovara AS 'ID', Tovar.Product_name AS 'Название', Tovar.Price AS 'Цена', Tovar.Kolichestvo AS 'Количество' FROM Tovar";
            conn.Open();
            yyy.SelectCommand = new MySqlCommand(jkl, conn);
            yyy.Fill(dt);
            aaa.DataSource = dt;
            dataGridView1.DataSource = aaa;
            conn.Close();
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            


            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
              {
                  string imagePath = dataGridView1.Rows[e.RowIndex].Cells["4"].Value.ToString();
                  pictureBox2.Image = Image.FromFile(imagePath);
             
        }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            string query = "DELETE FROM Tovar WHERE id_Tovara = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            dt = GetProducts();
            aaa.DataSource = dt;
            dataGridView1.DataSource = aaa;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string searchQuery = metroTextBox4.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                dt.DefaultView.RowFilter = $"Название LIKE '%{searchQuery}%'";
            }
            else
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                dt.DefaultView.RowFilter = $"[ФИО сотрудника] LIKE '%{searchQuery}%'";

            }
            else
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   string name = metroTextBox1.Text;
            decimal price = decimal.Parse(metroTextBox2.Text);
            int quantity = int.Parse(metroTextBox3.Text);

            string query = "INSERT INTO Tovar (Product_name, Price, Kolichestvo) VALUES (@name, @price, @quantity)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            dt = GetProducts();
            aaa.DataSource = dt;
            dataGridView1.DataSource = aaa; */
        }
    }
}

