using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus_MVC
{
    class Controller
    {
        Country m;
        Guatemala cm;
        View v;
        public Controller()
        {
            m = new Country();
            cm = new Guatemala();
            v = new View();
        }

        public void DisplayCountry()
        {
            v.DisplayCountry(m.GetAllCountries());

        }
    }
}

