using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOR.Model;
using MySql.Data.MySqlClient;

namespace FOR.Controller
{
    class MainController
    {
        MainModel model;
        NewPatientForm newPF;

        public MainController()
        {
            model = new MainModel();
        }
        public string setWelcomeLabel(int id)
        {
           return model.setWelcomeLabel(id);
        }

        public void loadListViewPatient(ListView lvp)
        {
            model.loadListViewPatient(lvp);
        }

        public void searchPatient(ListView lvp, string search)
        {
            model.searchPatient(lvp, search);
        }

        public void deletePatient(string id)
        {
                DialogResult delete = MessageBox.Show("Biztosan törli véglegesen "+id+"-t az adatbázisból?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                    model.deletePatient(id);
                return;
        }

        public void addNewPatient()
        {
            newPF = new NewPatientForm();
            newPF.Show();
        }
    }
}
