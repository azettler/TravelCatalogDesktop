using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Catalog_Testing
{
    public class Landmark
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool visited { get; set; }

        public string description { get; set; }

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
