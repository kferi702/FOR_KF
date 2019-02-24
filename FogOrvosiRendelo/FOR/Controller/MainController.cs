using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOR.Modell;
using MySql.Data.MySqlClient;

namespace FOR.Controller
{
    class MainController
    {
        public MySqlCommand cmd;



        public string setWelcomeLabel(int id)
        {

            Database mysql = new Database();
            ConnectionData conn = new ConnectionData();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT staff.name FROM staff WHERE staff.id=@id;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@id", id);
            string welcomeLabel =cmd.ExecuteScalar().ToString();
            mysql.close();

            return welcomeLabel;
        }
    }
}
