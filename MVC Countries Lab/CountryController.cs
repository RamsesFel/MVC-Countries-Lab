using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    internal class CountryController
    {
        List<Country> CountryDB = new List<Country>()
        {
            new Country("United States", "North America", ["red","white","blue"]),
            new Country("Finland", "Europe", ["white","blue"]),
            new Country("Japan", "Asia", ["red","white"]),
            new Country("United Kingdom", "Europe", ["red","white","blue"]),
            new Country("Brazil", "South America", ["green","white","blue","yellow"]),
            new Country("Canada", "North America", ["red","white"]),
            new Country("Mexico", "North America", ["red","white","green"]),
            new Country("Italy", "Europe", ["red","white","green"])

        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            while (true)
            {
                int index;
                CountryListView view = new CountryListView(CountryDB);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                view.Display();
                if (int.TryParse(Console.ReadLine(), out index) == false || index < 0 || index >= CountryDB.Count)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                CountryAction(CountryDB[index]);
                Console.WriteLine("Would you like to learn about another country? Type n to quit");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    break;
                }
            }
        }
    }
}
