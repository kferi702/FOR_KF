using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOR.Modell
{
    class LoginModel
    {
        private MySqlCommand cmd;

        public void loginModel(string userName, string passWord, LoginForm loginF)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase connDb = new MySqlConnectionDatabase();
            mysql = connDb.connection();
            mysql.open();
            string query = "stafflogin";
            cmd = mysql.getConnect(query);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username", userName);
            cmd.Parameters.AddWithValue("password", passWord);
            int count = int.Parse(cmd.ExecuteScalar().ToString());

            if (count == 1)
            {
                string getID = "SELECT staff.id FROM staff WHERE staff.username=@username;";
                cmd = mysql.getConnect(getID);
                cmd.Parameters.AddWithValue("@username", userName);
                int id = int.Parse(cmd.ExecuteScalar().ToString());
                MainForm mf = new MainForm(id);
                mf.Show();
                loginF.Hide();

                //MessageBox.Show("Helyes adatok "+id);
                mysql.close();
            }
            else
            {
                MessageBox.Show("Hibás felhasználóinév vagy jelszó!");
                mysql.close();
            }
        }
    }
}
