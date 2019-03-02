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
        public PatientDetailForm()
        {
            controller = new PatientController();
            patDetForm = this;
            InitializeComponent();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            patDetForm.Hide();
        }
    }
}
