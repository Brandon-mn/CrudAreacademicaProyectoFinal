namespace CRUD
{
    partial class Event
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
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(549, 87);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 65;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(549, 52);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(549, 15);
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
            chkStatus.Location = new Point(549, 133);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 62;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 13);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 61;
            label5.Text = "end date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 57;
            label2.Text = "start date";
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
            dataGridView1.Location = new Point(14, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 381);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 72);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 67;
            label4.Text = "description";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(198, 95);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(125, 27);
            txtaddress.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 12);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 71;
            label6.Text = "location";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(361, 36);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 70;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 96);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 27);
            dateTimePicker1.TabIndex = 85;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(198, 37);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(154, 27);
            dateTimePicker2.TabIndex = 86;
            // 
            // Event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(txtaddress);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Event";
            Text = "Event";
            Load += Event_Load;
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
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtaddress;
        private Label label6;
        private TextBox txtemail;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}