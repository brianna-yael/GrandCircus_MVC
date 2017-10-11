using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus_MVC
{
    class View
    {
        public void PrintCountry(string s)
        {
            Console.WriteLine("Hello " + s);
        }

        public void DisplayCountry(List<string> countries)
        {
            foreach (string country in countries)
            {
                Console.WriteLine("Hello " + country);
            }
        }
    }
}
