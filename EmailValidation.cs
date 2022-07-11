using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal static class EmailValidation
    {
        public static bool verifyEmail(string email)
        {
            string emailAddress = email.Trim().ToLower();
            if (emailAddress.Contains("@") && emailAddress.Contains(".com") && !(emailAddress.IndexOf("@") == 0) && emailAddress.IndexOf(".com") > emailAddress.IndexOf("@") && !(emailAddress.IndexOf(".com") == emailAddress.IndexOf("@") + 1))
                return true;
            else
                return false;
        }
    }
}
