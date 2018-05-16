using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Catalog_Testing
{
    public class LocationIdentifierInformation
    {
        public int NextLocationId { get; set; }

        public LocationIdentifierInformation()
        {
            NextLocationId = 0;
        }

        public int GetNextLocationId()
        {
            return NextLocationId++;
        }

        public void SetNextLocationId(int id)
        {
            NextLocationId = id;
        }
    }
}
