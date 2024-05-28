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
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Gender: {Gender}, Employee ID: {EmployeeID}, Position: {Position}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }

        public void Work(string task)
        {
            Console.WriteLine($"{Name} is working on {task}.");
        }
    }
}
