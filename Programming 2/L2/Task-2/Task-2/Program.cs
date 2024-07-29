using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 10, 20, 30, 40, 50 };
            DisplayNums(nums);
            Console.ReadLine();
            Console.WriteLine("After Insert");
            nums.Insert(2, 25);
            DisplayNums(nums);
            Console.ReadLine();
            Console.WriteLine("After Contains");
            bool hasNumber35 = nums.Contains(35);
            Console.WriteLine($"Number35 found = {hasNumber35}");
            Console.ReadLine();
            int firstNumGreaterThan30 = nums.Find(x => x > 30);
            Console.WriteLine("First Number Greater Than 30");
            Console.WriteLine(firstNumGreaterThan30.ToString());
            Console.ReadLine();
            nums.Sort();
            nums.Reverse();
            DisplayNums(nums);
            Console.ReadLine();

        }
        static void DisplayNums(List<int> nums)
        {
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
