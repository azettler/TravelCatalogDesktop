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
        public List<Landmark> landmarks { get; set; }

        public City()
        {
            id = -1;
            name = "";
            landmarks = new List<Landmark>();
            visited = false;
            description = "";
        }

        public City(int id, string name, string desc)
        {
            this.id = id;
            this.name = name;
            description = desc;
            landmarks = new List<Landmark>();
            visited = false;
        }

        public void AddLandmark(int landmarkId, string landmarkName, string desc)
        {
            landmarks.Add(new Landmark(landmarkId, landmarkName, desc));
        }
    }
}
