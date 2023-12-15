namespace CRUD
{
    partial class CandidateStudent
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
            label5 = new Label();
            txtPhone = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(468, 133);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(468, 98);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(468, 60);
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
            chkStatus.Location = new Point(551, 182);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 59;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(12, 162);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 57;
            label2.Text = "Gender";
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
            label1.Size = new Size(90, 20);
            label1.TabIndex = 55;
            label1.Text = "Contact Info";
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
            comboBox1.Location = new Point(178, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 67;
            comboBox1.ValueMember = "idStudent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 142);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 68;
            label4.Text = "Student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 25);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 61;
            label5.Text = "Nationality";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(178, 52);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 60;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 85);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 71;
            label6.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(323, 31);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 73;
            label7.Text = "Application";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "idStudent";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "5" });
            comboBox2.Location = new Point(323, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 72;
            comboBox2.ValueMember = "idStudent";
            // 
            // CandidateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(932, 501);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CandidateStudent";
            Text = "CandidateStudent";
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
        private Label label5;
        private TextBox txtPhone;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private ComboBox comboBox2;
    }
}