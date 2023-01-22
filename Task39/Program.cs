﻿/*Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int[] CreateArrayRndInt(int size, int min, int max)
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
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ",");
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

//Array.Reverse(array); - метод, который переворачивает массив
//[1 2 3 4 5] -> [5 4 3 2 1]

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++) 
    {
      int temp = arr[i];         //временная переменная для замены элементов
      arr[i] = arr[arr.Length- 1 - i]; //вычитаем i, чтобы смещались каждый раз элементы
      arr[arr.Length- 1 - i] = temp;      
    }
}



void ReverseArrayVersion2(int[] array)  //тоже самое, через метод while
{
    int index1 = 0;
    int index2 = array.Length - 1;

    while (index1<index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;
        index1++;
        index2--;
    }
}

int[] array = CreateArrayRndInt(4, 1, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
Array.Reverse(array); //встроенный метод переворота массива
PrintArray(array);
ReverseArrayVersion2(array);
PrintArray(array);