namespace CRUD
{
    partial class Class
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtStudentId = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(302, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(302, 85);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(302, 47);
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
            chkStatus.Location = new Point(157, 98);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 57;
            label2.Text = "idEmployee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 55;
            label1.Text = "idGroup";
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
            comboBox1.Location = new Point(12, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 67;
            comboBox1.ValueMember = "idStudent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 68;
            label4.Text = "idSubject";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 25);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 73;
            label7.Text = "idClassroom";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "idStudent";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "5" });
            comboBox2.Location = new Point(157, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 72;
            comboBox2.ValueMember = "idStudent";
            // 
            // comboBox3
            // 
            comboBox3.DisplayMember = "idStudent";
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "5" });
            comboBox3.Location = new Point(12, 101);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(125, 28);
            comboBox3.TabIndex = 74;
            comboBox3.ValueMember = "idStudent";
            // 
            // comboBox4
            // 
            comboBox4.DisplayMember = "idStudent";
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "5" });
            comboBox4.Location = new Point(12, 47);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(125, 28);
            comboBox4.TabIndex = 75;
            comboBox4.ValueMember = "idStudent";
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(894, 606);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Class";
            Text = "Class";
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
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtStudentId;
        private ComboBox comboBox1;
        private Label label4;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}