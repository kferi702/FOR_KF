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
        public string getPatientID() => model.getPatientID();
        public string getPatientName() => model.getPatientName();
        public string getPatientAddress() => model.getPatientAddress();
        public string getPatientBirthDate() => model.getPatientBirthDate();
        public string getPatientBirthPlace() => model.getPatientBirthPlace();
        public string getPatientBirthName() => model.getPatientBirthName();
        public string getPatientMother() => model.getPatientMother();
        public string getPatientPhone() => model.getPatientPhone();
        public string getPatientEmail() => model.getPatientEmail();
        public string getPatientTB() => model.getPatientTB();
        public string getPatientComment() => model.getPatientComment();
        public string getSelectedVisits(string id) => model.getSelectedVisits(id);
        public void loadListViewVisits(string pat_id, ListView listViewVisits) => model.loadListViewVisits(pat_id, listViewVisits);
        public void hideForm(Form form) => form.Hide();
        /// <summary>
        /// Látogatás törlése => Tovább a model felé
        /// </summary>
        /// <param name="selVisID"></param>
        public void deleteVisits(string selVisID)
        {
            DialogResult delete = MessageBox.Show("Biztosan törli véglegesen a " + selVisID + " számú bejegyzést az adatbázisból?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
                model.deleteVisits(selVisID);
            return;
        }
        /// <summary>
        /// Új bejegyzés mentése => továbbküldés a model felé
        /// </summary>
        /// <param name="pat_id"></param>
        /// <param name="text"></param>
        public void newVisits(string pat_id, string text) => model.setNewVisits(pat_id, text);
        /// <summary>
        /// Ellenörzi és tovább küldi az új páciens adatait a model felé
        /// </summary>
        /// <param name="name">Név</param>
        /// <param name="address">Cím</param>
        /// <param name="birthDate">Születési idő</param>
        /// <param name="birthPlace">Születési hely</param>
        /// <param name="birthName">Születési név</param>
        /// <param name="mother">Anyja neve</param>
        /// <param name="tb">TB szám</param>
        /// <param name="phone">Telefonszám</param>
        /// <param name="email">Email cím</param>
        /// <param name="comment">Comment</param>
        public void savePatientDatail(string name, string address, string birthDate, string birthPlace, string birthName, string mother, string tb, string phone, string email, string comment)
        {
            bool correct = true;
            string number = "^[0-9]+$";
            if (!Regex.IsMatch(trim(birthDate), number) ||
                !Regex.IsMatch(trim(phone), number) ||
                !Regex.IsMatch(trim(tb), number))
            {
                correct = false;
                MessageBox.Show("Születési idő, telefonszám és a TB-szám csak számot tartalmazhat!", "Hibás szám adatok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (name=="" || address=="" || birthDate=="" || birthPlace==""|| mother==""|| tb==""||phone=="")
            {
                correct = false;
                MessageBox.Show("Kötelező mezők nincsenek kitöltve!", "Hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                if (correct==true)
                model.savePatientDetails(name, address, birthDate, birthPlace, birthName, mother, tb, phone, email, comment);
        }
        /// <summary>
        /// Szöveges adatok ellenörzése
        /// </summary>
        /// <param name="nameFirst">Vezetéknév</param>
        /// <param name="nameLast">Keresztnév</param>
        /// <param name="addressZip">Cím irányítószám</param>
        /// <param name="addressCity">Cím város</param>
        /// <param name="addressStreet">Cím utca</param>
        /// <param name="addressNumber">Cím házszám</param>
        /// <param name="birthMother">Anyja neve</param>
        /// <param name="birthName">Születési név</param>
        /// <param name="birthPlace">Születési hely</param>
        /// <param name="birthDate">Születési dátum</param>
        /// <param name="dataTB">TB szám</param>
        /// <param name="dataPhone">Telefonszám</param>
        /// <param name="dataEmail">E-mail cím</param>
        public bool checkData(string nameFirst, string nameLast, string addressZip, string addressCity, string addressStreet, string addressNumber, string birthMother, string birthName, string birthPlace, string birthDate, string dataTB, string dataPhone, string dataEmail, string comment)
        {
            string number = "^[0-9]+$";
            if (!Regex.IsMatch(trim(addressZip), number) ||
                !Regex.IsMatch(trim(birthDate), number) ||
                !Regex.IsMatch(trim(dataPhone), number) ||
                !Regex.IsMatch(trim(dataTB), number))
            {
            return false;
            }
            if (nameFirst == "" || nameLast==""|| birthMother == ""|| birthPlace=="")
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Kapott szöveg trimmelése (szóközök és irásjelek kiszedése)
        /// </summary>
        /// <param name="text">Ellenőrizendő szöveg</param>
        /// <returns></returns>
        private string trim(string text)
        {
            return text.Replace(".", string.Empty).Replace(" ", string.Empty).Replace(":", string.Empty).Replace("/", string.Empty).Replace("\"", string.Empty).Replace("-", string.Empty);
        }
        /// <summary>
        /// Új páciens mentése, adatok továbbítása a model részére
        /// </summary>
        /// <param name="nameFirst">Vezetéknév</param>
        /// <param name="nameLast">Keresztnév</param>
        /// <param name="addressZip">Cím irányítószám</param>
        /// <param name="addressCity">Cím város</param>
        /// <param name="addressStreet">Cím utca</param>
        /// <param name="addressNumber">Cím házszám</param>
        /// <param name="birthMother">Anyja neve</param>
        /// <param name="birthName">Születési név</param>
        /// <param name="birthPlace">Születési hely</param>
        /// <param name="birthDate">Születési dátum</param>
        /// <param name="dataTB">TB szám</param>
        /// <param name="dataPhone">Telefonszám</param>
        /// <param name="dataEmail">E-mail cím</param>
        public void saveNewPatient(string nameFirst, string nameLast, string addressZip, string addressCity, string addressStreet, string addressNumber, string birthMother, string birthName, string birthPlace, string birthDate, string dataTB, string dataPhone, string dataEmail, string comment)
        {
            model.saveNewPatientData(dataTB,nameFirst,nameLast,birthDate);
            model.saveNewPatientSecData(dataTB,birthPlace,addressZip,addressCity,addressStreet,addressNumber,dataPhone,dataEmail,birthMother,birthName,comment);
            model.saveNewPatientWebData(dataTB,birthDate);
        }
    }
}
