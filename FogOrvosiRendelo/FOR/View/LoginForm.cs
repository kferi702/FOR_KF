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
    public partial class LoginForm : MetroForm
    {
        LoginController controller;
        public LoginForm loginF;

        public LoginForm()
        {
            controller = new LoginController();
            loginF = this;
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }
        private void mTileLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string passWord = textBoxPassword.Text;
            controller.loginController(userName, passWord, loginF);
        }
    }
}
