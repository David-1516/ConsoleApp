using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, string surname, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Gender: {Gender}");
        }
    }
}
