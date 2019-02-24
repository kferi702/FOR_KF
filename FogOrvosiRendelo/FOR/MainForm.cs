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

        }
        public void setWelcomeLabel()
        {
            welcomeLabel.Text=controller.setWelcomeLabel(id);
        }
    }
}
