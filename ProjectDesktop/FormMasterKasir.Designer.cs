namespace ProjectDesktop
{
    partial class FormMasterKasir
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Kode Kasir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Kasir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "Password Kasir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 150);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Level Kasir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(16, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(712, 248);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proses";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(639, 122);
            dataGridView1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(364, 36);
            button4.Name = "button4";
            button4.Size = new Size(92, 37);
            button4.TabIndex = 3;
            button4.Text = "TUTUP";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(253, 36);
            button3.Name = "button3";
            button3.Size = new Size(92, 37);
            button3.TabIndex = 2;
            button3.Text = "HAPUS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 36);
            button2.Name = "button2";
            button2.Size = new Size(92, 37);
            button2.TabIndex = 1;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 36);
            button1.Name = "button1";
            button1.Size = new Size(92, 37);
            button1.TabIndex = 0;
            button1.Text = "INPUT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMasterKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKasir";
            Load += FormMasterKasir_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}