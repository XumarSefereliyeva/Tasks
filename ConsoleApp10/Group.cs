using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;

public  class Group
{
    //Group class
    //- No
    //- Students
    //- AddStudent()
    //- SearchStudent()
    //- StudentLimit

    //Proqram işə düşdükdə birdən group yaraqlaq üçün No fəyərini və StudentLimit dəyərini daxil etməyimizi istəməlidir.
    //No dəyəri 2 böyük hərflə başlamalı və sonrasında 3 rəqəm olmalıdır (BP202 kimi)
    //StudentLimit 0-dan kiçik və 20-dən böyük ola bilməz

  
     string _no;
    public string No
    {
        get
        {
            return _no;
        }
        set
        {
            if (value.Length != 5)
            {
                return;
            }

            if (!(value[0] >= 'A' && value[0] <= 'Z')) return;
            if (!(value[1] >= 'A' && value[1] <= 'Z')) return;
            if (!(value[2] >= '0' && value[2] <= '9')) return;
            if (!(value[3] >= '0' && value[3] <= '9')) return;
            if (!(value[4] >= '0' && value[4] <= '9')) return;
            _no = value;
        }
    }
    public  Student[] students = new Student[0];
     int _studentLimit;
    public int StudentCount
    {
        get
        {
           return _studentLimit;
                
        }
        set
        {
            if(value >0 && value<20) 
                _studentLimit = value;
        }
    }
    public void AddStudent(Student s)
    {
        Array.Resize(ref students, students.Length+1);
        students[students.Length - 1] = s;

    }
    public void SearchStudent()
    {
        Console.WriteLine("Adinizi daxil edin:");
        string studentName=Console.ReadLine();
        Console.WriteLine("Soyadinizi daxil edin:");
        string studentSurName=Console.ReadLine();
        foreach (Student s in students)
        {
            if (s.Name==studentName && s.Surname== studentSurName)
            {
                s.ShowFullData();
            }
            else
            {
                Console.WriteLine("Tapilmadi");
            }
        }
    }
    
}
