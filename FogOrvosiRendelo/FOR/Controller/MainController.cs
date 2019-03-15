using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOR.Model;
using FOR.View;
using MySql.Data.MySqlClient;

namespace FOR.Controller
{
    class MainController
    {
        MainModel model;
        NewPatientForm newPatientF;
        PatientDetailForm patientDetailF;
        PatientVisitsForm patientVisitsF;

        public MainController()
        {
            model = new MainModel();
        }
        /// <summary>
        /// Üdvözlő üzenet beállítása
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string setWelcomeLabel(int id) => model.setWelcomeLabel(id);
        /// <summary>
        /// Fő adatbázis betöltése
        /// </summary>
        /// <param name="lvp"></param>
        public void loadListViewPatient(ListView lvp) => model.loadListViewPatient(lvp);
        /// <summary>
        /// Élő keresés a Fő adatbázisban (azonnali szűrés)
        /// </summary>
        /// <param name="lvp"></param>
        /// <param name="search"></param>
        public void searchPatient(ListView lvp, string search) => model.searchPatient(lvp, search);
        /// <summary>
        /// Páciens törlésének megerősítése és tovább küldése a model-nak
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tb"></param>
        public void deletePatient(string name, string tb)
        {
                DialogResult delete = MessageBox.Show("Biztosan törli véglegesen "+name+"-t az adatbázisból?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                    model.deletePatient(tb);
                return;
        }
        public void addNewPatient()
        {
            newPatientF = new NewPatientForm();
            newPatientF.Show();
        }
        public void patientDetail(string tb)
        {
            patientDetailF = new PatientDetailForm(tb);
            patientDetailF.Show();
        }
        public void patientVisits(string tb, int staff_id)
        {
            patientVisitsF = new PatientVisitsForm(tb,staff_id);
            patientVisitsF.Show();
        }
    }
}
