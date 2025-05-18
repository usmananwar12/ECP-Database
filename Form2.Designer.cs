namespace WindowsFormsApp5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.VoterID = new System.Windows.Forms.TextBox();
            this.Voter = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.FHName = new System.Windows.Forms.Label();
            this.CNIClabel = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.ConID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FathersOrHusbandsName = new System.Windows.Forms.TextBox();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.ConstituencyID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(413, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 43);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Voter";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(261, 395);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 43);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Voter";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // VoterID
            // 
            this.VoterID.Location = new System.Drawing.Point(347, 32);
            this.VoterID.Name = "VoterID";
            this.VoterID.Size = new System.Drawing.Size(373, 26);
            this.VoterID.TabIndex = 3;
            // 
            // Voter
            // 
            this.Voter.AutoSize = true;
            this.Voter.BackColor = System.Drawing.Color.Transparent;
            this.Voter.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voter.ForeColor = System.Drawing.Color.White;
            this.Voter.Location = new System.Drawing.Point(77, 32);
            this.Voter.Name = "Voter";
            this.Voter.Size = new System.Drawing.Size(84, 21);
            this.Voter.TabIndex = 7;
            this.Voter.Text = "VoterID";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.White;
            this.Namelabel.Location = new System.Drawing.Point(77, 98);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(60, 21);
            this.Namelabel.TabIndex = 8;
            this.Namelabel.Text = "Name";
            // 
            // FHName
            // 
            this.FHName.AutoSize = true;
            this.FHName.BackColor = System.Drawing.Color.Transparent;
            this.FHName.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHName.ForeColor = System.Drawing.Color.White;
            this.FHName.Location = new System.Drawing.Point(77, 154);
            this.FHName.Name = "FHName";
            this.FHName.Size = new System.Drawing.Size(243, 21);
            this.FHName.TabIndex = 9;
            this.FHName.Text = "FathersOrHusbandsName";
            // 
            // CNIClabel
            // 
            this.CNIClabel.AutoSize = true;
            this.CNIClabel.BackColor = System.Drawing.Color.Transparent;
            this.CNIClabel.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIClabel.ForeColor = System.Drawing.Color.White;
            this.CNIClabel.Location = new System.Drawing.Point(77, 209);
            this.CNIClabel.Name = "CNIClabel";
            this.CNIClabel.Size = new System.Drawing.Size(63, 21);
            this.CNIClabel.TabIndex = 10;
            this.CNIClabel.Text = "CNIC";
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(77, 264);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 21);
            this.Add.TabIndex = 11;
            this.Add.Text = "Address";
            // 
            // ConID
            // 
            this.ConID.AutoSize = true;
            this.ConID.BackColor = System.Drawing.Color.Transparent;
            this.ConID.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConID.ForeColor = System.Drawing.Color.White;
            this.ConID.Location = new System.Drawing.Point(77, 331);
            this.ConID.Name = "ConID";
            this.ConID.Size = new System.Drawing.Size(155, 21);
            this.ConID.TabIndex = 12;
            this.ConID.Text = "Constituency ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 468);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Voter ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete Voter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(752, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 131);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(-1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 459);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(755, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 33);
            this.button7.TabIndex = 2;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(804, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(807, 131);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ConID);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.CNIClabel);
            this.panel1.Controls.Add(this.FHName);
            this.panel1.Controls.Add(this.Namelabel);
            this.panel1.Controls.Add(this.Voter);
            this.panel1.Controls.Add(this.FathersOrHusbandsName);
            this.panel1.Controls.Add(this.CNIC);
            this.panel1.Controls.Add(this.VoterID);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.ConstituencyID);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 455);
            this.panel1.TabIndex = 1;
            // 
            // FathersOrHusbandsName
            // 
            this.FathersOrHusbandsName.Location = new System.Drawing.Point(347, 151);
            this.FathersOrHusbandsName.Name = "FathersOrHusbandsName";
            this.FathersOrHusbandsName.Size = new System.Drawing.Size(373, 26);
            this.FathersOrHusbandsName.TabIndex = 5;
            // 
            // CNIC
            // 
            this.CNIC.Location = new System.Drawing.Point(347, 206);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(373, 26);
            this.CNIC.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(347, 264);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(373, 26);
            this.Address.TabIndex = 2;
            // 
            // ConstituencyID
            // 
            this.ConstituencyID.Location = new System.Drawing.Point(347, 328);
            this.ConstituencyID.Name = "ConstituencyID";
            this.ConstituencyID.Size = new System.Drawing.Size(373, 26);
            this.ConstituencyID.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(347, 86);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(373, 26);
            this.name.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(746, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(528, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Display";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(308, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(69, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Insert/Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Voter";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox VoterID;
        private System.Windows.Forms.Label Voter;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label FHName;
        private System.Windows.Forms.Label CNIClabel;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label ConID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FathersOrHusbandsName;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox ConstituencyID;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}