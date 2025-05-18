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
    public partial class Form7 : Form
    {
        bool flag;
        public Form7(bool flag = false)
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
            panel4.Visible = false;
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * FROM Votes";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            
            con.Close();
        }

        private void updateGrid1()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * FROM OnlineVotes";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView2.DataSource = empDT;

            con.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Form7_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe; USER ID=project; PASSWORD=project";
            con = new OracleConnection(conStr);
            updateGrid();
            updateGrid1();
            if (flag)
            {
                button6.Visible = false;
                panel3.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
            }
            else
                hideAll();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.ShowUpDown = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertSchedule = con.CreateCommand(); 
            insertSchedule.CommandText = "INSERT INTO Votes VALUES(" + textBox1.Text +
            ",\'" + textBox2.Text + "\',\'" + textBox3.Text + "\',\'" + textBox4.Text
            + "\', TO_TIMESTAMP(\'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker1.Value.ToString("HH:mm:ss") + "\', 'YYYY-MM-DD HH24:MI:SS'))";
            insertSchedule.CommandType = CommandType.Text;
            int rows = insertSchedule.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data Inserted Successfully!");

            con.Close();
            updateGrid();
            panel3.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "UPDATE votes SET VoterID = '" + textBox2.Text + "', CandidateID = '" + textBox3.Text + "', PollingStationID = '" + textBox4.Text + "', VoteDateTime = TO_TIMESTAMP(\'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker1.Value.ToString("HH:mm:ss") + "\', 'YYYY-MM-DD HH24:MI:SS') WHERE VoteID = " + textBox1.Text;
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
            if (radioButton1.Checked)
                insertEmp.CommandText = "DELETE FROM votes WHERE VoteID =" + textBox6.Text.ToString();
            else
                insertEmp.CommandText = "DELETE FROM OnlineVotes WHERE VoteID =" + textBox6.Text.ToString();
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data DELETED Successfully!");
            con.Close();
            updateGrid1();
            updateGrid();
            panel3.Visible = true;
            if (radioButton1.Checked)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
            else
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                panel1.Visible = true;
            else if (radioButton2.Checked)
                panel4.Visible = true;
            else
                MessageBox.Show("Please select vote type!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            if (radioButton1.Checked) { 
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
            else
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
            }
        }

        private void polingstation_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(true);
            f5.ShowDialog();
        }

        private void cadidate_Click(object sender, EventArgs e)
        {
            Form3 f5 = new Form3(true);
            f5.ShowDialog();
        }

        private void voter_Click(object sender, EventArgs e)
        {
            Form2 f5 = new Form2(true);
            f5.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void button8_Click(object sender, EventArgs e)//insert for online votes
        {
            con.Open();
            OracleCommand insertSchedule = con.CreateCommand();
            insertSchedule.CommandText = "INSERT INTO OnlineVotes VALUES(" + voteid.Text +
                        ",\'" + voterid.Text + "\',\'" + candidateid.Text + "\', TO_TIMESTAMP(\'" + dateTimePicker3.Value.ToString("yyyy-MM-dd")
                        + " " + dateTimePicker4.Value.ToString("HH:mm:ss") + "\', 'YYYY-MM-DD HH24:MI:SS'), \'" + ip.Text + "\')";

            insertSchedule.CommandType = CommandType.Text;
            int rows = insertSchedule.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data Inserted Successfully!");

            con.Close();
            updateGrid1();
            panel3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)//update for online
        {
            con.Open(); 
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "UPDATE OnlineVotes SET VoterID = '" + voterid.Text + "', CandidateID = '" + candidateid.Text + "', IP_Address = '" + ip.Text + "', VoteDateTime = TO_TIMESTAMP(\'" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker4.Value.ToString("HH:mm:ss") + "\', 'YYYY-MM-DD HH24:MI:SS') WHERE VoteID = " + voteid.Text;
            insertEmp.CommandType = CommandType.Text;
            int rows = insertEmp.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Data UPDATED Successfully!");
            con.Close();
            updateGrid1();
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)//voterclick
        {
            Form2 f5 = new Form2(true);
            f5.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)//cadidtae click
        {
            Form3 f5 = new Form3(true);
            f5.ShowDialog();
        }
    }
}
