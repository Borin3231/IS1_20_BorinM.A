using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;



namespace IS1_20_BorinM.A
{
    public partial class Personal : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        string connStr = "server=chuc.sdlik.ru;port=33333;user=st_1_20_4;database=is_1_20_st4_KURS;password=32006333;";
        DataTable dt = new DataTable();
        MySqlDataAdapter yyy = new MySqlDataAdapter();
        BindingSource aaa = new BindingSource();
        public Personal()
        {
            InitializeComponent();                  
        }
        public void kolonna()
        {
            try
            {
                dt.Clear();
                string jkl = "SELECT Staff.id_Staff AS 'ID',Staff.Name AS 'ФИО сотрудника',Staff.Post AS 'Должность',Staff.Addres AS 'Место проживания',Staff.Phone 'Телефон', Staff.Dostyp FROM Staff";
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
                dataGridView1.Columns[4].Visible = true;

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridView1.RowHeadersVisible = false;

                dataGridView1.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса: " + ex.Message);
                conn.Close();

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmploy = new AddEmployeeForm();
            if (addEmploy.ShowDialog() == DialogResult.OK)
            {

            }


        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void Personal_Load(object sender, EventArgs e)
        {
           conn = new MySqlConnection(connStr);
            kolonna();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmploy = new AddEmployeeForm();
            if (addEmploy.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
        
    


        

