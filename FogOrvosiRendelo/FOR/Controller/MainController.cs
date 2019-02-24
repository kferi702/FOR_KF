using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public ListView loadListViewPatient(ListView lvp)
        {
            lvp.Items.Clear();
            Database mysql = new Database();
            ConnectionData conn = new ConnectionData();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT * FROM patient;";
            cmd = mysql.getConnect(query);

            MySqlDataReader dr= cmd.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["name"].ToString();
                lvi.SubItems.Add(dr["birthdate"].ToString());
                lvi.SubItems.Add(dr["tb"].ToString());
                lvp.Items.Add(lvi);
            }
            dr.Close();
            mysql.close();
            return lvp;
        }

        public ListView searcPatient(ListView lvp, string search)
        {
            lvp.Items.Clear();
            Database mysql = new Database();
            ConnectionData conn = new ConnectionData();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT * FROM patient WHERE " +
                "name LIKE '%"+search+"%'" +
                "OR birthdate LIKE '%" + search + "%'" +
                "OR tb LIKE '%" + search + "%'";
            cmd = mysql.getConnect(query);

            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
            ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["name"].ToString();
                lvi.SubItems.Add(dr["birthdate"].ToString());
                lvi.SubItems.Add(dr["tb"].ToString());
                lvp.Items.Add(lvi);
            }
            dr.Close();
            mysql.close();
            return lvp;
        }
    }
}
