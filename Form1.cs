using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(false);
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f5 = new Form6();
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f5 = new Form7();
            f5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f5 = new Form8();
            f5.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form9 f5 = new Form9();
            f5.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 f5 = new Form10();
            f5.ShowDialog();
        }
    }
}
