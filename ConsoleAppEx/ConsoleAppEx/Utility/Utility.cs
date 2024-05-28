using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Utility
    {
        private static List<Person> peopleList = new List<Person>();
        public static void DisplayPersonInfo<T>(T person) where T : Person
        {
            person.DisplayInfo();
        }
        public static void DisplayPeopleList()
        {
            Console.WriteLine("Lista osoba:");
            foreach (var person in peopleList)
            {
                DisplayPersonInfo(person);
            }
        }
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
        public static void AddPerson(Person person)
        {
            peopleList.Add(person);
            Console.WriteLine("Osoba uspješno dodana.");
        }

        public static void UpdatePerson(string name, Person updatedPerson)
        {
            int index = peopleList.FindIndex(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (index != -1)
            {
                peopleList[index] = updatedPerson;
                Console.WriteLine("Osoba uspješno ažurirana.");
            }
            else
            {
                Console.WriteLine("Osoba nije pronađena.");
            }
        }

        public static void DeletePerson(string name)
        {
            int index = peopleList.FindIndex(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (index != -1)
            {
                peopleList.RemoveAt(index);
                Console.WriteLine("Osoba uspješno obrisana.");
            }
            else
            {
                Console.WriteLine("Osoba nije pronađena.");
            }
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
