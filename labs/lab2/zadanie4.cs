using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab2
{
    internal class zadanie4
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0) Count++;
            }
            Console.WriteLine("длина подпоследовательности, состоящей из четных элемементов " + Count);

        }
    }
}
