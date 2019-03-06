using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public string getPatientAddress() => model.getPatientAddress();
        public void loadListViewVisits(string pat_id, ListView listViewVisits) => model.loadListViewVisits(pat_id, listViewVisits);

        public void hideForm(Form form)
        {
            form.Hide();
        }

        public string getPatientBirthDate() => model.getPatientBirthDate();
        public string getPatientBirthPlace() => model.getPatientBirthPlace();
        public string getPatientBirthName() => model.getPatientBirthName();
        public string getPatientMother() => model.getPatientMother();
        public string getPatientPhone() => model.getPatientPhone();
        public string getPatientEmail() => model.getPatientEmail();
        public string getPatientTB() => model.getPatientTB();
        public string getPatientComment() => model.getPatientComment();
        public void newVisits(string pat_id, string text) => model.newVisits(pat_id, text);

        public string showSelectedVisits(string id)
        {
            return model.showSelectedVisits(id);
        }

        public void deleteVisits(string pac_id, string selDate)
        {
            DialogResult delete = MessageBox.Show("Biztosan törli véglegesen a " + selDate + " számú bejegyzést az adatbázisból?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
                model.deleteVisits(pac_id,selDate);
            return;
        }



        /// <summary>
        /// Check all data from NewPatientForm and EditPatientDataForm before save them
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
        public bool checkData(string nT, string nF, string nL, string aZ, string aC, string aS, string aN, string bM, string bN, string bP, string bD, string dTB, string dP, string dE, string comment)
        {
            bool correct = true;
            if (correct==true)
                return true;
            else
                return false;
        }
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
        public void saveNewPatient(string nT, string nF, string nL, string aZ, string aC, string aS, string aN, string bM, string bN, string bP, string bD, string dTB, string dP, string dE, string comment)
        {
            model.saveNewPatientData(dTB,nT,nF,nL,bD);
            model.saveNewPatientSecData(dTB,bP,aZ,aC,aS,aN,dP,dE,bM,bN,comment);
            model.saveNewPatientWebData(dTB,bD);
        }
    }
}
