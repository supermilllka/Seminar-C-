/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
PrintMatrix(array2D);

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

double[] arithmeticalMean = ArithmeticalMean(array2D);
PrintArray(arithmeticalMean);

double[] ArithmeticalMean(int[,] matrix)
{
    double[] rezult = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j, i];
        }

        double avarege = sum * 1.0 / matrix.GetLength(0);
        rezult[i] = Math.Round(avarege, 1);
    }
    return rezult;
}

void PrintArray(double[] rezult)
{
    Console.Write("[");
    for (int i = 0; i < rezult.Length; i++)
    {
        if (i < rezult.Length - 1)
            Console.Write($"{rezult[i], 10},");
        else
            Console.Write($"{rezult[i], 10}");
    }
    Console.WriteLine("]");
}
