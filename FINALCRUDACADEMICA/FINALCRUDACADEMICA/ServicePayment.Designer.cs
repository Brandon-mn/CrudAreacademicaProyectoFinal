namespace CRUD
{
    partial class ServicePayment
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
            txtlastname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 133);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 59;
            label3.Text = "pamentmethod";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(31, 156);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(125, 27);
            txtlastname.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 57;
            label2.Text = "paymentdate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 13);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 55;
            label1.Text = "Amount";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(201, 137);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 81;
            label10.Text = "idService";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(202, 79);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 79;
            label11.Text = "idapplication";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 96);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 27);
            dateTimePicker1.TabIndex = 84;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(201, 99);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 86;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(201, 165);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 87;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 7);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 88;
            label4.Text = "bank";
            // 
            // ServicePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label3);
            Controls.Add(txtlastname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServicePayment";
            Text = "ServicePayment";
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
        private Label label3;
        private TextBox txtlastname;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label4;
    }
}