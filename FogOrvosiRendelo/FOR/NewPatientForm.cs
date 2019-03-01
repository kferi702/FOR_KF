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
        string nameTitle;
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

        public NewPatientForm()
        {
            newPF = this;
            InitializeComponent();
            checkData();

             nameTitle = comboBoxNameTitle.SelectedText;
             firstName = textBoxNameFirst.Text;
             lastName = textBoxNameLast.Text;

             zipCode = textBoxAddressZip.Text;
             city = textBoxAddressCity.Text;
             street = textBoxAddressStreet.Text;
             houseNumber = textBoxAddressHouseNumber.Text;

             mother = textBoxBirthMotherName.Text;
             birthName = textBoxBirthName.Text;
             birthPlace = textBoxBirthPlace.Text;
             birthDate = calendatBirthDate.SelectionRange.Start.ToString();

             tb = textBoxDataTB.Text;
             phone = textBoxDataPhone.Text;
             email = textBoxDataEmail.Text;
        }

        public bool checkData() => controller.checkData(nameTitle, firstName, lastName, zipCode, city, street, houseNumber, mother, birthName, birthPlace, birthDate, tb, phone, email);

        private void mTileCancel_Click(object sender, EventArgs e) => newPF.Hide();

        private void mTileSave_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                controller.saveNewPatient(nameTitle, firstName, lastName, zipCode, city, street, houseNumber, mother, birthName, birthPlace, birthDate, tb, phone, email);
            }
            else
            {
                MessageBox.Show("Hibás adatok!", "Hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
