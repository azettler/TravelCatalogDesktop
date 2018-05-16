using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Travel_Catalog_Testing
{
    public class TravelCatalog
    {
        public List<Continent> continents { get; set; }

        public List<Trip> trips { get; set; }

        public TravelCatalog()
        {
            InitCatalog();
            test();
        }

        /// <summary>
        /// Initialize Continents if none exist in XML file
        /// </summary>
        public void InitCatalog()
        {
            continents = new List<Continent>();
            trips = new List<Trip>();

            Continent c = new Continent(0, "Africa");
            continents.Add(c);
            c = new Continent(1, "Asia");
            continents.Add(c);
            c = new Continent(2, "Australia");
            continents.Add(c);
            c = new Continent(3, "Europe");
            continents.Add(c);
            c = new Continent(4, "North America");
            continents.Add(c);
            c = new Continent(5, "South America");
            continents.Add(c);
            c = new Continent(6, "Antarctica");
            continents.Add(c);
        }

        private void test()
        {
            continents[1].AddCountry(7, "Japan", "An Eastern Asian Island country famous for being home to samurai and sushi.");
            continents[2].AddCountry(8, "Australia", "A country that is also a continent");

            continents[1].countries[0].AddCity(9, "Tokyo", "Capital of Japan");
            continents[2].countries[0].AddRegion(10, "Queensland", "");

            continents[1].countries[0].cities[0].AddLandmark(11, "Some Tower", "");
            continents[2].countries[0].AddCity(12, "Auckland", "");
        }

        public void SaveToFile(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(TravelCatalog));
                xml.Serialize(stream, this);
            }
        }

        public TravelCatalog LoadFromFile(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(TravelCatalog));
                return (TravelCatalog)xml.Deserialize(stream);
            }
        }
    }
}
