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
    public partial class MainForm : MetroForm
    {
        public int id;
        MainForm mainF;
        MainController controller;


        public MainForm(int id)
        {
            controller = new MainController();
            InitializeComponent();
            mainF = this;
            this.id = id;
            setWelcomeLabel();
            loadListViewPatient();
        }
        private void setWelcomeLabel()
        {
            labelWelcome.Text=controller.setWelcomeLabel(id);
        }
        private void loadListViewPatient()
        {
            controller.loadListViewPatient(listViewPatient);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listViewPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count < 0)
                return;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loadListViewPatient();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            controller.searcPatient(listViewPatient, search);
        }
    }
}
