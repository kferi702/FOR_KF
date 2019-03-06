using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOR.Controller;

namespace FOR.View
{
    public partial class PatientVisitsForm : MetroForm
    {
        PatientController controller;
        PatientVisitsForm patVisForm;
        string tb;
        string pac_id;

        public PatientVisitsForm(string tb)
        {
            controller = new PatientController();
            controller.loadPatientDetail(tb);
            this.tb = tb;
            patVisForm = this;
            InitializeComponent();
            pac_id = controller.getPatientID();
            setLabel();
            loadPatientVisits();
        }

        private void loadPatientVisits() => controller.loadListViewVisits(pac_id,listViewVisits);
        private void setLabel()=>labelPacientName.Text = controller.getPatientName()+" nevű páciens kórtörténete!";
        private void metroTile2_Click(object sender, EventArgs e) => patVisForm.Hide();
        private void ListViewVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count < 0)
                return;
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count != 0)
            {
                string selDate = listViewVisits.SelectedItems[0].SubItems[0].ToString();
                controller.deleteVisits(pac_id,selDate);
            }
        }
    }
}
