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
                if (dr["birth_name"].ToString().Trim() == "")
                    birthName = name;
                else
                    birthName = dr["birth_name"].ToString();
                this.tb = tb;
                this.comment = getComment(id);
            }
            dr.Close();
            string getID = "SELECT patient_id FROM patient_sec, patient WHERE  patient.tb=" + tb + " AND patient.id=patient_sec.patient_id;";
            this.comment = getComment(mysql.getOneData(getID));
            mysql.close();

        }

        public ListView loadListViewVisits(string pac_id, MetroListView lvv)
        {
            lvv.Items.Clear();
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "";
            cmd = mysql.getConnect(query);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem();

                lvv.Items.Add(lvi);
            }
            dr.Close();
            mysql.close();
            return lvv;
        }

        public void deleteVisits(string pac_id, string selDate)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "DELETE FROM patient_visits WHERE pac_id=@pac_id AND date=@date";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@pac_id", pac_id);
            cmd.Parameters.AddWithValue("@date", selDate);
            cmd.ExecuteNonQuery();
            mysql.close();
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
        /// <summary>
        /// Load comment from Patient comment text file.
        /// </summary>
        /// <param name="id">Patient unique identify number</param>
        /// <returns></returns>
        public string getComment(string id)
        {
            string path= Environment.CurrentDirectory + "/patientsComment/" + id + ".txt";
            try
            {
                FileInfo file = new FileInfo(path);
                file.Directory.Create();
                return File.ReadAllText(path, Encoding.Default);
            }
            catch(FileNotFoundException)
            {
                FileInfo file = new FileInfo(path);
                FileStream fs = file.Create();
                fs.Close();
                return File.ReadAllText(path, Encoding.Default);
            }
            
            
        }
        /// <summary>
        /// Save text to patient comment file.
        /// </summary>
        /// <param name="id">Patient unique identify number</param>
        /// <param name="text">Text to save</param>
        /// <returns></returns>
        public string setComment(string id, string text)
        {
            string path = Environment.CurrentDirectory+"/patientsComment/" +id + ".txt";
            FileInfo file = new FileInfo(path);
            file.Directory.Create();
            File.WriteAllText(path, text, Encoding.Default);
            return comment;
        }
        /// <summary>
        /// Trimmeli a születési dátumot
        /// </summary>
        /// <param name="bD">Birth date</param>
        /// <returns></returns>
        private string trimBirthDate(string bD)
        {
            string trimBD = bD.Remove(4, 2);
            trimBD = trimBD.Remove(6, 2);
            trimBD = trimBD.Remove(8);
            return trimBD;
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
            cmd.Parameters.AddWithValue("@birth_name", birthName);
            cmd.ExecuteNonQuery();
            mysql.close();

            comment = setComment(id,comment);
            
        }
        /// <summary>
        /// Létrehozza a patient adattáblát
        /// </summary>
        /// <param name="dTB">Tb number</param>
        /// <param name="nT">Name title</param>
        /// <param name="nF">First name</param>
        /// <param name="nL">Last name</param>
        /// <param name="bD">Birth date</param>
        public void saveNewPatientData(string dTB, string nT, string nF, string nL, string bD)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "INSERT INTO patient(name,birthdate,tb) VALUES(@name,@birthdate,@tb);";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@name", nT + " " + nF + " " + nL);
            cmd.Parameters.AddWithValue("@birthdate", trimBirthDate(bD));
            cmd.Parameters.AddWithValue("@tb", dTB);
            cmd.ExecuteNonQuery();
            mysql.close();
        }
        /// <summary>
        /// Létrehozza a patient_sec adattáblát
        /// </summary>
        /// <param name="dTB">TB number</param>
        /// <param name="bP">Birth place</param>
        /// <param name="aZ">Address zip code</param>
        /// <param name="aC">Address city</param>
        /// <param name="aS">Address street</param>
        /// <param name="aN">Address house number</param>
        /// <param name="dP">Phone number</param>
        /// <param name="dE">Email address</param>
        /// <param name="bM">Mother name</param>
        /// <param name="bN">Birth Name</param>
        public void saveNewPatientSecData(string dTB, string bP, string aZ, string aC, string aS, string aN, string dP, string dE, string bM, string bN, string comment)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query="INSERT INTO patient_sec(patient_id,birthplace,address,phone,email,mother_name,birth_name)" +
                " VALUES((SELECT patient.id FROM patient WHERE patient.tb=@tb),@birthplace,@address,@phone,@email,@mother_name,@birth_name);";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@tb", dTB);
            cmd.Parameters.AddWithValue("@birthplace", bP);
            cmd.Parameters.AddWithValue("@address", aZ + " " + aC + ", " + aS + " " + aN + ".");
            cmd.Parameters.AddWithValue("@phone", dP);
            cmd.Parameters.AddWithValue("@email", dE);
            cmd.Parameters.AddWithValue("@mother_name", bM);
            cmd.Parameters.AddWithValue("@birth_name", bN);
            cmd.ExecuteNonQuery();
            string getID = "SELECT patient_id FROM patient_sec, patient WHERE  patient.tb="+tb+" AND patient.id=patient_sec.patient_id;";
            setComment(mysql.getOneData(getID), comment);

        }
        /// <summary>
        /// létrehozza a patientweb adattáblát
        /// </summary>
        /// <param name="dTB">TB number</param>
        /// <param name="bD">Birth date</param>
        public void saveNewPatientWebData(string dTB, string bD)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();
            string query = "INSERT INTO patienweb(patient_id,username,password)" +
                "VALUES((SELECT patient.id FROM patient WHERE patient.tb=@tb),@username,@password);";
            cmd = mysql.getConnect(query);
            cmd.Parameters.AddWithValue("@tb", dTB);
            cmd.Parameters.AddWithValue("@username",dTB);
            cmd.Parameters.AddWithValue("@password", trimBirthDate(bD));
            cmd.ExecuteNonQuery();
            mysql.close();
        }

    }
}
