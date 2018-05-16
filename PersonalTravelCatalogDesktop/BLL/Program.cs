using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Catalog_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new TravelCatalog();

            var filePath = "test.xml";

            catalog.SaveToFile(filePath);
        }
    }
}
