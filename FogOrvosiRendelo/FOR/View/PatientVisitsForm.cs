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
            patVisForm.TopMost = true;
            setLabel();
            loadPatientVisits();
            mTextboxMessage.Enabled = false;
            mTileVisitsEditSave.Enabled = false;
        }
        private void loadPatientVisits() => controller.loadListViewVisits(controller.getPatientID(), listViewVisits);
        private void setLabel() => labelPacientName.Text = controller.getPatientName() + " nevű páciens kórtörténete!";
        private void metroTile2_Click(object sender, EventArgs e) => controller.hideForm(this);
        /// <summary>
        /// Üzenet kimentése a szövegdobozból(Ez menti el!)
        /// </summary>
        /// <param name="message"></param>
        private void getTextBoxMessage(string message) => mTextboxMessage.Text = message;
        /// <summary>
        /// Kiválaszott dátom alapján a szövegdoboz feltöltése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewVisits_Click(object sender, EventArgs e) => getTextBoxMessage(controller.getSelectedVisits(listViewVisits.SelectedItems[0].SubItems[0].Text));
        /// <summary>
        /// Törli a kiválasztott bejegyzést
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTileDelete_Click(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count != 0)
            { 
            controller.deleteVisits(listViewVisits.SelectedItems[0].SubItems[0].Text);
            loadPatientVisits();
            }
        }
        private void listViewVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewVisits.SelectedItems.Count < 0)
                return;    
        }
        /// <summary>
        /// Új bejegyzés előkészítése(mentés engedélyezése, szövegdoboz kiürítése)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTileNewVisits_Click(object sender, EventArgs e)
        {
            mTextboxMessage.Enabled = true;
            mTextboxMessage.Clear();
            mTileVisitsEditSave.Enabled = true;
        }
        /// <summary>
        /// Új bejegyzés mentése, aktiális dátummal és idővel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTileVisitsEditSave_Click(object sender, EventArgs e)
        {
                controller.newVisits(controller.getPatientID(), mTextboxMessage.Text);
                mTextboxMessage.Enabled = false;
                mTileVisitsEditSave.Enabled = false;
                loadPatientVisits();
        }
    }
}
