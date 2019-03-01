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
        /// 
        /// </summary>
        /// <param name="nT">Title name</param>
        /// <param name="nF">First name</param>
        /// <param name="nL">Last name</param>
        /// <param name="aZ">Address zipcode</param>
        /// <param name="aC">Address city</param>
        /// <param name="aS">Address street</param>
        /// <param name="aN">Address housenumber</param>
        /// <param name="bM">Mother birthname</param>
        /// <param name="bN">Birthname</param>
        /// <param name="bP">Birth place</param>
        /// <param name="bD">Birth date</param>
        /// <param name="dTB">Data TB number</param>
        /// <param name="dP">Data phone number</param>
        /// <param name="dE">Data Email address</param>
        public void saveNewPatientData(string nT, string nF, string nL, string aZ, string aC, string aS, string aN, string bM, string bN, string bP, string bD, string dTB, string dP, string dE)
        {
            MySqlComm mysql = new MySqlComm();
            MySqlConnectionDatabase conn = new MySqlConnectionDatabase();
            mysql = conn.connection();
            mysql.open();

            string query1="INSERT INTO patient(name,birthdate,tb) VALUES(@name,@birthdate,@tb);";
            cmd = mysql.getConnect(query1);
            cmd.Parameters.AddWithValue("@name", nT+" "+nL+" "+nF);
            cmd.Parameters.AddWithValue("@birthdate", bD);
            cmd.Parameters.AddWithValue("@tb", dTB);
            cmd.ExecuteNonQuery();
            mysql.close();
            mysql = conn.connection();
            mysql.open();

            string query2 = "INSERT INTO patient_sec(patient_id,birthplace,address,phone,email)" +
                " VALUES((SELECT patient.id FROM patient WHERE patient.tb=@tb),@birthplace,@address,@phone,@email);";
            cmd = mysql.getConnect(query2);
            cmd.Parameters.AddWithValue("@tb", dTB);
            cmd.Parameters.AddWithValue("@birthplace", bP);
            cmd.Parameters.AddWithValue("@address", aZ+" "+aC+", "+aS+" "+aN+".");
            cmd.Parameters.AddWithValue("@phone", dP);
            cmd.Parameters.AddWithValue("@email", dE);
            cmd.ExecuteNonQuery();
            mysql.close();
        }
    }
}
