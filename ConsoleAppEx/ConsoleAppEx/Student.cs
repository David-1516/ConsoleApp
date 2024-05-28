using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    public class Employee : Person, IWorkable
    {
        public string EmployeeID { get; set; }
        public string Position { get; set; }

        public Employee(string name, string surname, int age, string gender, string employeeID, string position)
            : base(name, surname, age, gender)
        {
            EmployeeID = employeeID;
            Position = position;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Ime: {Name}, Prezime: {Surname}, Ime: {Age}, Spol: {Gender}, Zaposlenik ID: {EmployeeID}, Pozicija: {Position}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} radi na.");
        }

        public void Work(string task)
        {
            Console.WriteLine($"{Name} radi na {task}.");
        }
    }
}
