namespace CRUD
{
    partial class StudyPlan
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(215, 95);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 100;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 60);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 99;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(215, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 98;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Location = new Point(215, 141);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 97;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 69);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 92;
            label2.Text = "vent ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 11);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 91;
            label1.Text = "description";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 381);
            dataGridView1.TabIndex = 89;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 93);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 102;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 103;
            // 
            // StudyPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudyPlan";
            Text = "StudyPlan";
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
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}