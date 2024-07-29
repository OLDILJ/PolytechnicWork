using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> progLangsOne = new List<string>() { "C#", "JavaScript", "Kotlin", "Python" };
            List<string> progLangsTwo = new List<string>() { "C++", "Go", "Swift", "TypeScript" };

            List<string> progLangsAll = new List<string>() {  };
            progLangsAll.AddRange(progLangsOne);
            progLangsAll.AddRange(progLangsTwo);
            foreach (string s in progLangsAll)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
