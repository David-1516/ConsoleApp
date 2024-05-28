using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    public class Student : Person, IStudiable
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
            Console.WriteLine($"Ime: {Name}, Prezime: {Surname}, Dob: {Age}, Spol: {Gender}, Student ID: {StudentID}, Smijer studija: {Major}");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} studira.");
        }

        public void Study(string subject)
        {
            Console.WriteLine($"{Name} studira na {subject}.");
        }
    }
}
