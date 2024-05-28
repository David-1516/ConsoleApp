using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    class Utility
    {
        public static void DisplayPersonInfo<T>(T person) where T : Person
        {
            person.DisplayInfo();
        }
    }
}
