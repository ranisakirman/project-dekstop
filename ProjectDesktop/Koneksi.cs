using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectDesktop
{
    class Koneksi
    {
        public MySqlConnection GetConn()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;port=3306;;user=root;password=;database=db_appkasir";
            return Conn;
        }
    }
}
