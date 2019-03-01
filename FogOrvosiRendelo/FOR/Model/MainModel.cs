using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOR.Model
{
    class MainModel
    {
        public MySqlCommand cmd;

        public ListView loadListViewPatient(ListView lvp)
        {
            lvp.Items.Clear();
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT * FROM patient;";
            cmd = mysql.getConnect(query);

            MySqlDataReader dr = cmd.ExecuteReader();

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

        public void deletePatient(string name)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT * FROM patient WHERE name=@name;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@name", name);
            mysql.close();
        }

        public void addNewPatient()
        {
            
        }

        public ListView searchPatient(ListView lvp, string search)
        {
            lvp.Items.Clear();
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT * FROM patient WHERE " +
                "name LIKE '%" + search + "%'" +
                "OR birthdate LIKE '%" + search + "%'" +
                "OR tb LIKE '%" + search + "%'";
            cmd = mysql.getConnect(query);

            MySqlDataReader dr = cmd.ExecuteReader();

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

        public string setWelcomeLabel(int id)
        {

            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();

            string query = "SELECT staff.name FROM staff WHERE staff.id=@id;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@id", id);
            string welcomeLabel = cmd.ExecuteScalar().ToString();
            mysql.close();

            return welcomeLabel;
        }
    }
}
