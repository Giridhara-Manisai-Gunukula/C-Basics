using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class MultiDimesionalArrays
    {
        public static void Main1()
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            foreach(int i  in numbers)
            {
                if (i == 11)
                {
                    Console.WriteLine("The value is there" + i);

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
    }
}
