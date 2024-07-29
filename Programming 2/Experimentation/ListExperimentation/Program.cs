using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExperimentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); // Create an empty list

            names.Add("Alice"); // Add a new name to the list
            names.Add("Bob");
            //names.Insert(100, "Charlie"); // Produces Error. Insert can only be used when the Index position is less than or equal to the total size of the List (List.Count).
            names.Insert(2, "Tester");
            names.Add("Tester");


            string firstName = names[0];  // Access the first name in the list
            string secondName = names[1]; // Access the second name in the list
            int TestIndex = names.IndexOf("Tester");

            //names.Remove("Charlie"); // Remove a name from the list by its value

            int count = names.Count; // Get the total number of names in the list
            Console.WriteLine(TestIndex);
            Console.ReadLine();

        }
    }
}
