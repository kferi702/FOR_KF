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
        public PatientModel pModel;

        public ListView loadListViewPatient(ListView lvp)
        {
            lvp.Items.Clear();
            MySqlComm mysql = new MySqlComm();
            pModel = new PatientModel();
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

        public void deletePatient(string tb)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            pModel.deletePatientFiles(tb);
            string query = "DELETE FROM patient WHERE tb=@tb;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@tb", tb);
            cmd.ExecuteNonQuery();
            mysql.close();
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
            string query = "SELECT staff.name FROM staff WHERE staff.id="+id+";";
            return mysql.getOneData(query);
        }
    }
}
