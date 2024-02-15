using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Authenticate(string userName, string password) {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "userName and password required!!";   
            }
            else {
                if ((userName=="admin") && (password=="admin@1256")) {
                    msg ="Authentication pass";
                }
                else
                {
                    msg = "Authentication fail";
                }
            }
            return "Provide user details";
        }
    }
}
