using FOR.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FOR;
using System.Windows.Forms;
using FOR.View;

namespace FOR.Controller
{
    class LoginController
    {
        LoginModel model;

        public LoginController()
        {
            model = new LoginModel();
        }
        public void loginController(string userName, string passWord, LoginForm loginF)
        {
            if(check(userName)&&check(passWord))
                model.loginModel(userName, passWord, loginF);
        }
        /// <summary>
        /// Bejelentkezési adatok ellenörzése hogy ki vannak-e töltve.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool check(string text)
        {
            if (text == "")
            { 
                DialogResult dialog = MessageBox.Show("Felhasználóinév és jelszó megadása kötelező!","HIÁNY!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
