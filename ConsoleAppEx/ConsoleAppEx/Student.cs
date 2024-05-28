using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Student:Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }

        public Student(string name, string surname, int age, string gender, string studentID, string major)
            : base(name, surname, age, gender)
        {
            StudentID = studentID;
            Major = major;
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Student ID: {StudentID}, Major: {Major}");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} je upisao.");
        }

        public void Study(string subject)
        {
            Console.WriteLine($"{Name} je upisao {subject}.");
        }
    }
}
