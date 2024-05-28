using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite podatke za studenta:");

            Console.Write("Ime: ");
            string studentName = Console.ReadLine();

            Console.Write("Prezime: ");
            string studentSurname = Console.ReadLine();

            Console.Write("Godine: ");
            int studentAge;
            while (!int.TryParse(Console.ReadLine(), out studentAge) || studentAge <= 0)
            {
                Console.WriteLine("Molimo unesite važeći broj godina.");
                Console.Write("Godine: ");
            }

            Console.Write("Pol (Muško/Žensko): ");
            string studentGender = Console.ReadLine();

            Console.Write("Broj indeksa: ");
            string studentID = Console.ReadLine();

            Console.Write("Smer: ");
            string studentMajor = Console.ReadLine();

            Student student = new Student(studentName, studentSurname, studentAge, studentGender, studentID, studentMajor);
            student.DisplayInfo();
            student.Study();
            student.Study("Math");

            Console.WriteLine();

            Console.WriteLine("Unesite podatke za zaposlenog:");

            Console.Write("Ime: ");
            string employeeName = Console.ReadLine();

            Console.Write("Prezime: ");
            string employeeSurname = Console.ReadLine();

            Console.Write("Godine: ");
            int employeeAge;
            while (!int.TryParse(Console.ReadLine(), out employeeAge) || employeeAge <= 0)
            {
                Console.WriteLine("Molimo unesite važeći broj godina.");
                Console.Write("Godine: ");
            }

            Console.Write("Pol (Muško/Žensko): ");
            string employeeGender = Console.ReadLine();

            Console.Write("Broj zaposlenog: ");
            string employeeID = Console.ReadLine();

            Console.Write("Pozicija: ");
            string employeePosition = Console.ReadLine();

            Employee employee = new Employee(employeeName, employeeSurname, employeeAge, employeeGender, employeeID, employeePosition);
            employee.DisplayInfo();
            employee.Work();
            employee.Work("research paper");

            Console.ReadKey();
        }
    }
}
