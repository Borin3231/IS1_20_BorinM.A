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
    public partial class AddEmployeeForm : Form
    {
        

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Получаем данные, введенные пользователем
            string name = metroTextBox1.Text;
            string post = metroTextBox2.Text;
            string address = metroTextBox3.Text;
            string phone = metroTextBox4.Text;
            string dostyp = metroTextBox5.Text;

            // Устанавливаем свойство DialogResult на значение DialogResult.OK
            this.DialogResult = DialogResult.OK;

            // Закрываем форму
            this.Close();
        }
    }
}
