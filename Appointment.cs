using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Appointment
    {
        private string patientID;
        private string departmentName;
        private string doctorName;
        private DateTime appointmentDate;
        private int serialNo;
        private string problem;
        private string status;

        public Appointment()
        {

        }

        public Appointment(string patientID, string departmentName, string doctorName, DateTime appointmentDate, int serialNo, string problem, string status)
        {
            this.patientID = patientID;
            this.departmentName = departmentName;
            this.doctorName = doctorName;
            this.appointmentDate = appointmentDate;
            this.serialNo = serialNo;
            this.problem = problem;
            this.status = status;
        }

        public string PatientID { get => patientID; set => patientID = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public int SerialNo { get => serialNo; set => serialNo = value; }
        public string Problem { get => problem; set => problem = value; }
        public string Status { get => status; set => status = value; }
    }
}
