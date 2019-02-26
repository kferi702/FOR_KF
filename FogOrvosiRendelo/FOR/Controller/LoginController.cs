using FOR.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FOR;
using System.Windows.Forms;


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
            model.loginModel(userName, passWord, loginF);
        }
    }
}
