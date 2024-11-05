using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        Console.WriteLine($"Введите размерность первого массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arrayN = new int[n]; Console.WriteLine($"Введите размерность второго массива");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] arrayM = new int[m]; Console.WriteLine($"Введите размерность третьего массива");
        int p = Convert.ToInt32(Console.ReadLine());
        int[] arrayP = new int[p];

        Console.WriteLine($"Элементы масива с размерностью {n}");
        Massiv(arrayN);
        Printmassiv(arrayN);

        Console.WriteLine($"Элементы масива с размерностью {m}");
        Massiv(arrayM);
        Printmassiv(arrayM);

        Console.WriteLine($"Элементы масива с размерностью {p}");
        Massiv(arrayP);
        Printmassiv(arrayP);

        //сумма кратных трем////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("сумма элементов кратных трем первого массива:");
        int sumN = Summa(arrayN);
        Console.WriteLine(sumN);

        Console.WriteLine("сумма элементов кратных трем второго массива:");
        int sumM = Summa(arrayM);
        Console.WriteLine(sumM);

        Console.WriteLine("сумма элементов кратных трем третьего массива:");
        int sumP = Summa(arrayP);
        Console.WriteLine(sumP);

        //произведение нечетных///////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Произведение нечетных элементов первого массива равно");
        int numN = Num(arrayN);
        Console.WriteLine(numN);

        Console.WriteLine("Произведение нечетных элементов второго массива равно");
        int numM = Num(arrayM);
        Console.WriteLine(numM);

        Console.WriteLine("Произведение нечетных элементов третьего массива равно");
        int numP = Num(arrayP);
        Console.WriteLine(numP);

        //количество нулей в массиве
        Console.WriteLine("Количество нулевых элементов первого массива:");
        int zerocountN = Zero(arrayN);
        Console.WriteLine(zerocountN);

        Console.WriteLine("Количество нулевых элементов второго массива:");
        int zerocountM = Zero(arrayM);
        Console.WriteLine(zerocountM);

        Console.WriteLine("Количество нулевых элементов третьего массива:");
        int zerocountP = Zero(arrayP);
        Console.WriteLine(zerocountP);





    }

    static void Massiv(int[] massiv)
    {
        Random Random = new Random();
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] = Random.Next(0, 10);
        }
    }

    static void Printmassiv(int[] pmassiv)
    {
        foreach (var el in pmassiv)
        {
            Console.WriteLine(el);


        }
    }

    static int Summa(int[] array)
    {
        int sum = 0;
        foreach (int el in array)
        {
            if (el % 3 == 0)
            {
                sum += el;
            }
        }
        return sum;
    }
    static int Num(int[] array)
    {
        int num = 1;
        foreach (int el in array)
        {
            if (el % 2 != 0)
            {
                num *= el;
            }
        }
        return num;
    }
    static int Zero(int[] array)
    {
        int zerocount = 0;
        foreach (int el in array)
        {
            if (el == 0)
            {
                zerocount++;
            }
        }
        return zerocount;
    }
}