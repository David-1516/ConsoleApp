using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Employee : Person
    {
        public string EmployeeID { get; set; }
        public string Position { get; set; }

        public Employee(string name, string surname, int age, string gender, string employeeID, string position)
            : base(name, surname, age, gender)
        {
            EmployeeID = employeeID;
            Position = position;
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeID}, Position: {Position}");
        }

        // Overloaded method
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
