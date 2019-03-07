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

        public PatientVisitsForm(string tb)
        {
            InitializeComponent();
            controller = new PatientController();
            controller.loadPatientDetail(tb);
            this.tb = tb;
            patVisForm = this;
            setLabel();
            loadPatientVisits();
            mTextboxMessage.Enabled = false;
            mTileVisitsEditSave.Enabled = false;
        }
        private void loadPatientVisits() => controller.loadListViewVisits(controller.getPatientID(), listViewVisits);
        private void setLabel() => labelPacientName.Text = controller.getPatientName() + " nevű páciens kórtörténete!";
        private void metroTile2_Click(object sender, EventArgs e) => controller.hideForm(this);
        private void listViewVisits_Click(object sender, EventArgs e) => getTextBoxMessage(controller.getSelectedVisits(listViewVisits.SelectedItems[0].SubItems[0].Text));
        private void mTileDelete_Click(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count != 0)
            { 
            controller.deleteVisits(listViewVisits.SelectedItems[0].SubItems[0].Text);
            loadPatientVisits();
            }
        }
        private void getTextBoxMessage(string message) => mTextboxMessage.Text = message;
        private void listViewVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count < 0)
                return;    
        }
        private void mTileNewVisits_Click(object sender, EventArgs e)
        {
            mTextboxMessage.Enabled = true;
            mTextboxMessage.Clear();
            mTileVisitsEditSave.Enabled = true;
        }
        private void mTileVisitsEditSave_Click(object sender, EventArgs e)
        {
                controller.newVisits(controller.getPatientID(), mTextboxMessage.Text);
                mTextboxMessage.Enabled = false;
                mTileVisitsEditSave.Enabled = false;
                loadPatientVisits();
        }
    }
}
