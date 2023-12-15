namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtDirector = new TextBox();
            Label4 = new Label();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtLocation = new TextBox();
            label8 = new Label();
            label9 = new Label();
            chkStatus = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(950, 382);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 106);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 6;
            label3.Text = "Director";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(12, 167);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 5;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(12, 216);
            Label4.Name = "Label4";
            Label4.Size = new Size(107, 20);
            Label4.TabIndex = 8;
            Label4.Text = "Founding Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 24);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(178, 47);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 83);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(178, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 144);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 15;
            label7.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(178, 167);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 216);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 17;
            label8.Text = "Opening Hour";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(337, 24);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 19;
            label9.Text = "Closing Hour";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(337, 109);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 24;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(495, 45);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(495, 83);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 26;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(337, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(99, 27);
            dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(12, 239);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(99, 27);
            dateTimePicker3.TabIndex = 28;
            // 
            // button3
            // 
            button3.Location = new Point(495, 118);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 29;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(868, 237);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 30;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 666);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtLocation);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(Label4);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Department";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtDirector;
        private Label Label4;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtLocation;
        private Label label8;
        private Label label9;
        private CheckBox chkStatus;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Button button3;
        private Button button4;
    }
}