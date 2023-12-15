namespace CRUD
{
    partial class Contract
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
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            chkStatus = new CheckBox();
            txtDirector = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(854, 382);
            dataGridView1.TabIndex = 54;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(36, 111);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 89;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 86);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 88;
            label5.Text = "endDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 87;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 22);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 86;
            label2.Text = "startDate";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Location = new Point(335, 120);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 92;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            chkStatus.CheckedChanged += chkStatus_CheckedChanged;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(188, 49);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 91;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(188, 109);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 93;
            label1.Text = "contractType";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 86);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 94;
            label3.Text = "salary";
            // 
            // button3
            // 
            button3.Location = new Point(335, 85);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 97;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(335, 50);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 96;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(335, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 95;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Contract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(954, 613);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(chkStatus);
            Controls.Add(txtDirector);
            Controls.Add(txtPhone);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Contract";
            Text = "Contract";
            Load += Position_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private CheckBox chkStatus;
        private TextBox txtDirector;
        private TextBox txtPhone;
        private Label label1;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}