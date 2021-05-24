using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Головне меню";
        }

        private void runForm1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 runform1 = new Form1();
            runform1.ShowDialog();
            Close();
        }

        private void runForm2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 runform2 = new Form2();
            runform2.ShowDialog();
            Close();
        }

        private void runForm3_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 runform3 = new Form3();
            runform3.ShowDialog();
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
