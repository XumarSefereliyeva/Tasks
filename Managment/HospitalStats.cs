using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment
{
    public class HospitalStats
    {
        public static int  pathientCount;
        public static int  doctorCount;
        public static int appointmentCount;

        public static int TotalPatientCount()
        {
            return pathientCount;
        }
        public static int TotalDoctorCount()
        {
            return doctorCount;
        }
        public static int TotalAppointmentCount()
        {
            return appointmentCount;
        }
    }
}
