namespace ProjectDesktop
{
    partial class FormTransJual
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LBLTanggal = new Label();
            LBLJam = new Label();
            label7 = new Label();
            LBLTotal = new Label();
            label9 = new Label();
            label10 = new Label();
            LBLNamaBarang = new Label();
            label12 = new Label();
            LBLHargaBarang = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label14 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            LBLKembali = new Label();
            label17 = new Label();
            LBLItem = new Label();
            label19 = new Label();
            button2 = new Button();
            LBLNamaKasir = new Label();
            label21 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            LBLNoJuall = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(698, 315);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Di Bayar";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(698, 351);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Kembali";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(707, 24);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Tanggal";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(707, 47);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Jam";
            // 
            // LBLTanggal
            // 
            LBLTanggal.BorderStyle = BorderStyle.Fixed3D;
            LBLTanggal.Location = new Point(813, 24);
            LBLTanggal.Name = "LBLTanggal";
            LBLTanggal.Size = new Size(124, 23);
            LBLTanggal.TabIndex = 29;
            // 
            // LBLJam
            // 
            LBLJam.BorderStyle = BorderStyle.Fixed3D;
            LBLJam.Location = new Point(813, 47);
            LBLJam.Name = "LBLJam";
            LBLJam.Size = new Size(124, 23);
            LBLJam.TabIndex = 5;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(309, 24);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Total";
            // 
            // LBLTotal
            // 
            LBLTotal.BorderStyle = BorderStyle.Fixed3D;
            LBLTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLTotal.Location = new Point(415, 24);
            LBLTotal.Name = "LBLTotal";
            LBLTotal.Size = new Size(229, 23);
            LBLTotal.TabIndex = 7;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(37, 111);
            label9.Name = "label9";
            label9.Size = new Size(41, 23);
            label9.TabIndex = 8;
            label9.Text = "Kode";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(143, 111);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 9;
            label10.Text = "Nama";
            // 
            // LBLNamaBarang
            // 
            LBLNamaBarang.BorderStyle = BorderStyle.Fixed3D;
            LBLNamaBarang.Location = new Point(249, 111);
            LBLNamaBarang.Name = "LBLNamaBarang";
            LBLNamaBarang.Size = new Size(211, 23);
            LBLNamaBarang.TabIndex = 10;
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(466, 111);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 11;
            label12.Text = "Harga";
            // 
            // LBLHargaBarang
            // 
            LBLHargaBarang.BorderStyle = BorderStyle.Fixed3D;
            LBLHargaBarang.Location = new Point(572, 111);
            LBLHargaBarang.Name = "LBLHargaBarang";
            LBLHargaBarang.Size = new Size(100, 23);
            LBLHargaBarang.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(841, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(879, 150);
            dataGridView1.TabIndex = 14;
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(678, 111);
            label14.Name = "label14";
            label14.Size = new Size(50, 23);
            label14.TabIndex = 15;
            label14.Text = "Jumlah";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 23);
            textBox1.TabIndex = 16;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(734, 111);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 23);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(813, 315);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(103, 23);
            textBox3.TabIndex = 18;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // LBLKembali
            // 
            LBLKembali.BorderStyle = BorderStyle.Fixed3D;
            LBLKembali.Location = new Point(816, 351);
            LBLKembali.Name = "LBLKembali";
            LBLKembali.Size = new Size(100, 23);
            LBLKembali.TabIndex = 19;
            // 
            // label17
            // 
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(37, 24);
            label17.Name = "label17";
            label17.Size = new Size(100, 23);
            label17.TabIndex = 20;
            label17.Text = "Nomor Jual";
            // 
            // LBLItem
            // 
            LBLItem.BorderStyle = BorderStyle.Fixed3D;
            LBLItem.Location = new Point(625, 315);
            LBLItem.Name = "LBLItem";
            LBLItem.Size = new Size(67, 23);
            LBLItem.TabIndex = 22;
            // 
            // label19
            // 
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Location = new Point(578, 315);
            label19.Name = "label19";
            label19.Size = new Size(41, 23);
            label19.TabIndex = 23;
            label19.Text = "Item";
            // 
            // button2
            // 
            button2.Location = new Point(37, 315);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 24;
            button2.Text = "SIMPAN";
            button2.UseVisualStyleBackColor = true;
            // 
            // LBLNamaKasir
            // 
            LBLNamaKasir.BorderStyle = BorderStyle.Fixed3D;
            LBLNamaKasir.Location = new Point(813, 70);
            LBLNamaKasir.Name = "LBLNamaKasir";
            LBLNamaKasir.Size = new Size(124, 23);
            LBLNamaKasir.TabIndex = 26;
            // 
            // label21
            // 
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Location = new Point(707, 70);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 25;
            label21.Text = "Kasir";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // LBLNoJuall
            // 
            LBLNoJuall.BorderStyle = BorderStyle.Fixed3D;
            LBLNoJuall.Location = new Point(143, 24);
            LBLNoJuall.Name = "LBLNoJuall";
            LBLNoJuall.Size = new Size(100, 23);
            LBLNoJuall.TabIndex = 27;
            // 
            // FormTransJual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 450);
            Controls.Add(LBLNoJuall);
            Controls.Add(LBLNamaKasir);
            Controls.Add(label21);
            Controls.Add(button2);
            Controls.Add(label19);
            Controls.Add(LBLItem);
            Controls.Add(label17);
            Controls.Add(LBLKembali);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(LBLHargaBarang);
            Controls.Add(label12);
            Controls.Add(LBLNamaBarang);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(LBLTotal);
            Controls.Add(label7);
            Controls.Add(LBLJam);
            Controls.Add(LBLTanggal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTransJual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTransJual";
            Load += FormTransJual_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LBLTanggal;
        private Label LBLJam;
        private Label label7;
        private Label LBLTotal;
        private Label label9;
        private Label label10;
        private Label LBLNamaBarang;
        private Label label12;
        private Label LBLHargaBarang;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label14;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label LBLKembali;
        private Label label17;
        private Label LBLItem;
        private Label label19;
        private Button button2;
        private Label LBLNamaKasir;
        private Label label21;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private Label LBLNoJuall;
    }
}