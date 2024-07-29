using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bookTitles = new List<string>() { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Brave New World" };
            int TotalBooks = bookTitles.Count;
            Console.WriteLine($"Total Amount Of Books: {Convert.ToString(TotalBooks)}");
            //Console.WriteLine();
            bool HasBraveNewWorld = bookTitles.Contains("Brave New World");
            Console.WriteLine($"Contains Brave New World == {HasBraveNewWorld}");
            int index1984 = bookTitles.IndexOf("1984");
            Console.WriteLine($"Index Of 1984: { Convert.ToString(index1984)}");
            Console.ReadLine();
            Console.WriteLine("Clear List Then Check Values");
            bookTitles.Clear();
            foreach (string bookTitle in bookTitles)
            {
                Console.WriteLine(bookTitle);
            }
            Console.ReadLine();

        }
    }
}
