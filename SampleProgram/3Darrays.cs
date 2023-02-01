using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class _3Darrays
    {
        public static void Main()
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0,1] = 5;
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
