using FOR.View;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptSharp;
using FOR.Controller;

namespace FOR.Model
{
    class PatientModel
    {
        public MySqlCommand cmd;
        private string id;
        private string name;
        private string address;
        private string birthDate;
        private string birthPlace;
        private string birthName;
        private string mother;
        private string phone;
        private string email;
        private string tb;
        private string comment;

        public PatientModel()
        {

        }
        
        public void loadPatientDetail(string tb)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "SELECT * FROM patient, patient_sec " +
                "WHERE patient.tb=@tb " +
                "AND patient_sec.patient_id = patient.id;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@tb", tb);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                name = dr["name"].ToString();
                address = dr["address"].ToString();
                birthDate = dr["birthdate"].ToString();
                birthPlace = dr["birthplace"].ToString();
                mother = dr["mother_name"].ToString();
                phone = dr["phone"].ToString();
                email = dr["email"].ToString();
                id = dr["id"].ToString();
                comment = dr["comment"].ToString();
                if (dr["birth_name"].ToString().Trim() == "")
                    birthName = name;
                else
                    birthName = dr["birth_name"].ToString();
                this.tb = tb;
            }
            dr.Close();
            mysql.close();

        }
            public ListView loadListViewVisits(string pat_id, ListView lvv)
        {
            lvv.Items.Clear();
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "SELECT id, date FROM patient_visits " +
                "WHERE patient_id=@pat_id";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["id"].ToString();
                lvi.SubItems.Add(dr["date"].ToString());
                lvv.Items.Add(lvi);
            }
            dr.Close();
            mysql.close();
            return lvv;
        }

        
        public string getPatientID() => id;
        public string getPatientName() => name;
        public string getPatientAddress() => address;
        public string getPatientBirthDate() => birthDate;
        public string getPatientBirthPlace() => birthPlace;
        public string getPatientBirthName() => birthName;
        public string getPatientMother() => mother;
        public string getPatientPhone() => phone;
        public string getPatientEmail() => email;
        public string getPatientTB() => tb;
        public string getPatientComment() => comment;
        public string getComment() => comment;
        public string getSelectedVisits(string id)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "SELECT text FROM patient_visits " +
                "WHERE id='"+id+"';";
            return mysql.getOneData(query);
        }
        public void setNewVisits(string pat_id, string text)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "INSERT INTO patient_visits(patient_id,date,text) VALUES(@pat_id,CURRENT_TIMESTAMP,@text);";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@text", text);
            cmd.ExecuteNonQuery();
            mysql.close();
        }
        public void deleteVisits(string selVizID)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "DELETE FROM patient_visits WHERE id=@id;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@id", selVizID);
            cmd.ExecuteNonQuery();
            mysql.close();

        }
        /// <summary>
        /// Trimmeli a kért szöveget a fölös irásjelektől
        /// </summary>
        /// <param name="text">trimmelendő text</param>
        /// <returns></returns>
        private string trimText(string text)
        {
            return text.Replace(".", string.Empty).Replace(" ", string.Empty).Replace(":", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).Replace("\"", string.Empty);
        }
        /// <summary>
        /// Save patient details data to database
        /// </summary>
        /// <param name="name">Patient name</param>
        /// <param name="address">Patient address</param>
        /// <param name="birthDate">Patient birth date</param>
        /// <param name="birthPlace">Patient birth place</param>
        /// <param name="birthName">Patient birth name</param>
        /// <param name="mother">Patient mother name</param>
        /// <param name="tb">Patient tb number</param>
        /// <param name="phone">Patient phone number</param>
        /// <param name="email">Patient email address</param>
        /// <param name="comment">Patient comment</param>
        public void savePatientDetails(string name, string address, string birthDate, string birthPlace, string birthName, string mother, string tb, string phone, string email, string comment)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "UPDATE patient, patient_sec SET " +
                "name=@name, " +
                "birthdate=@birthdate, " +
                "tb=@tb, " +
                "birthplace=@birthplace, " +
                "address=@address, " +
                "phone=@phone, " +
                "email=@email, " +
                "mother_name=@mother_name, " +
                "comment=@comment," +
                "birth_name=@birth_name " +
                "WHERE patient.id = @id " +
                "AND patient.id = patient_sec.patient_id;";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@birthdate", birthDate);
            cmd.Parameters.AddWithValue("@tb", tb);
            cmd.Parameters.AddWithValue("@birthplace", birthPlace);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mother_name", mother);
            cmd.Parameters.AddWithValue("@comment", comment);
            cmd.Parameters.AddWithValue("@birth_name", birthName);
            cmd.ExecuteNonQuery();
            mysql.close();

            
        }
        /// <summary>
        /// Létrehozza a patient adattáblát
        /// </summary>
        /// <param name="tb">Tb number</param>
        /// <param name="nT">Name title</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="birthDate">Birth date</param>
        public void saveNewPatientData(string tb, string firstName, string lastName, string birthDate)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "INSERT INTO patient(name,birthdate,tb) VALUES(@name,@birthdate,@tb);";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@name", firstName + " " + lastName);
            cmd.Parameters.AddWithValue("@birthdate", trimText(birthDate));
            cmd.Parameters.AddWithValue("@tb", trimText(tb));
            cmd.ExecuteNonQuery();
            mysql.close();
        }
        /// <summary>
        /// Létrehozza a patient_sec adattáblát
        /// </summary>
        /// <param name="tb">TB number</param>
        /// <param name="birthPlace">Birth place</param>
        /// <param name="addressZip">Address zip code</param>
        /// <param name="addressCity">Address city</param>
        /// <param name="addressStreet">Address street</param>
        /// <param name="addressNumber">Address house number</param>
        /// <param name="phone">Phone number</param>
        /// <param name="email">Email address</param>
        /// <param name="motherName">Mother name</param>
        /// <param name="birthName">Birth Name</param>
        public void saveNewPatientSecData(string tb, string birthPlace, string addressZip, string addressCity, string addressStreet, string addressNumber, string phone, string email, string motherName, string birthName, string comment)
        {
            try
            {
                MySqlComm mysql = new MySqlComm();
                MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
                mysql = conn.connection();
                mysql.open();
                string query = "INSERT INTO patient_sec(patient_id,birthplace,address,phone,email,mother_name,comment,birth_name)" +
                    " VALUES((SELECT patient.id FROM patient WHERE patient.tb=@tb),@birthplace,@address,@phone,@email,@mother_name,@comment,@birth_name);";
                cmd = mysql.getConnect(query);
                cmd.Parameters.AddWithValue("@tb", trimText(tb));
                cmd.Parameters.AddWithValue("@birthplace", birthPlace);
                cmd.Parameters.AddWithValue("@address", trimText(addressZip) + " " + addressCity + ", " + addressStreet + " " + addressNumber + ".");
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mother_name", motherName);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@birth_name", birthName);
                cmd.ExecuteNonQuery();
                mysql.close();
            }catch(MySqlException e)
            {
                MessageBox.Show("Hiba az adatbázis feltöltésénél!","Adatbázis hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// létrehozza a patientweb adattáblát
        /// </summary>
        /// <param name="tb">TB number</param>
        /// <param name="birthDate">Birth date</param>
        public void saveNewPatientWebData(string tb, string birthDate)
        {

            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "INSERT INTO patient_web(patient_id,username,password)" +
                "VALUES((SELECT patient.id FROM patient WHERE patient.tb=@tb),@username,@password);";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@tb", trimText(tb));
            cmd.Parameters.AddWithValue("@username", trimText(tb));
            cmd.Parameters.AddWithValue("@password", Crypter.Blowfish.Crypt(trimText(birthDate)));
            cmd.ExecuteNonQuery();
            mysql.close();
        }
    }
}
