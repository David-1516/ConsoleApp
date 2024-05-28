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
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Unesite podatke za studenta");
                Console.WriteLine("2 - Unesite podatke za zaposlenog");
                Console.WriteLine("0 - Izlaz");
                Console.Write("Vaš odabir: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Student student = Utility.CreateStudent();
                        Utility.DisplayPersonInfo(student);
                        student.Study();
                        student.Study("Matematiku");
                        break;
                    case "2":
                        Employee employee = Utility.CreateEmployee();
                        Utility.DisplayPersonInfo(employee);
                        employee.Work();
                        employee.Work("predavanje i istraživanje");
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nevažeća opcija. Molimo pokušajte ponovno.");
                        break;
                }
                Console.WriteLine();

            }

        }
    }
}
