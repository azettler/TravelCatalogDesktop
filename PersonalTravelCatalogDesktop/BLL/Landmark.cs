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
            id = -1;
            name = "";
            visited = false;
            description = "";
        }

        public Landmark(int id, string name, string desc)
        {
            this.id = id;
            this.name = name;
            description = desc;
            visited = false;
        }
    }
}
