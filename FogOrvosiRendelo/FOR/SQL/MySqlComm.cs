using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FOR.Model
{
    class MySqlComm
    {
        private string server;
        private string database;
        private string port;
        private string ssl;
        private string username;
        private string password;
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void setConnServer(string server, string database, string port, string ssl)
        {
            this.server = server;
            this.database = database;
            this.port = port;
            this.ssl = ssl;
        }
        public void setConnUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public void makeConn()
        {
            string connectionString =
                "SERVER=" + server + ";"
                + "DATABASE=" + database + ";"
                + "UID=" + username + ";"
                + "PASSWORD=" + password + ";"
                + "PORT=" + port + ";"
                + "SSLMODE=" + ssl + ";";

            try
            {
                this.conn = new MySqlConnection(connectionString);

            }
            catch
            {
                MessageBox.Show("HIBA!",
                "Hiba az adatbázis elérése közben",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
           );
            }
        }
        public MySqlCommand getConnect(string query)
        {
            MySqlComm db = new MySqlComm();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd;
        }
        public string getOneData(string query)
        {
            cmd = getConnect(query);
            return cmd.ExecuteScalar().ToString();
        }
        public void open()
        {
            conn.Open();
        }
        public void close()
        {
            conn.Close();
        }
    }
}
