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
        NewPatientForm newPF;
        PatientDetailForm patientDetailF;

        public MainController()
        {
            model = new MainModel();
        }
        public string setWelcomeLabel(int id) => model.setWelcomeLabel(id);
        public void loadListViewPatient(ListView lvp) => model.loadListViewPatient(lvp);
        public void searchPatient(ListView lvp, string search) => model.searchPatient(lvp, search);

        public void deletePatient(string name, string tb)
        {
                DialogResult delete = MessageBox.Show("Biztosan törli véglegesen "+name+"-t az adatbázisból?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                    model.deletePatient(tb);
                return;
        }

        public void addNewPatient()
        {
            newPF = new NewPatientForm();
            newPF.Show();
        }

        public void patientDetail(string tb)
        {
            patientDetailF = new PatientDetailForm(tb);
            patientDetailF.Show();
        }
    }
}
