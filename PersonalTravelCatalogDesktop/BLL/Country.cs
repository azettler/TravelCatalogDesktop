using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalTravelCatalogDesktop.BLL.Interfaces;

namespace PersonalTravelCatalogDesktop
{
    public class Country : ILocation
    {
        public List<Region> Regions { get; set; }

        public List<City> Cities { get; set; }

        public List<Place> Places { get; set; }

        public List<Landmark> Landmarks { get; set; }

        public Country()
        {
            Id = -1;
            Name = "";
            Visited = false;
            Description = "";

            Regions = new List<Region>();
            Cities = new List<City>();
            Places = new List<Place>();
            Landmarks = new List<Landmark>();
        }

        public Country(int id, string name, string description, bool visited = false)
        {
            Id = id;
            Name = name;
            Visited = visited;
            Description = description;

            Regions = new List<Region>();
            Cities = new List<City>();
            Places = new List<Place>();
            Landmarks = new List<Landmark>();
        }

        public void AddRegion(int regionId, string regionName, string desc, bool visited = false)
        {
            Regions.Add(new Region(Id, regionName, desc, visited));
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

        public override string ToString()
        {
            return Name;
        }
    }
}
