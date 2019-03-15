using FOR.Controller;
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

namespace FOR.View
{
    public partial class NewPatientForm : MetroForm
    {
        NewPatientForm newPF;
        PatientController controller;
        string firstName;
        string lastName;
        string zipCode;
        string city;
        string street;
        string houseNumber;
        string mother;
        string birthName;
        string birthPlace;
        string birthDate;
        string tb;
        string phone;
        string email;
        string comment;

        public NewPatientForm()
        {
            newPF = this;
            newPF.TopMost=true;
            InitializeComponent();
            controller = new PatientController();
            getFromForm();
        }
        private void mTileCancel_Click(object sender, EventArgs e)
        {
            if (!emptyTextBox())
            {
                controller.hideForm(this);
            }
            else
            {
                DialogResult result =MessageBox.Show("A adatlap elnem mentett adatokat tartalmaz! Biztosan kiszeretne lépni az új paciens felvétel elött?", "Ablak bezárása", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result==DialogResult.Yes)
                    controller.hideForm(this);
            }
            
        }
        /// <summary>
        /// Ellenörzi a textboxok tartalmát hogy nem üresek-e.
        /// </summary>
        /// <returns>true ha üresek, false ha tartalmaz szöveget</returns>
        public bool emptyTextBox()
        {
            if (textBoxNameFirst.Text.Trim() == "")
                return true;
            if (textBoxNameLast.Text.Trim() == "")
                return true;
            if (textBoxAddressZip.Text.Trim() == "")
                return true;
            if (textBoxAddressCity.Text.Trim() == "")
                return true;
            if (textBoxAddressStreet.Text.Trim() == "")
                return true;
            if (textBoxAddressHouseNumber.Text == "")
                return true;
            if (textBoxBirthMotherName.Text.Trim() == "")
                return true;
            if (textBoxBirthPlace.Text.Trim() == "")
                return true;
            if (textBoxDataTB.Text.Trim() == "")
                return true;
            if (textBoxDataPhone.Text.Trim() == "")
                return true;
            return  false;
        }
        /// <summary>
        /// Trimmeli és ellenörzi a textboxokban lévő értékeket. Hibás értéket jelzi!
        /// </summary>
        public void getFromForm()
        {
            firstName = textBoxNameFirst.Text.Trim();
            lastName = textBoxNameLast.Text.Trim();

            zipCode = textBoxAddressZip.Text.Trim();
            city = textBoxAddressCity.Text.Trim();
            street = textBoxAddressStreet.Text.Trim();
            houseNumber = textBoxAddressHouseNumber.Text.Trim();

            mother = textBoxBirthMotherName.Text.Trim();
            birthName = textBoxBirthName.Text.Trim();
            birthPlace = textBoxBirthPlace.Text.Trim();
            birthDate = calendatBirthDate.SelectionRange.Start.ToShortDateString();

            tb = textBoxDataTB.Text.Trim();
            phone = textBoxDataPhone.Text.Trim();
            email = textBoxDataEmail.Text.Trim();
            comment = textBoxComment.Text.Trim();
        }
        /// <summary>
        /// Ellenörzésre küldi a getFromForm metódusba majd elmenti ha az értékek helyesek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTileSave_Click(object sender, EventArgs e)
        {
            getFromForm();
            if (controller.checkData(firstName, lastName, zipCode, city, street, houseNumber, mother, birthName, birthPlace, birthDate, tb, phone, email, comment)==false)
            {
                controller.saveNewPatient(firstName, lastName, zipCode, city, street, houseNumber, mother, birthName, birthPlace, birthDate, tb, phone, email, comment);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás vagy hiányos adatok! (A mezők kitöltése kötelező!)", "Hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
