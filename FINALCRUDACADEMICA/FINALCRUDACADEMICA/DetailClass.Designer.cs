namespace CRUD
{
    partial class DetailClass
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
            label4 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            chkStatus = new CheckBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 18);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 83;
            label4.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "idStudent";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5" });
            comboBox1.Location = new Point(166, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 82;
            comboBox1.ValueMember = "idStudent";
            // 
            // button3
            // 
            button3.Location = new Point(306, 123);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 80;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(306, 88);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 79;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(306, 50);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 78;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Location = new Point(186, 96);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 77;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 72;
            label2.Text = "startTime";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 41);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 70;
            label1.Text = "days";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(854, 382);
            dataGridView1.TabIndex = 69;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 127);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 84;
            label5.Text = "endTime";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 85;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 86;
            // 
            // DetailClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(903, 624);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
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
            Name = "DetailClass";
            Text = "Detail Class";
            Load += AcademicDiploma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox chkStatus;
        private Label label2;
        private TextBox txtDescription;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}