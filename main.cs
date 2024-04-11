/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        // Создаем массив случайных чисел
        int[] array = new int[10];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        // Переворачиваем массив
        Array.Reverse(array);

        // Выводим перевернутый массив
        Console.WriteLine("\nПеревернутый массив:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        Console.ReadLine();
    }
}