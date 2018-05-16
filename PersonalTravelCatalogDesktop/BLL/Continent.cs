using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Catalog_Testing
{
    public class Continent
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool visited { get; set; }

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
    }
}
