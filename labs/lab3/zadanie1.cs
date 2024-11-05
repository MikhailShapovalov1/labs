using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            int currentNumber = Convert.ToInt32(Console.ReadLine());

            if (currentNumber > 0)
            {
                int number = 0;
                while (currentNumber > 0)
                {
                    int n = currentNumber % 10;
                    currentNumber = (currentNumber - n) / 10;

                    if (n % 2 != 0)
                    {
                        number = number * 10 + n;
                    }
                }

                if (number != 0)
                {
                    Console.WriteLine($"число: {number}");
                }
                else
                {
                    Console.WriteLine("нечетных цифр нет");
                }
            }
            else
            {
                break;
            }
        }



    }
}