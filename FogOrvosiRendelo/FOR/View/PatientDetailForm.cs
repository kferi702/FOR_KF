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
    public partial class PatientDetailForm : MetroForm
    {
        PatientController controller;
        PatientDetailForm patDetForm;
        string tb;
        public PatientDetailForm(string tb)
        {
            this.tb = tb;
            controller = new PatientController();
            patDetForm = this;
            InitializeComponent();
            loadPatientDetail();
        }

        private void metroTile1_Click(object sender, EventArgs e) => patDetForm.Hide();
        private void loadPatientDetail() => controller.loadPatientDetail(tb);
        private void setPatientLabel() => controller.setPatientLabel();
    }
}
