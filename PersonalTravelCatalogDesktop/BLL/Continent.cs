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
        public List<Country> Countries { get; set; }

        public Continent()
        {
            Id = -1;
            Name = "";
            Description = "";
            Visited = false;

            Countries = new List<Country>();
        }

        public Continent(int id, string name, string desc)
        {
            Id = id;
            Name = name;
            Description = desc;
            Visited = false;

            Countries = new List<Country>();
        }

        public void AddCountry(int id, string countryName, string desc, bool visited = false)
        {
            Countries.Add(new Country(id, countryName, desc, visited));
        }

        public override string ToString()
        {
            return Name;
        }

        public string ListCountries()
        {
            string result = "";

            foreach (var country in Countries)
            {
                result += country.ToString() + Environment.NewLine;
            }

            return result;
        }

        public List<Country> GetCountries()
        {
            return Countries;
        }
    }
}
