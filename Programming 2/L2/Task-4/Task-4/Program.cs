using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 7, 8, 11, 12, 15, 16, 19, 20 };
            IEnumerable<int> evens = numbers.Where(x => x % 2 == 0);
            foreach (int x in evens)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
