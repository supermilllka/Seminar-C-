/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] array2D = CreateMatrixRndInt(5, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumRows = SumRows(array2D);
PrintArray(sumRows);
int minSum = MinSum(sumRows);
Console.WriteLine($"{minSum} - строка с наименьшей суммой строк");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //[0,1] - 0- строки,1- столбцы
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //проходим по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проходим по столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 5},");
            else
                Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] SumRows(int[,] matrix)
{
    int[] rezult = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        rezult[i] = sum;
    }
    return rezult;
}

void PrintArray(int[] rezult)
{
    Console.Write("[");
    for (int i = 0; i < rezult.Length; i++)
    {
        if (i < rezult.Length - 1)
            Console.Write($"{rezult[i], 5},");
        else
            Console.Write($"{rezult[i], 5}");
    }
    Console.WriteLine("]");
}

int MinSum(int[] rezult)
{
    int min = 0;

    for (int i = 0; i < rezult.Length; i++)
    {
        if (rezult[i] < rezult[min])
            min = i;
    }
    return min;
}
