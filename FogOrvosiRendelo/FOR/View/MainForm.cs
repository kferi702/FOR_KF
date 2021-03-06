﻿using FOR.Controller;
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

        private void setWelcomeLabel() => labelWelcome.Text = controller.setWelcomeLabel(id);
        private void loadListViewPatient() => controller.loadListViewPatient(listViewPatient);
        private void textBoxSearch_TextChanged(object sender, EventArgs e) => controller.searchPatient(listViewPatient, textBoxSearch.Text);
        private void mTileNewPatient_Click(object sender, EventArgs e) => controller.addNewPatient();
        private void mTileRefreshDB_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            controller.loadListViewPatient(listViewPatient);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        /// <summary>
        /// A form aktiválásánál frissíti az adatbázist!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Activated(object sender, EventArgs e) => loadListViewPatient();
        private void listViewPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count < 0)
                return;
        }
        /// <summary>
        /// Tovább adja a törlésre kiválasztott elemet a controllernek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTileDelete_Click(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count != 0)
            {
                string selName = listViewPatient.SelectedItems[0].SubItems[0].Text;
                string selTB = listViewPatient.SelectedItems[0].SubItems[2].Text;
                controller.deletePatient(selName, selTB);
                loadListViewPatient();
            }
        }
        private void mTileDetail_Click(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count != 0)
                controller.patientDetail(listViewPatient.SelectedItems[0].SubItems[2].Text);
        }
        private void mTileVisits_Click(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count != 0)
                controller.patientVisits(listViewPatient.SelectedItems[0].SubItems[2].Text, id);
        }



    }
}
