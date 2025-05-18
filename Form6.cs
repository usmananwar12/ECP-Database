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
    public partial class Form6 : Form
    {
        bool flag;
        public Form6(bool flag = false)
        {
            InitializeComponent();
            this.flag = flag;
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
            getEmps.CommandText = "Select * FROM ElectionSchedule";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe; USER ID=project; PASSWORD=project";
            con = new OracleConnection(conStr);
            updateGrid();
            if (flag)
            {
                button6.Visible = false;
                panel3.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
            }
            else
                hideAll();
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
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertSchedule = con.CreateCommand(); insertSchedule.CommandText = "INSERT INTO ElectionSchedule VALUES(" + textBox1.Text +
            ",\'" + textBox2.Text + "\', TO_DATE(\'" + dateTimePicker1.Value.ToString("dd-MMM-yyyy") + "\', 'DD-MON-YYYY'), TO_DATE(\'" + dateTimePicker2.Value.ToString("dd-MMM-yyyy")
            + "\', 'DD-MON-YYYY'), TO_DATE(\'" + dateTimePicker3.Value.ToString("dd-MMM-yyyy") + "\', 'DD-MON-YYYY'))";


            insertSchedule.CommandType = CommandType.Text;
            int rows = insertSchedule.ExecuteNonQuery();
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
            insertEmp.CommandText = "UPDATE ElectionSchedule SET ElectionType = '" + textBox2.Text + "', ElectionDate = TO_DATE(\'" + dateTimePicker1.Value.ToString("dd-MMM-yyyy") + "\', 'DD-MON-YYYY'), NominationDeadline = TO_DATE(\'" + dateTimePicker2.Value.ToString("dd-MMM-yyyy") + "\', 'DD-MON-YYYY'), PollingDate = TO_DATE(\'" + dateTimePicker3.Value.ToString("dd-MMM-yyyy") + "\', 'DD-MON-YYYY') WHERE ElectionID = " + textBox1.Text;
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
            insertEmp.CommandText = "DELETE FROM ElectionSchedule WHERE ElectionID =" + textBox6.Text.ToString();
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data DELETED Successfully!");
            con.Close();
            updateGrid();
            panel2.Visible = true;
            panel3.Visible = true;
        }

    }
}
