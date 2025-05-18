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
    public partial class Form5 : Form
    {
        bool flag;
        OracleConnection con;
        public Form5(bool flag1)
        {
            InitializeComponent();
            flag = flag1; 
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
            getEmps.CommandText = "Select * FROM PollingStations";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)//insert/updtae
        {
            panel1.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe; USER ID=project; PASSWORD=project";
            con = new OracleConnection(conStr);
            updateGrid();
            if (flag)
            {
                button4.Visible = false;
                panel3.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
            }
            else
                hideAll();
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)//display
        {
            panel3.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO PollingStations VALUES(" + textBox1.Text +
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
            insertEmp.CommandText = "UPDATE PollingStations SET ConstituencyID = '" + textBox2.Text + "', PollingStationName = '" + textBox3.Text + "', Location = '" + textBox4.Text + "', StaffCount = '" + textBox5.Text + "' WHERE PollingStationID = " + textBox1.Text;
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
            insertEmp.CommandText = "DELETE FROM PollingStations WHERE PollingStationID =" + textBox6.Text.ToString();
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data DELETED Successfully!");
            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideAll();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
