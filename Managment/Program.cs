using System.Reflection;


namespace Managment
{
    public  class Program
    {
        static void Main(string[] args)
        {

            //    1. Yeni xəstə əlavə et
            //2. Yeni həkim əlavə et
            //3. Həkimə xəstə təyin et
            //4. Xəstələrin siyahısı
            //5. Həkimlərin siyahısı
            //6. Statistikaya bax
            //7. Çıxış
            //Seçim: _

            while (true) 
            {
                Console.WriteLine("1 Xeste elave et:");
                Console.WriteLine("2 Hekim elaver et:");
                Console.WriteLine("3 Hekime xeste teyin et:");
                Console.WriteLine("4 Xestelerin siyahisi:");
                Console.WriteLine("5 Hekimlerin siyahisi:");
                Console.WriteLine("6 Statistikaya bax:");
                Console.WriteLine("7 Cixis:");

                Console.WriteLine("Seciminizi daxil edin:");
                string secim= Console.ReadLine();

                switch (secim) 
                {
                    case "1":
                        Console.WriteLine("Xestenin adini daxil edin:");
                        string name= Console.ReadLine();
                        Console.WriteLine("Xestenin soyadini daxil edin:");
                        string surName= Console.ReadLine();
                        Patient patient = new Patient()
                        {  
                            Name=name,
                            SurName=surName,
                        };
                        DBCtext.AddNewPatient(patient);
                        break;
                        case "2":
                        Console.WriteLine("Hekim adini daxil et :");
                        string doctorname=Console.ReadLine();
                        Console.WriteLine("Hekimin soyadini daxil edin :");
                        string surname=Console.ReadLine();
                    
                        Doctor doktor = new Doctor()
                        {
                            Name=doctorname,
                            SurName =surname,
                           
                        };
                        DBCtext.AddNewDoctor(doktor);
                        break;
                        case "3":
                        Console.WriteLine("Hekimin id teyin et:");
                        int hekimId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Xestenin adini daxil edin:");
                        string xesteId = Console.ReadLine();
                        Appointment appointment = new Appointment()
                        {
                            DoctorId = hekimId,
                            PatientId = xesteId,

                        };
                       
                        break;
                        case "4":
                        foreach (var item in DBCtext.patients)
                        {
                            item.DisplayInfo();
                        }
                        
                        break;
                        
                        case "5":
                       foreach(var item in DBCtext.doctors)
                        { item.DisplayInfo(); }                      
                        break;

                    case "6":
                        Console.Write("doxtor Sayi:");
                        Console.WriteLine(HospitalStats.TotalDoctorCount());
                        Console.Write("pasient Sayi:");
                        Console.WriteLine(HospitalStats.TotalPatientCount());
                        Console.Write("apointment Sayi:");
                        Console.WriteLine(HospitalStats.TotalAppointmentCount());
                        break;

                    case "7":
                        return;
                }
            }

            
        }

    }

    //            *Management App daxilində aşağıdaki Enum-lar olmalıdır:

    //        Department: Terapiya, Cərrahiyyə, Pediatriya, Kardiologiya

    //        Gender: Male, Female, Attack Helicopter

    //*Management App daxilində aşağıdaki Abstract class və onların davranışları olmalıdır:

    //PersonBase: Id,Name,Surname,Gender

    //* Management App daxilində aşağıdaki Class-lar və onların xüsusiyyət&davranışları olmalıdır:

    //Patient : Id,Name,Surname,Age,Gender
    //Doctor : Id,Name,Surname,Age,ExperienceYear,Gender,DepartmentEnum

    //Appointment : PatientId,DoctorId,DateTime


    //* Management App daxilində aşağıdaki Interface və onların davranışları olmalıdır:
    //IPerson :
    //string GetFullName();
    //        void DisplayInfo();

    //        void IDisplayable()

    //* Management App daxilində aşağıdaki Static class və onların xüsusiyyətləri olmalıdır:

    //HospitalStats : TotalPatientCount,TotalDoctorCount,TotalAppointmentCount

    //* Management App daxilində yarana biləcək Exceptionların qarşısı alınmalıdır





    //        Xəstəxana İdarəetmə Layihesi
    // Randevu : PatientId,DoctorId,DateTime(bu property-' DateTime.Now dəyərini mənimsətməyiniz lazımdır)

    // *ce Management
    // IP və App
    // : GetFullName();
    //        etibarsız DisplayInfo();

    //        void IDisplayable()

    // * İdarəetmə Tətbiqi əlavə olaraq Statik sinif və onların xüsusiyyətləri olmalıdır:

    // * Management App əlavə olaraq yarana biləcək istisnalara qarşı alınmalıdır

    //DBContext adı altında sinif yaradılacaq.Daxilində Patient, Doctor və Appointment static array-lər saxlanacaq.
    //Həmçinin sinifdə belə davranışlar olmalıdır.
    //void AddNewPatient(Xəstə xəstə);
    //        etibarsız AddNewDoctor(Doktor həkim);
    //        etibarsız AddNewAppointment(Təyin təyini);

    //        Patient[] GetAllPatient();
    //        Doktor[] GetAllDoctor();
    //        Appointment[] GetAllAppointment(();



    //    1. Yeni xəstə əlavə et
    //2. Yeni həkim əlavə et
    //3. Həkimə xəstə təyin et
    //4. Xəstələrin siyahısı
    //5. Həkimlərin siyahısı
    //6. Statistikaya bax
    //7. Çıxış
    //Seçim: _




}
