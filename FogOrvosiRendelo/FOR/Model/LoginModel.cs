
using FOR.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOR.Model
{
    class LoginModel
    {
        private MySqlCommand cmd;

        public void loginModel(string userName, string passWord, Form loginF)
        {
            try
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
                    MainForm mainF = new MainForm(id);
                    mainF.Show();
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
            catch (Exception e)
            {

                MessageBox.Show("Hiba az adatbázis elérésekor: " + e, "Adatbázis HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
