using System;
using System.Collections;
namespace Day10Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(111);    // Boxing is happening
            queue.Enqueue(20);
            queue.Enqueue(10.9);
            foreach(var x in queue)   // UnBoxing is happening
            {
                Console.WriteLine(x);
            }

            queue.Dequeue();
            //// LIFO 

            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push("Ajay");
            //foreach(var x in stack)
            //    Console.WriteLine(x);
            //stack.Pop();
            //foreach (var x in stack)
            //    Console.WriteLine(x);


            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add("Ajay");
            //list.Add(10.90);

            //foreach(var x in list)
            //{
            //    Console.WriteLine(x);
            //}


            //list.Insert(0, 100);
            //Console.WriteLine("After Insertion, elements are ");
            //foreach (int x in list)
            //{
            //    Console.WriteLine(x);
            //}

            //list.RemoveAt(1);
            //Console.WriteLine("After Insertion, elements are ");
            //foreach (int x in list)
            //{
            //    Console.WriteLine(x);
            //}
            //list.Remove(100);
            //Console.WriteLine("After Insertion, elements are ");
            //foreach (int x in list)
            //{
            //    Console.WriteLine(x);
            //}

        }
    }
}
