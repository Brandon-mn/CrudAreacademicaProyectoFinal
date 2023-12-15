namespace CRUD
{
    partial class Kardex
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
            txtDescription = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtStudentId = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(327, 151);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(327, 116);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(327, 78);
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
            chkStatus.Location = new Point(173, 156);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 57;
            label2.Text = "Name";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 112);
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
            label1.Text = "Grade";
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
            comboBox1.Location = new Point(157, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 67;
            comboBox1.ValueMember = "idStudent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 68;
            label4.Text = "idStudent";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 89);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 73;
            label7.Text = "idClass";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "idStudent";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "5" });
            comboBox2.Location = new Point(157, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 72;
            comboBox2.ValueMember = "idStudent";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 83;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 82;
            label3.Text = "Date";
            // 
            // Kardex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(894, 606);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Kardex";
            Text = "Kardex";
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
        private TextBox txtDescription;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtStudentId;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private Label label7;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}