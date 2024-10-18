using System;

class zadanie1
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string a = Console.ReadLine();

        int maxcount = 0;

        for (int i = 1; i < n - 1; i++)
        {
            if (Convert.ToInt32(a[i]) > Convert.ToInt32(a[i - 1]) && Convert.ToInt32(a[i]) > Convert.ToInt32(a[i + 1])) maxcount++;
        }

        Console.WriteLine("Количество локальных максимумов: " + maxcount);
    }
}

  