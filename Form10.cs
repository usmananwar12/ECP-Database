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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        OracleConnection con;
        private void hideAll()
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * FROM ElectionOfficials";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe; USER ID=project; PASSWORD=project";
            con = new OracleConnection(conStr);
            updateGrid();
            hideAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO ElectionOfficials VALUES(" + textBox1.Text +
            ",\'" + textBox2.Text + "\',\'" + textBox3.Text + "\',\'" + textBox4.Text + "\')";
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data Inserted Successfully!");
            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "UPDATE ElectionOfficials SET Name = '" + textBox2.Text + "', Designation = '" + textBox3.Text + "', ContactNumber = '" + textBox4.Text + "' WHERE OfficialID = " + textBox1.Text;
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data UPDATED Successfully!");
            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "DELETE FROM ElectionOfficials WHERE OfficialID =" + textBox5.Text.ToString();
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data DELETED Successfully!");
            con.Close();
            updateGrid();
            panel3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
