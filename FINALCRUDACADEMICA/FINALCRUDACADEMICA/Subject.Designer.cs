namespace CRUD
{
    partial class Subject
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
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(315, 107);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 52;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 72);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 49;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(315, 35);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 48;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Location = new Point(178, 77);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(69, 24);
            chkStatus.TabIndex = 47;
            chkStatus.Text = "status";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 133);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 36;
            label3.Text = "code";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(11, 156);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 72);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 34;
            label2.Text = "credits";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(11, 95);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 32;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 381);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(885, 451);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkStatus);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "Subject";
            Text = "Subject";
            Load += Position_Load;
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
        private TextBox txtName;
        private DataGridView dataGridView1;
    }
}