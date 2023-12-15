namespace CRUD
{
    partial class Student
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
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(807, 104);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(807, 69);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(807, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
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
            chkStatus.Location = new Point(807, 151);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 135);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 61;
            label5.Text = "middle name";
            // 
            // txtgender
            // 
            txtgender.Location = new Point(31, 157);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(125, 27);
            txtgender.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 13);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 59;
            label3.Text = "date of brith";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(31, 99);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(125, 27);
            txtlastname.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 57;
            label2.Text = "last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 55;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 381);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 135);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 67;
            label4.Text = "address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(198, 157);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(125, 27);
            txtaddress.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 12);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 71;
            label6.Text = "phone numer";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(361, 36);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 81);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 69;
            label7.Text = "gender";
            // 
            // txtphonenumer
            // 
            txtphonenumer.Location = new Point(198, 105);
            txtphonenumer.Name = "txtphonenumer";
            txtphonenumer.Size = new Size(125, 27);
            txtphonenumer.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 75);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 73;
            label8.Text = "email";
            // 
            // txtmaritalstatus
            // 
            txtmaritalstatus.Location = new Point(361, 99);
            txtmaritalstatus.Name = "txtmaritalstatus";
            txtmaritalstatus.Size = new Size(125, 27);
            txtmaritalstatus.TabIndex = 72;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 137);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 79;
            label11.Text = "idplan";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(198, 37);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 27);
            dateTimePicker1.TabIndex = 84;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(361, 157);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 86;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label11);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Student";
            Text = "Student";
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
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}