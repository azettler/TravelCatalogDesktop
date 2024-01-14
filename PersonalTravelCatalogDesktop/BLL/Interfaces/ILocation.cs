using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTravelCatalogDesktop.BLL.Interfaces
{
    public class ILocation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Visited { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
