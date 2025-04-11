using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment
{
    public class Doctor : Personbase
    {

        public int Age { get; set; }
        public int ExperienceYear { get; set; }

    }
    public class Appointment
    {
        private string _patient;
        public string PatientId
        {
            get
            {
                return "";
            }
            set
            {
                _patient = value;
            }
        }
        private int _doctorId = 1;
        public int DoctorId
        {
            get
            {
                return _doctorId;
            }
            set
            {
                _doctorId = value;
            }
        }
        public int DateTime { get; set; }

        public Appointment()
        {
            DoctorId = _doctorId++;
        }
    }

    interface IPerson
    {
        public string GetFullName();
        public void DisplayInfo();

    }
}
