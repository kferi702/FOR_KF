using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOR.Model;
using FOR.View;
using MetroFramework.Controls;

namespace FOR.Controller
{
    

    class PatientController
    {
        PatientModel model;

        public PatientController()
        {
            model = new PatientModel();
        }

        public void loadPatientDetail(string tb) => model.loadPatientDetail(tb);
        public void savePatientDatail(string name, string address, string birthDate, string birthPlace, string birthName, string mother, string tb, string phone, string email, string comment) => model.savePatientDetails(name, address, birthDate, birthPlace, birthName, mother, tb, phone, email, comment);

        public string getPatientID() => model.getPatientID();
        public string getPatientName() => model.getPatientName();

        public string setPatientDetailsFormText(bool editable)
        {
            if (editable)
            {
                return "Részletes Adatlap Megtekintése";
            }
            else
            {
                return "Részletes Adatlap Szerkesztése";
            }
        }

        public string getPatientAddress() => model.getPatientAddress();
        public void loadListViewVisits(string pat_id, ListView listViewVisits) => model.loadListViewVisits(pat_id, listViewVisits);
        public void hideForm(Form form)=>form.Hide();
        public string getPatientBirthDate() => model.getPatientBirthDate();
        public string getPatientBirthPlace() => model.getPatientBirthPlace();
        public string getPatientBirthName() => model.getPatientBirthName();
        public string getSelectedVisits(string id) =>model.getSelectedVisits(id);
        public string getPatientMother() => model.getPatientMother();
        public void deleteVisits(string selVisID)
        {
            DialogResult delete = MessageBox.Show("Biztosan törli véglegesen a " + selVisID + " számú bejegyzést az adatbázisból?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
                model.deleteVisits(selVisID);
            return;
        }
        public string getPatientPhone() => model.getPatientPhone();
        public string getPatientEmail() => model.getPatientEmail();
        public string getPatientTB() => model.getPatientTB();
        public string getPatientComment() => model.getPatientComment();
        public void newVisits(string pat_id, string text) => model.setNewVisits(pat_id, text);


        /// <summary>
        /// Check all data from NewPatientForm and EditPatientDataForm before save them
        /// </summary>
 
        /// <param name="nameFirst">First name</param>
        /// <param name="nameLast">Last name</param>
        /// <param name="addressZip">Address zipcode</param>
        /// <param name="addressCity">Address city</param>
        /// <param name="addressStreet">Address street</param>
        /// <param name="addressNumber">Address housenumber</param>
        /// <param name="birthMother">Mother birthname</param>
        /// <param name="birthName">Birthname</param>
        /// <param name="birthPlace">Birth place</param>
        /// <param name="birthDate">Birth date</param>
        /// <param name="dataTB">Data TB number</param>
        /// <param name="dataPhone">Data phone number</param>
        /// <param name="dataEmail">Data Email address</param>
        public bool checkData(string nameFirst, string nameLast, string addressZip, string addressCity, string addressStreet, string addressNumber, string birthMother, string birthName, string birthPlace, string birthDate, string dataTB, string dataPhone, string dataEmail, string comment)
        {
            string number = "^[0-9]+$";
            if (!Regex.IsMatch(addressZip, number))
                return false;
            if (!Regex.IsMatch(addressNumber, number))
                return false;
            return true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameFirst">First name</param>
        /// <param name="nameLast">Last name</param>
        /// <param name="addressZip">Address zipcode</param>
        /// <param name="addressCity">Address city</param>
        /// <param name="addressStreet">Address street</param>
        /// <param name="addressNumber">Address housenumber</param>
        /// <param name="birthMother">Mother birthname</param>
        /// <param name="birthName">Birthname</param>
        /// <param name="birthPlace">Birth place</param>
        /// <param name="birthDate">Birth date</param>
        /// <param name="dataTB">Data TB number</param>
        /// <param name="dataPhone">Data phone number</param>
        /// <param name="dataEmail">Data Email address</param>
        public void saveNewPatient(string nameFirst, string nameLast, string addressZip, string addressCity, string addressStreet, string addressNumber, string birthMother, string birthName, string birthPlace, string birthDate, string dataTB, string dataPhone, string dataEmail, string comment)
        {
            model.saveNewPatientData(dataTB,nameFirst,nameLast,birthDate);
            model.saveNewPatientSecData(dataTB,birthPlace,addressZip,addressCity,addressStreet,addressNumber,dataPhone,dataEmail,birthMother,birthName,comment);
            model.saveNewPatientWebData(dataTB,birthDate);
        }
    }
}
