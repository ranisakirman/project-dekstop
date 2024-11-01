namespace ProjectDesktop
{
    partial class FormMasterBarang
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
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "KodeBarang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 56);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "NamaBarang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 124);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Harga Beli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 157);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Harga Jual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 190);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 4;
            label5.Text = "Jumlah Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 223);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Satuan Barang";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 13;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(186, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 27);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(40, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 248);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proses";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(682, 123);
            dataGridView1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(363, 36);
            button4.Name = "button4";
            button4.Size = new Size(91, 37);
            button4.TabIndex = 3;
            button4.Text = "TUTUP";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(253, 36);
            button3.Name = "button3";
            button3.Size = new Size(91, 37);
            button3.TabIndex = 2;
            button3.Text = "HAPUS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 36);
            button2.Name = "button2";
            button2.Size = new Size(91, 37);
            button2.TabIndex = 1;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 36);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 0;
            button1.Text = "INPUT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 91);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 14;
            label7.Text = "NoJual";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(186, 87);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 15;
            // 
            // FormMasterBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterBarang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMasterBarang";
            Load += FormMasterBarang_Load;
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
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private ComboBox comboBox2;
    }
}