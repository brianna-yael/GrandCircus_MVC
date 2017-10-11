using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus_MVC
{
    class Country
    {
        List<string> countries = new List<string>();
        public Country()
        {
            countries.Add("Guatemala");
            countries.Add("China");
            countries.Add("Russia");
            countries.Add("Canada");
            countries.Add("Ghana");
            countries.Add("Italy");
        }
        public string GetCountry(int index)
        {
            return countries[index];
        }

        public List<string> GetAllCountries()
        {
            return countries;
        }
    }
}
