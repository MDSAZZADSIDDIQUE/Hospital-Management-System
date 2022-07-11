using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    internal class Display : Dashboard
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=Likhon;Initial Catalog=Hospital Management System;Integrated Security=True");
        public override int AppointmentsCount()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(DISTINCT PatientID) FROM Appointments", sqlConnection);
            Int32 appointmentsCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return appointmentsCount;
        }

        public override int DoctorsCount()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(DISTINCT ID) FROM Doctors", sqlConnection);
            Int32 doctorsCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return doctorsCount;
        }

        public override int PatientsCount()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(DISTINCT ID) FROM Patients", sqlConnection);
            Int32 patientsCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return patientsCount;
        }

        public override int Earnings()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT SUM(Total) FROM Bills", sqlConnection);
            Int32 patientsCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return patientsCount;
        }
    }
}
