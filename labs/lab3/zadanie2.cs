using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int maxSUM = 0;
        int currentSUM = 0;
        for (int i = 0; i < n; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                currentSUM += x;
            }
            else
            {
                if (currentSUM > maxSUM)
                {
                    maxSUM = currentSUM;
                }
                currentSUM = 9;
            }
        }
        if (currentSUM > maxSUM)
        {
            maxSUM = currentSUM;
        }
        Console.WriteLine("Максимальная сумма четных равна:" + maxSUM);
    }
}
