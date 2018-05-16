using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Catalog_Testing
{
    public class Place
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool visited { get; set; }

        public string description { get; set; }

        public List<Landmark> landmarks { get; set; }

        public Place()
        {
            id = -1;
            name = "";
            landmarks = new List<Landmark>();
            visited = false;
            description = "";
        }

        public Place(int id, string name, string desc)
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
