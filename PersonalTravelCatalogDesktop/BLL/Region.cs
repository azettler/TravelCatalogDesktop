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
        public List<City> Cities { get; set; }

        public List<Place> Places { get; set; }

        public List<Landmark> Landmarks { get; set; }

        public Region()
        {
            Id = -1;
            Name = "";
            Visited = false;
            Description = "";

            Cities = new List<City>();
            Places = new List<Place>();
            Landmarks = new List<Landmark>();
        }

        public Region(int id, string name, string desc, bool visited = false)
        {
            Id = id;
            Name = name;
            Description = desc;
            Visited = false;

            Cities = new List<City>();
            Places = new List<Place>();
            Landmarks = new List<Landmark>();
        }

        public void AddCity(int cityId, string cityName, string desc, bool visited = false)
        {
            Cities.Add(new City(Id, cityName, desc, visited));
        }

        public void AddPlace(int placeId, string placeName, string desc, bool visited = false)
        {
            Places.Add(new Place(Id, placeName, desc, visited));
        }

        public void AddLandmark(int placeId, string placeName, string desc, bool visited = false)
        {
            Landmarks.Add(new Landmark(Id, placeName, desc, visited));
        }
    }
}
