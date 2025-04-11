using Managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace Managment
{
    public abstract class Personbase : IPerson
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string SurName { get; set; }
        public Gender Gender { get; set; }


        public string GetFullName()
        {
            return $"{Name} {SurName}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} {SurName} {Gender} {Id}");
        }


    }
    public class Patient : Personbase
    {

     

    }
}
