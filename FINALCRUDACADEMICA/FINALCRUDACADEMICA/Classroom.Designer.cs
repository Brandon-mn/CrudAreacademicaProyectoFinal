namespace CRUD
{
    partial class Classroom
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
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(315, 106);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 80;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 71);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 79;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(315, 33);
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
            chkStatus.Location = new Point(186, 144);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 77;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 74;
            label3.Text = "Capacity";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(12, 94);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 72;
            label2.Text = "Room Number";
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
            label1.Size = new Size(49, 20);
            label1.TabIndex = 70;
            label1.Text = "Name";
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 81;
            // 
            // Classroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(885, 478);
            Controls.Add(textBox1);
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
            Name = "Classroom";
            Text = "Classroom";
            Load += AcademicDiploma_Load;
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
        private TextBox textBox1;
    }
}