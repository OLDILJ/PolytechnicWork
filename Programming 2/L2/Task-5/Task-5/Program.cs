using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string> 
            {"Argentina","Australia","Brazil","Canada","Egypt","France","india","Italy","Mexico","Netherlands","South Africa","United States",};
            /*
            IEnumerable <string> iStartingCountries =
                //countries.Where(countries.First() = "i");
                //countries.Select(=> (str = countries.Substring(0, 1) == "i"); (str = countries.Substring(0, 1) == "i");
                countries.Select(x => countries[0] = "I");
            */
            IEnumerable<string> iStartingCountries = countries.Where(x => x.StartsWith("I") || x.StartsWith("i"));
            foreach (string test in iStartingCountries) 
            {
                Console.WriteLine(test);
            }
            Console.ReadLine();



        }
    }
}
