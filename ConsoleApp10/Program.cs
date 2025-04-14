using System.Reflection.Metadata;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Student class
            //- FullName
            //- GroupNo
            //- AvgPoint
            //- HasDigit() - parametr olaraq string dəyər qəbul edib o dəyərdə rəqəm varsa geriyə true yoxdusa false qaytaran metod
            //- HasUpper() - parametr olaraq string dəyər qəbul edib o dəyərdə uppercase varsa geriyə true yoxdursa false qaytaran metod

            //Group class
            //- No
            //- Students
            //- AddStudent()
            //- SearchStudent()
            //- StudentLimit

            //Student class yaradırsınız və bu xüsusiyyətləri olur : FullName,GroupNo,AvgPoint.FullName
            //FullName dəyəri təyin olunmamış student yaradıla bilminməməlidir

            //Group class yaradırsınız və bu xüsusiyyətləri olur: No - qrupun nömrəsini ifadə edir, Studnets - groupdakı tələbələrdən ibarət array-dir,\n
            //AddStudent() - bir studnet obyekti qəbul edir parametr olarq və qəbul etdiyi student obyektini Students array-ə əlavə edir(əgər StudentLimit aşılmırsa), StudentLimit - qrupdakı tələbə limitini ifadə edir

            //Proqram işə düşdükdə birdən group yaraqlaq üçün No fəyərini və StudentLimit dəyərini daxil etməyimizi istəməlidir.
            //No dəyəri 2 böyük hərflə başlamalı və sonrasında 3 rəqəm olmalıdır (BP202 kimi)
            //StudentLimit 0-dan kiçik və 20-dən böyük ola bilməz
            Group groups = new Group();
            Student students = new Student("Xumar", "Sefereliyeva");
            groups.AddStudent(students);

           
            groups.SearchStudent();
            
            Console.WriteLine(students.HasDigit("AB206"));
            Console.WriteLine(students.HasUpper("AB206"));
          
           
           


        }
}
}
