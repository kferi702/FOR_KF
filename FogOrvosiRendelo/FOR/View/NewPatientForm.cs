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

namespace FOR
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
            InitializeComponent();
            controller = new PatientController();
            getFromForm();

             
        }

        public bool getFromForm()
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

            return controller.checkData(firstName, lastName, zipCode, city, street, houseNumber, mother, birthName, birthPlace, birthDate, tb, phone, email,comment);
        }

        private void mTileCancel_Click(object sender, EventArgs e) => controller.hideForm(this);

        private void mTileSave_Click(object sender, EventArgs e)
        {
            if (getFromForm())
            {
                controller.saveNewPatient(firstName, lastName, zipCode, city, street, houseNumber, mother, birthName, birthPlace, birthDate, tb, phone, email, comment);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás adatok!", "Hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
