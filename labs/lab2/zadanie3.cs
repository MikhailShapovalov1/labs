using System;
internal class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int Count = 0;
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == 4) Count++;
        }
        Console.WriteLine("Количество элементов оканчивающихся на 4: " + Count);
    }
}

