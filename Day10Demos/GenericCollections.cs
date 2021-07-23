using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Demos
{
    class GenericCollections
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(100);

            foreach(int x in list)
            {
                Console.WriteLine(x);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("Ajay");
            stack.Push("Deepak");

            foreach (string x in stack)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(stack[1].ToString());

            Queue<float> queue = new Queue<float>();
            queue.Enqueue(10.8f);

            Dictionary<int, int> Marks = new Dictionary<int, int>();

            Marks[1] = 100;
            Marks[2] = 900;

            foreach (KeyValuePair<int, int> kvp in Marks)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);



        }
    }
}
