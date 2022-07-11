using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal abstract class Dashboard
    {
        public abstract int DoctorsCount();
        public abstract int PatientsCount();
        public abstract int AppointmentsCount();
        public abstract int Earnings();

    }
}
