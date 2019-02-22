using FOR.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FOR;
using System.Windows.Forms;

namespace FOR.Controller
{
    class LoginController
    {
        private MySqlCommand cmd;

        public void login(string userName, string passWord)
        {
            Database mysql= new Database();
            ConnectionData connDb = new ConnectionData();
            mysql = connDb.connection();
            mysql.open();
            string query = "stafflogin";
            cmd = mysql.getConnect(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username",userName);
            cmd.Parameters.AddWithValue("password",passWord);
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            if (count == 1)
            {
                MainForm mf = new MainForm();
                MessageBox.Show("Helyes adatok");
            }
            else
            {
                MessageBox.Show("Hibás belépési adatok!");
            }
        }
    }
}
