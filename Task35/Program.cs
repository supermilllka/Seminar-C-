﻿/*Задача 35: Задайте одномерный массив 
из 123 случайных чисел.
Найдите количество элементов массива, 
значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/


int[] array = CreateArrayRndInt(5,-100,100);
PrintArray(array);
int elementsOfArray = ElementsOfArray(array);
Console.WriteLine($"Количество положительных двузначных чисел в массиве {elementsOfArray}");

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int ElementsOfArray(int[] arr, int min =10, int max=99)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] >= min && arr[i] <=max) count++;
    }
    return count;
}



