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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Personal form2 = new Personal(); // создаем экземпляр формы Form2
            form2.ShowDialog(); // отображаем форму Form2 как модальное окно
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sklad form2 = new Sklad(); // создаем экземпляр формы Form2
            form2.ShowDialog(); // отображаем форму Form2 как модальное окно
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personal form2 = new Personal(); // создаем экземпляр формы Form2
            form2.ShowDialog(); // отображаем форму Form2 как модальное окно
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zakazi form2 = new Zakazi(); // создаем экземпляр формы Form2
            form2.ShowDialog(); // отображаем форму Form2 как модальное окно
        }
    }
}
