using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTravelCatalogDesktop.BLL.Interfaces
{
    public class ILocation
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool visited { get; set; }

        public string description { get; set; }
    }
}
