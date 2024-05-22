using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }
        
        public CountryView (Country displaycountry)
        {
            DisplayCountry = displaycountry;
        }
        public void Display()
        {
            string colors = "";
            foreach (string c in DisplayCountry.Colors) { colors += c + ", "; }
            Console.WriteLine($"Name: {DisplayCountry.Name} | Continent: {DisplayCountry.Continent} | Colors: {colors.Substring(0, (colors.Length - 2))}");
        }
    }
}
