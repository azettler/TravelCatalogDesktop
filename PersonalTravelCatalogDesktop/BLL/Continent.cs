using PersonalTravelCatalogDesktop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTravelCatalogDesktop
{
    public class Continent : ILocation
    {
        public List<Country> countries { get; set; }

        public Continent()
        {
            id = -1;
            name = "";
            countries = new List<Country>();
            visited = false;
        }

        public Continent(int id, string name)
        {
            this.id = id;
            this.name = name;
            countries = new List<Country>();
            visited = false;
        }

        public void AddCountry(int id, string countryName, string desc)
        {
            countries.Add(new Country(id, countryName, desc));
        }

        public override string ToString()
        {
            return name;
        }

        public string ListCountries()
        {
            string result = "";

            foreach (var country in countries)
            {
                result += country.ToString() + Environment.NewLine;
            }

            return result;
        }

        public List<Country> GetCountries()
        {
            return countries;
        }
    }
}
