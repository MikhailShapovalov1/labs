using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab1
{
    internal class zadanie2
    {
        static void Main()
        {
            int a;
            a = 10;
            int b;
            b = 6;
            int max;
            max = ((a + b) + Math.Abs(a - b)) / 2;
            int min;
            min = ((a + b) - Math.Abs(a - b)) / 2;
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
