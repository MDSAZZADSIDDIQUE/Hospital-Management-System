using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    internal static class PasswordValidation
    {
        public static bool verifyPassword(string username, string password)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=Likhon;Initial Catalog=Hospital Management System;Integrated Security=True";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from UserInformation where EmailAddress=@usr and Password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", username);
            scmd.Parameters.AddWithValue("@pwd", password);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
                return true;
            else
                return false;
            scn.Close();
        }
    }
}
