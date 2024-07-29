using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double totaltemp = 0.0 ;
            List<double> temperatures = new List<double>() { 24.5, 23.8, 25.3, 22.6, 26.1, 27.5, 21.9 };
            
            //temperatures.Sort();
            double averagetemp = temperatures.Average();
            double maxtemp = temperatures.Max();
            IEnumerable<double> TempAbove25 = temperatures.Where(x => x > 25);

            Console.WriteLine(averagetemp);
            Console.ReadLine();
            Console.WriteLine(maxtemp);
            Console.ReadLine();
            foreach (double temp in TempAbove25)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();

        }
    }
}
