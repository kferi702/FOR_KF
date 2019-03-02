using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR.Model
{
    class PatientModel
    {
        public MySqlCommand cmd;
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
        public void saveNewPatientSecData(string dTB, string bP, string aZ, string aC, string aS, string aN, string dP, string dE, string bM, string bN)
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
            mysql.close();
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
        /// <summary>
        /// Trimmeli a születési dátumot
        /// </summary>
        /// <param name="bD">Birth date</param>
        /// <returns></returns>
        private string trimBirthDate(string bD)
        {
            char[] trimChar={'.'};
            string pass = bD.TrimStart(trimChar);
            pass.Trim();
            return pass;
        }
    }
}
