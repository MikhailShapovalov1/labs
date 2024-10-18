using System;
internal class Progtam
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int firstmaxelement = 0;
        int secondmaxelement = 0;
        for (int i = 0; i < n; i++)
        {
            int element = Convert.ToInt32(Console.ReadLine());
            if (element > firstmaxelement)
            {
                secondmaxelement = firstmaxelement;
                firstmaxelement = element;
            }
            else if (element > secondmaxelement)
            {
                secondmaxelement = element;
            }
        }
        Console.WriteLine("Первый максимальный элемент: " + firstmaxelement);
        Console.WriteLine("Второй максимальный элемент: " + secondmaxelement);
    }
}




          