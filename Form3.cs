using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        bool flag;
        OracleConnection con;
        public Form3(bool flag = false)
        {
            InitializeComponent();
            this.flag = flag;
        }
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
            getEmps.CommandText = "Select * FROM Candidates";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;

            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//insert update button
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe; USER ID=project; PASSWORD=project";
            con = new OracleConnection(conStr);
            updateGrid();
            if (flag)
            {
                button9.Visible = false;
                panel3.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
            }
            else
                hideAll();
        }

        private void button3_Click(object sender, EventArgs e)//display panel button
        {
            panel3.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//delete panel button
        {
            panel3.Visible = false;
            panel2.Visible = true;
            panel1.Visible = true;
        }
        //X buttons:-
        private void button7_Click(object sender, EventArgs e) { hideAll(); }
        private void button8_Click(object sender, EventArgs e) { hideAll(); }
        private void button9_Click(object sender, EventArgs e) { hideAll(); }

        private void button6_Click(object sender, EventArgs e)//button to delete candidate
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "DELETE FROM Candidates WHERE CandidateID =" + textBox6.Text.ToString();
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data DELETED Successfully!");
            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO Candidates VALUES(" + textBox1.Text +
            ",\'" + textBox2.Text + "\',\'" + textBox3.Text + "\',\'" + textBox4.Text
            + "\',\'" + textBox5.Text + "\')"; 
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data Inserted Successfully!");

            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "UPDATE candidates SET NAME = '" + textBox2.Text + "', PartyAffiliation = '" + textBox3.Text + "', ElectionType = '" + textBox4.Text + "', ConstituencyID = '" + textBox5.Text + "' WHERE CandidateID = " + textBox1.Text;
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data UPDATED Successfully!");
            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }
    }
}
