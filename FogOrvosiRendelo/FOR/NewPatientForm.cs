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
        public NewPatientForm()
        {
            newPF = this;
            InitializeComponent();
        }

        private void mTileCancel_Click(object sender, EventArgs e)
        {
            newPF.Hide();

        }
    }
}
