using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PersonalTravelCatalogDesktop
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
            try
            {
                using (var fileStream = new FileStream(filename, FileMode.Create))
                {
                    var streamWriter = XmlWriter.Create(fileStream, new XmlWriterSettings()
                    {
                        Encoding = Encoding.UTF8,
                        Indent = true
                    });

                    var serializer = new XmlSerializer(typeof(TravelCatalog));
                    serializer.Serialize(streamWriter, this);
                }
            } 
            catch (Exception e)
            {
                throw new Exception("Could not save file: " + e.Message);
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

        public string ListContinents()
        {
            string result = "";

            foreach(var continent in continents)
            {
                result += continent.ToString() + Environment.NewLine;
            }

            return result;
        }

        public List<Continent> GetContinents()
        {
            return continents;
        }

        public string ListCountries(string c)
        {
            string result = "";

            foreach (var continent in continents)
            {
                if (c != null)
                {
                    if(c == continent.ToString().ToLower())
                    {
                        result += continent.ListCountries() + Environment.NewLine;
                    }
                }
                else
                {
                    result += continent.ToString() + " - " + continent.ListCountries() + Environment.NewLine;
                }
            }

            return result;
        }

        public string ListCities(string c)
        {
            string result = "";

            foreach (var continent in continents)
            {
                if (c != null && c == continent.ToString())
                {
                    result += continent.ListCountries() + Environment.NewLine;
                }
                else
                {
                    result += continent.ToString() + " - " + continent.ListCountries() + Environment.NewLine;
                }
            }

            return result;
        }

        public string GetCities(string c)
        {
            var result = "";

            return result;
        }
    }
}
