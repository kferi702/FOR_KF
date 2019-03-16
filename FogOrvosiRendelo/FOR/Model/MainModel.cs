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
            try
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
            catch (Exception e)
            {

                MessageBox.Show("Hiba az adatbázis elérésekor: " + e, "Adatbázis HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lvp;
            }
        }

        public void deletePatient(string tb)
        {
            try
            {
                MySqlComm mysql = new MySqlComm();
                MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
                mysql = conn.connection();
                mysql.open();
                string query = "DELETE FROM patient WHERE tb=@tb;";
                cmd = mysql.getConnect(query);
                cmd.Parameters.AddWithValue("@tb", tb);
                cmd.ExecuteNonQuery();
                mysql.close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Hiba az adatbázis elérésekor: " + e, "Adatbázis HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ListView searchPatient(ListView lvp, string search)
        {
            try
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
            catch (Exception e)
            {

                MessageBox.Show("Hiba az adatbázis elérésekor: " + e, "Adatbázis HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lvp;
            }
        }

        public string setWelcomeLabel(int id)
        {
            try
            {
                MySqlComm mysql = new MySqlComm();
                MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
                mysql = conn.connection();
                mysql.open();
                string query = "SELECT staff.name FROM staff WHERE staff.id=" + id + ";";
                return mysql.getOneData(query);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hiba az adatbázis elérésekor: " + e, "Adatbázis HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
