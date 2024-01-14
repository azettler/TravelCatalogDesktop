using PersonalTravelCatalogDesktop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTravelCatalogDesktop
{
    public class City : ILocation
    {
        public List<Landmark> Landmarks { get; set; }

        public City()
        {
            Id = -1;
            Name = "";
            Visited = false;
            Description = "";

            Landmarks = new List<Landmark>();
        }

        public City(int id, string name, string desc, bool visited = false)
        {
            Id = id;
            Name = name;
            Description = desc;
            Visited = visited;

            Landmarks = new List<Landmark>();
        }

        public void AddLandmark(int landmarkId, string landmarkName, string desc, bool visited)
        {
            Landmarks.Add(new Landmark(landmarkId, landmarkName, desc, visited));
        }
    }
}
