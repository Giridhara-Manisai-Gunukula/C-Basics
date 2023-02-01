using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Array1
    {
        static void Main1(string[] args)
        {
            int[] names ={5,4,3,2,1};
            Console.WriteLine(names.Max());
            Console.WriteLine(names.Min());
            Console.WriteLine(names.Sum());
            Array.Sort(names);
            foreach (int n in names)
            {
                Console.WriteLine(n);
               

            }
            Console.ReadLine();
        }
    }
}
