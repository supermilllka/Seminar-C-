/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/

//int[] array = new int[8];

/*Console.Write("Введите минимальный диапозон: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный диапозон: ");
int max = Convert.ToInt32(Console.ReadLine());*/

int[] array = CreateArray(8);
PrintArray(array);

int[] CreateArray(int size) //, int min1, int max1)
{
    int[] arr = new int[size];
    Random rnd = new Random(); //сначала создаем
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1,10); // потом подставляем
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        
        Console.Write ("[{0}]",arr[i]+ " ");
        

}

}