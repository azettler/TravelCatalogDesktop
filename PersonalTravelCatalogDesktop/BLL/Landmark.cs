using PersonalTravelCatalogDesktop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTravelCatalogDesktop
{
    public class Landmark : ILocation
    {
        public Landmark()
        {
            Id = -1;
            Name = "";
            Visited = false;
            Description = "";
        }

        public Landmark(int id, string name, string desc, bool visited = false)
        {
            Id = id;
            Name = name;
            Description = desc;
            Visited = visited;
        }
    }
}
