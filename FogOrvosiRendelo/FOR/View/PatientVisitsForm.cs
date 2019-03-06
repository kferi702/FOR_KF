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
        string pat_id;
        string text;

        public PatientVisitsForm(string tb)
        {
            InitializeComponent();
            controller = new PatientController();
            controller.loadPatientDetail(tb);
            this.tb = tb;
            patVisForm = this;
            text = mTextboxMessage.Text;
            pat_id = controller.getPatientID();
            setLabel();
            loadPatientVisits();
        }

        private void loadPatientVisits() => controller.loadListViewVisits(pat_id,listViewVisits);
        private void setLabel() => labelPacientName.Text = controller.getPatientName()+" nevű páciens kórtörténete!";
        private void metroTile2_Click(object sender, EventArgs e) => controller.hideForm(this);
        private void mTileNewVisits_Click(object sender, EventArgs e) => controller.newVisits(pat_id,text);
        private void listViewVisits_Click(object sender, EventArgs e) => setTextBoxMessage(controller.showSelectedVisits(listViewVisits.SelectedItems[0].SubItems[0].Text));
        private void mTileDelete_Click(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count != 0)
            {
                string selDate = listViewVisits.SelectedItems[0].SubItems[0].ToString();
                controller.deleteVisits(pat_id,selDate);
            }
        }
        private void setTextBoxMessage(string message)
        {
            mTextboxMessage.Text = message;
        }
        private void listViewVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count < 0)
            {
                return;
            }
                
        }

    }
}
