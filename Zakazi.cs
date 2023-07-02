using DocumentFormat.OpenXml.Drawing;
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

namespace IS1_20_BorinM.A
{
    public partial class Zakazi : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        string connStr = "server = chuc.sdlik.ru;port=33333;user=st_1_20_4;database=is_1_20_st4_KURS;password=32006333;";
        DataTable dt = new DataTable();
        MySqlDataAdapter yyy = new MySqlDataAdapter();
        BindingSource aaa = new BindingSource();
        public Zakazi()
        {
            InitializeComponent();
        }
        private void Pokypki_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            string jkl = "SELECT Client.id_Client AS 'ID заказа', Client.Name AS 'ФИО клиента', Client.Addres AS 'Адрес', Client.Phone AS 'Телефон', Client.el_pochta AS 'Электронная почта', Client.Status_Zakaza AS 'Статус заказа' FROM Client";
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
        private void button5_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                dt.DefaultView.RowFilter = $"[ФИО клиента] LIKE '%{searchQuery}%'";

            }
            else
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Статус заказа")
            {
                if (e.Value != null && e.Value.ToString() == "Выполнено")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }

                else if (e.Value != null && e.Value.ToString() == "Отменено")
                {
                    e.CellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    

