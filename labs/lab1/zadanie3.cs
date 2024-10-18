using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab1
{
    internal class zadanie3
    {
        static void Main()
        {
            int k = 5;
            int l = 3;
            int m = 3;
            int n = Convert.ToInt32(Console.ReadLine());
            int rez;
            rez = (((2 * m + l) * n) + (((k + l) * 2 + (2 * k + l * n * 2)) / 2 * n)) - l * n;
            Console.WriteLine(rez);
            // задачка с грядками
        }
    }
}
