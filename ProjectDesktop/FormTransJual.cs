using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectDesktop
{
    public partial class FormTransJual : Form
    {

        Koneksi konn = new Koneksi();
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        public FormTransJual()
        {
            InitializeComponent();
        }
        void KondisiAwal()
        {
            LBLHargaBarang.Text = "";
            LBLNamaKasir.Text = "";
            LBLNamaBarang.Text = "";
            LBLKembali.Text = "";
            LBLNoJuall.Text = "";
            LBLTotal.Text = "";
            LBLItem.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            LBLTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
            BuatKolom1();
            BuatKolom2();

        }
        void BuatKolom1()
        {
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM TBL_DETAILJUAL", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "TBL_DETAILJUAL");
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("KodeBarang", "Kode Barang");
            dataGridView1.Columns.Add("NamaBarang", "Nama Barang");
            dataGridView1.Columns.Add("HargaBarang", "Harga Barang");
            dataGridView1.Columns.Add("JumlahJual", "JumlahJual");
            dataGridView1.Columns.Add("SubTotal", "Sub Total");
            dataGridView1.Columns[1].Width = 340;
        }

        void BuatKolom2()
        {
            MySqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM TBL_JUAL", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "TBL_JUAL");
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NoJual", "No Jual");
            dataGridView1.Columns.Add("TglJual", "Tgl Jual");
            dataGridView1.Columns.Add("ItemJual", "Item Jual");
            dataGridView1.Columns.Add("TotalJual", "Total Jual");
            dataGridView1.Columns.Add("DiBayar", "Di Bayar");
            dataGridView1.Columns.Add("Kembali", "Kembalian");
            dataGridView1.Columns.Add("KodeKasir", "Kode Kasir");
            dataGridView1.Columns[1].Width = 340;
        }

        private void FormTransJual_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MySqlConnection conn = konn.GetConn();

                cmd = new MySqlCommand("SELECT * FROM tbl_barang WHERE KodeBarang='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    LBLNamaBarang.Text = rd[1].ToString();
                    LBLNoJuall.Text = rd[2].ToString();
                    LBLHargaBarang.Text = rd[3].ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ada Om");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mengambil nilai dari label-label
                string KodeBarang = textBox1.Text;
                string NamaBarang = LBLNamaBarang.Text;
                int HargaBarang = Convert.ToInt32(LBLHargaBarang.Text);
                int JumlahJual = Convert.ToInt32(textBox2.Text);
                int kembali = Convert.ToInt32(LBLKembali.Text);
                int SubTotal = Convert.ToInt32(LBLTotal.Text);


                // Menampilkan data di MessageBox
                string message = $"Kode Barang: {KodeBarang}\nNama Barang: {NamaBarang}\nHarga Barang: {HargaBarang}\nJumlah Jual: {JumlahJual}\nSub Total: {SubTotal}";

                MessageBox.Show(message, "Data yang akan disimpan");

                // Menambahkan data ke dalam DataGridView
                dataGridView1.Rows.Add(KodeBarang, NamaBarang, HargaBarang, JumlahJual,kembali, SubTotal);

                // Menghitung total item dan total harga
                int totalItem = 0;
                int totalHarga = 0;
                int totalkembali = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totalItem += Convert.ToInt32(row.Cells["JumlahJual"].Value);
                    totalHarga += Convert.ToInt32(row.Cells["SubTotal"].Value);
                    totalkembali += Convert.ToInt32(row.Cells["Kembalian"].Value);
                }

                // Menampilkan total item dan total harga pada label
                LBLItem.Text = totalItem.ToString();
                LBLTotal.Text = totalHarga.ToString();
                LBLKembali.Text = totalkembali.ToString();

                // Membersihkan input
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                LBLNoJuall.Text = "";
                LBLNamaBarang.Text = "";
                LBLHargaBarang.Text = "";
                LBLTotal.Text = "";
                BuatKolom1(); // Refresh DataGridView

                // Insert data ke dalam tabel tbl_detailjual
                using (MySqlConnection conn = konn.GetConn())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_detailjual (KodeBarang, NamaBarang, HargaBarang, JumlahJual,Kembali, SubTotal) VALUES (@KodeBarang, @NamaBarang, @HargaBarang, @JumlahJual,@Kembali, @SubTotal)", conn))
                    {
                        cmd.Parameters.AddWithValue("@KodeBarang", KodeBarang);
                        cmd.Parameters.AddWithValue("@NamaBarang", NamaBarang);
                        cmd.Parameters.AddWithValue("@HargaBarang", HargaBarang);
                        cmd.Parameters.AddWithValue("@JumlahJual", JumlahJual);
                        cmd.Parameters.AddWithValue("@Kembali", kembali);
                        cmd.Parameters.AddWithValue("@SubTotal", SubTotal);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil di input");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                // Mengambil nilai total dan kembalian dari label
                int total = Convert.ToInt32(LBLTotal.Text);
                int bayar = Convert.ToInt32(textBox3.Text);

                // Menghitung kembalian
                int kembalian = bayar - total;

                // Menampilkan kembalian pada label
                LBLKembali.Text = kembalian.ToString();

                // Menghitung jumlah item dari DataGridView
                int jumlahItem = dataGridView1.Rows.Count;

                // Menampilkan jumlah item pada label
                LBLItem.Text = jumlahItem.ToString();
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MySqlConnection conn = konn.GetConn();

                cmd = new MySqlCommand("SELECT * FROM tbl_barang WHERE KodeBarang='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int HargaBarang = Convert.ToInt32(rd[3]);
                    int jumlahItem = Convert.ToInt32(textBox2.Text);


                    // Hitung total dan set nilai ke LBLTotal
                    int total = HargaBarang * jumlahItem;
                    LBLTotal.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ada Om");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

