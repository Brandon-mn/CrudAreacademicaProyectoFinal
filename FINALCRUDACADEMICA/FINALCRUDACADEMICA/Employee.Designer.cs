namespace CRUD
{
    partial class Employee
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            chkStatus = new CheckBox();
            label5 = new Label();
            txtgender = new TextBox();
            label3 = new Label();
            txtlastname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            label7 = new Label();
            txtphonenumer = new TextBox();
            label8 = new Label();
            txtmaritalstatus = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txthasprevious = new TextBox();
            label13 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(706, 78);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(706, 52);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(706, 24);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 63;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Location = new Point(706, 113);
            chkStatus.Margin = new Padding(3, 2, 3, 2);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(57, 19);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 10);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 61;
            label5.Text = "gender ";
            // 
            // txtgender
            // 
            txtgender.Location = new Point(173, 27);
            txtgender.Margin = new Padding(3, 2, 3, 2);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(110, 23);
            txtgender.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 59;
            label3.Text = "date of brith";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(27, 74);
            txtlastname.Margin = new Padding(3, 2, 3, 2);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(110, 23);
            txtlastname.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 54);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 57;
            label2.Text = "last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 55;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 27);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 160);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(747, 286);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 54);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 67;
            label4.Text = "address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(173, 71);
            txtaddress.Margin = new Padding(3, 2, 3, 2);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(110, 23);
            txtaddress.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 9);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 71;
            label6.Text = "email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(316, 27);
            txtemail.Margin = new Padding(3, 2, 3, 2);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(110, 23);
            txtemail.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 100);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 69;
            label7.Text = " phone numer";
            // 
            // txtphonenumer
            // 
            txtphonenumer.Location = new Point(173, 117);
            txtphonenumer.Margin = new Padding(3, 2, 3, 2);
            txtphonenumer.Name = "txtphonenumer";
            txtphonenumer.Size = new Size(110, 23);
            txtphonenumer.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 56);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 73;
            label8.Text = "marital status";
            // 
            // txtmaritalstatus
            // 
            txtmaritalstatus.Location = new Point(316, 74);
            txtmaritalstatus.Margin = new Padding(3, 2, 3, 2);
            txtmaritalstatus.Name = "txtmaritalstatus";
            txtmaritalstatus.Size = new Size(110, 23);
            txtmaritalstatus.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 99);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 75;
            label9.Text = "hire date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(451, 100);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 81;
            label10.Text = "idPosition";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(452, 56);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 79;
            label11.Text = "idContract";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(451, 9);
            label12.Name = "label12";
            label12.Size = new Size(130, 15);
            label12.TabIndex = 77;
            label12.Text = "hasPreviousExperiencie";
            // 
            // txthasprevious
            // 
            txthasprevious.Location = new Point(451, 27);
            txthasprevious.Margin = new Padding(3, 2, 3, 2);
            txthasprevious.Name = "txthasprevious";
            txthasprevious.Size = new Size(110, 23);
            txthasprevious.TabIndex = 76;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(590, 10);
            label13.Name = "label13";
            label13.Size = new Size(78, 15);
            label13.TabIndex = 83;
            label13.Text = "idApplication";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 84;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(310, 118);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(135, 23);
            dateTimePicker2.TabIndex = 85;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(451, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 86;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(451, 121);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 87;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(579, 28);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 88;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txthasprevious);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtmaritalstatus);
            Controls.Add(label6);
            Controls.Add(txtemail);
            Controls.Add(label7);
            Controls.Add(txtphonenumer);
            Controls.Add(label4);
            Controls.Add(txtaddress);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label5);
            Controls.Add(txtgender);
            Controls.Add(label3);
            Controls.Add(txtlastname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox chkStatus;
        private Label label5;
        private TextBox txtgender;
        private Label label3;
        private TextBox txtlastname;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtaddress;
        private Label label6;
        private TextBox txtemail;
        private Label label7;
        private TextBox txtphonenumer;
        private Label label8;
        private TextBox txtmaritalstatus;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txthasprevious;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}