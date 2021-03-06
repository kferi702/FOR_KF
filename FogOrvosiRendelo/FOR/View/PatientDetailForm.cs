﻿using MetroFramework.Forms;
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
    public partial class PatientDetailForm : MetroForm
    {
        PatientController controller;
        PatientDetailForm patDetForm;
        string tb;
        bool editable;
        string pac_id;

        /// <summary>
        /// Form betöltése
        /// </summary>
        /// <param name="tb">A MainForm kiválasztott páciensének azonosító adata</param>
        public PatientDetailForm(string tb)
        {
            controller = new PatientController();
            controller.loadPatientDetail(tb);
            this.tb = tb;
            patDetForm = this;
            patDetForm.TopMost = true;
            InitializeComponent();
            loadPatientDetail();
            textboxEditable();
            pac_id = controller.getPatientID();
        }
        private void mTileCancel_Click(object sender, EventArgs e) => controller.hideForm(this);
        /// <summary>
        /// Feltölti a textboxokat az adatbázisból
        /// </summary>
        private void loadPatientDetail() { 
            labelPatientName.Text ="Páciens neve "+controller.getPatientName();
            mTextboxName.Text = controller.getPatientName();
            mTextboxAddress.Text = controller.getPatientAddress();
            mTextboxBirthDate.Text = controller.getPatientBirthDate();
            mTextboxBirthPlace.Text = controller.getPatientBirthPlace();
            mTextboxBirthName.Text = controller.getPatientBirthName();
            mTextboxMother.Text = controller.getPatientMother();
            mTextboxTB.Text = controller.getPatientTB();
            mTextboxPhone.Text = controller.getPatientPhone();
            mTextboxEmail.Text = controller.getPatientEmail();
            mTextboxComment.Text = controller.getPatientComment();
        }
        /// <summary>
        /// Kikapcsolja a szerkeszthetőséget a textboxokról
        /// </summary>
        private void textboxEditable()
        {
                editable = false;
                mTileEditSave.Style = MetroFramework.MetroColorStyle.Blue;
                mTileEditSave.Text = "Szerkesztés";
                mTextboxName.Enabled = false;
                mTextboxAddress.Enabled = false;
                mTextboxBirthDate.Enabled = false;
                mTextboxBirthPlace.Enabled = false;
                mTextboxBirthName.Enabled = false;
                mTextboxMother.Enabled = false;
                mTextboxTB.Enabled = false;
                mTextboxPhone.Enabled = false;
                mTextboxEmail.Enabled = false;
                mTextboxComment.Enabled = false;


        }
        /// <summary>
        /// Ellenörzi az adatok helyességét és ha rendben találja elmenti azokat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTileEditSave_Click(object sender, EventArgs e)
        {
            
            if (editable == false)
            {
                mTextboxName.Enabled = true;
                mTextboxAddress.Enabled = true;
                mTextboxBirthDate.Enabled = true;
                mTextboxBirthPlace.Enabled = true;
                mTextboxBirthName.Enabled = true;
                mTextboxMother.Enabled = true;
                mTextboxTB.Enabled = true;
                mTextboxPhone.Enabled = true;
                mTextboxEmail.Enabled = true;
                mTextboxComment.Enabled = true;
                editable = true;
                mTileEditSave.Style = MetroFramework.MetroColorStyle.Green;
                mTileEditSave.Text = "Mentés";

            }
            else
            {
                string name = mTextboxName.Text;
                string address = mTextboxAddress.Text;
                string birthDate = mTextboxBirthDate.Text;
                string birthPlace = mTextboxBirthPlace.Text;
                string birthName = mTextboxBirthName.Text;
                string mother = mTextboxMother.Text;
                string tb = mTextboxTB.Text;
                string phone = mTextboxPhone.Text;
                string email = mTextboxEmail.Text;
                string comment = mTextboxComment.Text;
                
                controller.savePatientDetail(name, address, birthDate, birthPlace, birthName, mother, tb, phone, email, comment);
                textboxEditable();
            }

        }
    }
}
