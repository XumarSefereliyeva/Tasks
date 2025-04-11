using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment
{
    public static class DBCtext
    {

        //DBContext adı altında sinif yaradılacaq.Daxilində Patient, Doctor və Appointment static array-lər saxlanacaq.
        //Həmçinin sinifdə belə davranışlar olmalıdır.
        //void AddNewPatient(Xəstə xəstə);
        //        etibarsız AddNewDoctor(Doktor həkim);
        //        etibarsız AddNewAppointment(Təyin təyini);

        //        Patient[] GetAllPatient();
        //        Doktor[] GetAllDoctor();
        //        Appointment[] GetAllAppointment(();


        public static string Patient;
        public static string Doctor;

        
       public static Appointment[] appointments = new Appointment[0];
        public static Patient[] patients = new Patient[0];
        public static Doctor[] doctors = new Doctor[0];

        public static void AddNewPatient(Patient patient)
        {

            Array.Resize(ref patients, patients.Length + 1);
            patients[patients.Length - 1] = patient;
            HospitalStats.pathientCount++;
        }
        public static void AddNewDoctor(Doctor doctor)
        {
            Array.Resize(ref doctors, doctors.Length + 1);
            doctors[doctors.Length - 1] = doctor;
            HospitalStats.doctorCount++;    
        }
        public static void AddNewAppointment(Appointment appointment)
        {
            Array.Resize(ref appointments, appointments.Length + 1);
            appointments[appointments.Length - 1] = appointment;
            HospitalStats.appointmentCount++;
        }

        public static Patient[] GetAllPatient()
        {
            return patients;
        }
        public static Doctor[] GetAllDoctor()
        {
            return doctors;
        }
        public static Appointment[] GetAllappointment()
        {
            return appointments;
        }

        

    }
}
