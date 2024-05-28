using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Functions
    {
        public static Student CreateStudent()
        {
            Console.WriteLine("Unesite podatke za studenta:");

            string studentName = Prompt("Ime");
            string studentSurname = Prompt("Prezime");
            int studentAge = PromptInt("Godine");
            string studentGender = Prompt("Pol (Muško/Žensko)");
            string studentID = Prompt("Broj indeksa");
            string studentMajor = Prompt("Upisani smjer studija");

            return new Student(studentName, studentSurname, studentAge, studentGender, studentID, studentMajor);
        }

        public static Employee CreateEmployee()
        {
            Console.WriteLine("Unesite podatke za zaposlenog:");

            string employeeName = Prompt("Ime");
            string employeeSurname = Prompt("Prezime");
            int employeeAge = PromptInt("Godine");
            string employeeGender = Prompt("Pol (Muško/Žensko)");
            string employeeID = Prompt("Broj zaposlenog");
            string employeePosition = Prompt("Pozicija");

            return new Employee(employeeName, employeeSurname, employeeAge, employeeGender, employeeID, employeePosition);
        }

        private static string Prompt(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }

        private static int PromptInt(string message)
        {
            int value;
            Console.Write($"{message}: ");
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Molimo unesite važeći broj.");
                Console.Write($"{message}: ");
            }
            return value;
        }
    }
}
