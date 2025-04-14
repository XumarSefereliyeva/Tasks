using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;

public class Student
{
    //            Student class
    //- FullName
    //- GroupNo
    //- AvgPoint
    //- HasDigit() - parametr olaraq string dəyər qəbul edib o dəyərdə rəqəm varsa geriyə true yoxdusa false qaytaran metod
    //- HasUpper() - parametr olaraq string dəyər qəbul edib o dəyərdə uppercase varsa geriyə true yoxdursa false qaytaran metod
    //FullName dəyəri təyin olunmamış student yaradıla bilminməməlidir
   

    public string Name;
    public string Surname;
    public string GroupNo;
    public double AvgPoint;

    public Student(string name,string Surname )
    {
       Name = name;
        this.Surname = Surname;
    }

    public void ShowFullData()
    {
        Console.WriteLine($"Ad Soyad:{Name} {Surname}");
    }
    public bool HasDigit(string s)
    {
        foreach (char c in s)
        {
            if(c == 0) return true;  
        }
        return false;

    }
    public bool HasUpper(string s)
    {
        foreach (var item in s)
        {
            if(item == 'A')
            {
                return true;
            }
        }

        return false;
    }
}
