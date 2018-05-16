using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Catalog_Testing
{
    public class Country
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool visited { get; set; }

        public string description { get; set; }

        public List<Region> regions { get; set; }

        public List<City> cities { get; set; }

        public List<Place> places { get; set; }

        public Country()
        {
            id = -1;
            name = "";
            regions = new List<Region>();
            cities = new List<City>();
            places = new List<Place>();
            visited = false;
            description = "";
        }

        public Country(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            regions = new List<Region>();
            cities = new List<City>();
            places = new List<Place>();
            visited = false;
            this.description = description;
        }

        public void AddRegion(int regionId, string regionName, string desc)
        {
            regions.Add(new Region(id, regionName, desc));
        }

        public void AddCity(int cityId, string cityName, string desc)
        {
            cities.Add(new City(id, cityName, desc));
        }

        public void AddPlace(int placeId, string placeName, string desc)
        {
            places.Add(new Place(id, placeName, desc));
        }
    }
}
