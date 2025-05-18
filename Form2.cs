using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        bool flag;
        OracleConnection con;
        public Form2(bool flag1 = false)
        {
            InitializeComponent();
            flag = flag1;
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * FROM voters";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;

            con.Close();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateGrid();
            panel3.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO voters VALUES(" +  VoterID.Text +
            ",\'" + name.Text + "\',\'" + FathersOrHusbandsName.Text + "\',\'" + CNIC.Text 
            + "\',\'" + Address.Text + "\',\'" + ConstituencyID.Text + "\')";
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data Inserted Successfully!");

            con.Close();
            updateGrid();
            panel3.Visible=true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe; USER ID=project; PASSWORD=project";
            con = new OracleConnection(conStr);
            updateGrid();
            if (flag)
            {
                button7.Visible = false;
                panel3.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)//x button in insert panel
        {
            panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//x button in delete panel
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)//x button in display panel
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "UPDATE voters SET NAME = '" + name.Text + "', FathersOrHusbandsName = '" + FathersOrHusbandsName.Text + "', CNIC = '" + CNIC.Text + "', Address = '" + Address.Text + "', ConstituencyID = '" + ConstituencyID.Text + "' WHERE VoterID = " + VoterID.Text;
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data UPDATED Successfully!");
            con.Close();
            updateGrid();
            panel3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)//delete
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "DELETE FROM voters WHERE voterid =" + textBox1.Text.ToString();
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data DELETED Successfully!");
            con.Close();
            updateGrid();
            panel3.Visible = true;
        }
    }
}
