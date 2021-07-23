using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Demos
{
    class GenericCollectionDemos
    {
        static void Main()
        {
            Dictionary<int, int> Marks = new Dictionary<int, int>()
            {
                { 10, 90 },
                { 11, 89 },
                { 12, 90 },
                { 13, 90 },
                { 14, 90 }
            };
            string ch = "y";
            while (ch == "y")
            {
                Console.WriteLine("ENter RollNo & Marks");
                int rn = int.Parse(Console.ReadLine());
                int marks = int.Parse(Console.ReadLine());
                Marks[rn] = marks;
                Console.WriteLine("Do you want enter marks for other student");
                ch = Console.ReadLine();
            }
        }
    }

}