﻿/*Не используя рекурсию, выведете первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 01123
Если N = 3 -> 011
Если N = 7 -> 0112358*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetFibonacciArray(number);
PrintArray(array);

int[] GetFibonacciArray(int size)
{
    int[] result = new int[size];
    result[1] = 1;
    for (int i = 2; i < result.Length; i++) //первые 2 числа заполнены - 0 и 1
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + "");
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine();
}
