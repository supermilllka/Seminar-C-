/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random(); //сначала создаем
    for (int i = 0; i < 9; i++)
    {
        arr[i] = rnd.Next(0,2); // потом подставляем
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < 9; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
