namespace CRUD
{
    partial class Department
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
            label3 = new Label();
            txtDirector = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtStudentId = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtLocation = new TextBox();
            txtClosingHour = new TextBox();
            txtOpeningHour = new TextBox();
            label5 = new Label();
            label10 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(645, 142);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(645, 107);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(645, 69);
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
            chkStatus.Location = new Point(501, 85);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 59;
            label3.Text = "Director";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(12, 156);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 57;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 101);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 55;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(854, 382);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(0, 0);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 27);
            txtStudentId.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "idStudent";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5" });
            comboBox1.Location = new Point(495, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 67;
            comboBox1.ValueMember = "idStudent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 25);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 68;
            label4.Text = "Employee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 85);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 71;
            label6.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(178, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 70;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(178, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 25);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 88;
            label8.Text = "FoundingDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 142);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 91;
            label7.Text = "Email";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(337, 27);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 93;
            label9.Text = "Location";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(337, 50);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 92;
            // 
            // txtClosingHour
            // 
            txtClosingHour.Location = new Point(337, 164);
            txtClosingHour.Name = "txtClosingHour";
            txtClosingHour.Size = new Size(125, 27);
            txtClosingHour.TabIndex = 97;
            // 
            // txtOpeningHour
            // 
            txtOpeningHour.Location = new Point(337, 110);
            txtOpeningHour.Name = "txtOpeningHour";
            txtOpeningHour.Size = new Size(125, 27);
            txtOpeningHour.TabIndex = 96;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 141);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 95;
            label5.Text = "ClosingHour";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(337, 85);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 94;
            label10.Text = "OpeningHour";
            // 
            // txtName
            // 
            txtName.Location = new Point(10, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 27);
            txtName.TabIndex = 98;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(178, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 99;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(925, 621);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtClosingHour);
            Controls.Add(txtOpeningHour);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtLocation);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Department";
            Text = "Department";
            Load += AcademicAward_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox chkStatus;
        private Label label3;
        private TextBox txtDirector;
        private Label label2;
        private TextBox txtDescription;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtStudentId;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox txtPhone;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private TextBox textBox3;
        private Label label9;
        private TextBox txtLocation;
        private TextBox txtClosingHour;
        private TextBox txtOpeningHour;
        private Label label5;
        private Label label10;
        private TextBox txtName;
        private TextBox txtEmail;
    }
}