using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Demos
{
    class ArrayList2
    {
        static void Main()
        {
            Hashtable has = new Hashtable();
            has[1] = 10;
            has[20] = 20;
            has[31] = 89;
            has[100] = 19;
            has["Ajay"] = 90;
            has[100] = "Deepak";
            has[19] = 100;
            
            Console.WriteLine(has[20]);
            
            
            foreach(var temp in has.Values)
                Console.WriteLine(has.Keys);

            Console.WriteLine("ENter RollNo whose score ypu want to see");
            int x = int.Parse(Console.ReadLine());
            if (has.Contains(x))
            {
                Console.WriteLine(has[x]);
            }
            else
                Console.WriteLine("There is no record");
            //    ArrayList list = new ArrayList();
            //    list.Add(10);
            //    list.Add(20);
            //    list.Add(30);
            //    list.Add(40);
            //    list.Add(50);

            //    list.Add(60);
            //    list.Add(70);
            //    // Search them
            //    Console.WriteLine("ENter element that you want to search");
            //    int x;
            //    x = int.Parse(Console.ReadLine());
            //    foreach (var temp in list)
            //    {
            //        if ((int)temp == x)
            //        {
            //            Console.WriteLine("Found");
            //        }
            //    }
            //}


        }
    }
}
