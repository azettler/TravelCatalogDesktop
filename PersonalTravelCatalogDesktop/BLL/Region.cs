using PersonalTravelCatalogDesktop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTravelCatalogDesktop
{
    public class Region : ILocation
    {
        public List<City> cities { get; set; }

        public List<Place> places { get; set; }

        public Region()
        {
            id = -1;
            name = "";
            cities = new List<City>();
            places = new List<Place>();
            visited = false;
            description = "";
        }

        public Region(int id, string name, string desc)
        {
            this.id = id;
            this.name = name;
            description = desc;
            cities = new List<City>();
            places = new List<Place>();
            visited = false;
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
