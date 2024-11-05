using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    //определить является ли массив равномерно возрастающей последовательностью
    //ОПРЕДЕЛИТЬ КОЛИЧЕСТВО ЭЛЕМЕНТОВ, У КОТОРЫХ ЕСТЬ ХОТЯ БЫ ОДНА ЦИФРА ТРИ
    //найти среднее арифметическое четных элементов
    static void Main()
    {
        Console.WriteLine("Введите размерность массива");

        int n = Convert.ToInt32(Console.ReadLine());
        int[] arrayN = new int[n];
        Console.WriteLine("Массив будет заполнен автоматически.Его элементы с размерностью " + n);

        bool uvelichivaetsya = Uvelichivaetsya(arrayN);

        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            arrayN[i] = random.Next(0, 100);
            Console.WriteLine(arrayN[i]);
        }

        Console.WriteLine(uvelichivaetsya ? "Массив является равномерно возрастающей последовательностью." : "Массив не является равномерно возрастающей последовательностью.");
        Console.WriteLine();

        int count = CountwithTRI(arrayN);
        Console.WriteLine($"Количество элементов содержащих хотя бы одну цифру 3: {count}");

        double result = SredneeARIF(arrayN);
        Console.WriteLine("Среднее арифметическое четных элементов равно: " + result);


    }

    static bool Uvelichivaetsya(int[] array)
    {
        if (array.Length < 2)
        {
            return true; // Массив из одного или нуля элементов считается равномерно возрастающим
        }

        int raznitsa = array[1] - array[0]; // Определяем разницу между первыми двумя элементами

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i + 1] - array[i] != raznitsa)
            {
                return false; // Если разница не равна общей разнице, возвращаем false
            }
        }

        return true; // Все разницы равны
    }

    static int CountwithTRI(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (CountThree(number))
            {
                count++;
            }
        }

        return count;
    }

    static bool CountThree(int number)
    {
        // Преобразуем число в строку и проверяем наличие '3'
        return number.ToString().Contains('3');
    }
    static double SredneeARIF(int[] array)
    {
        int count = 0;
        int sum = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0) // Проверяем, является ли элемент четным
            {
                sum += number;
                count++;
            }
        }

        return count > 0 ? (double)sum / count : 0; // Избегаем деления на ноль



    }

}