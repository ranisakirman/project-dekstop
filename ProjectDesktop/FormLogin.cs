using MySql.Data.MySqlClient;
using System.Data;

namespace ProjectDesktop
{
    public partial class FormLogin : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        //5
        Koneksi Konn = new Koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            MySqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tbl_kasir where KodeKasir='" + textBox1.Text + "' AND PasswordKasir='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {


                    FormMenuUtama.menu.menuLogin.Enabled = false;
                    FormMenuUtama.menu.menuLogout.Enabled = true;
                    FormMenuUtama.menu.menuMaster.Enabled = true;
                    FormMenuUtama.menu.menuTransaksi.Enabled = true;
                    FormMenuUtama.menu.menuLaporan.Enabled = true;
                    FormMenuUtama.menu.menuUtiliti.Enabled = true;

                    FormMenuUtama.menu.toolSST2.Text = textBox1.Text;
                    FormMenuUtama.menu.toolSST4.Text = reader.GetValue(1).ToString();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Salah Atuh");
                }
            }









            //if (textBox1.Text == "KSR01" && textBox2.Text == "admin")
            //{
            //    FormMenuUtama frmUtama = new FormMenuUtama();
            //    frmUtama.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Salah Atuh");
            //}
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = 'O';
            textBox1.Text = "KSR01";
            textBox2.Text = "admin";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}