using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCatalogTestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new TravelCatalog();

            var filePath = "test.xml";

            catalog.SaveToFile(filePath);

            Console.WriteLine("welcome");
            Console.WriteLine("Enter 'help' for list of commands");

            string command = "";

            while (command.ToUpper() != "Q" && command.ToUpper() != "EXIT")
            {
                command = Console.ReadLine();

                Console.WriteLine(parseCommand(command, catalog));
            }
        }

        static void displayHelp()
        {
            Console.WriteLine("commands:");

            Console.WriteLine("c1 - list continents");
            Console.WriteLine("c2 - list countries");
            Console.WriteLine("c3 - list cities");
            //Console.WriteLine("cont - list continents");
            //Console.WriteLine("cont - list continents");
        }

        static string parseCommand(string command, TravelCatalog catalog)
        {
            var result = "";
            command = command.ToLower();
            int parmsSeparator = Math.Max(0, command.IndexOf(' '));
            var commandKey = command.Substring(0, (parmsSeparator == 0) ? command.Length : parmsSeparator);

            var parms = (parmsSeparator > 0) ? command.Substring(parmsSeparator + 1) : "";

            if (commandKey.Length > 1)
            {

            }

            switch (commandKey)
            {
                case "help":
                    displayHelp();
                    break;
                case "c1":
                    result = catalog.ListContinents();
                    break;
                case "c2":
                    result = catalog.ListCountries(null);
                    break;
                case "c3":
                    result = catalog.ListCountries(parms);
                    break;
                case "c4":
                    result = catalog.ListCities(null);
                    break;
                case "q":
                case "exit":
                    result = "Goodbye!";
                    break;
                default:
                    result = "Invalid command entered";
                    break;
            }

            return result;
        }
    }
}
