/*Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные,
 и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2              Новый массив будет выглядеть
5 9 2 3
8 4 2 4                     вот так:
                    1 4 49 2
                    5 9 2 3
                    64 4 4 4*/

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

void FindEvenIndex(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i+=2) //проходим по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) // проходим по столбцам
        {
            matrix[i,j]*=matrix[i,j] ;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i,j], 5},");
            else
                Console.Write($"{matrix[i,j], 5}  ");
        }
        Console.WriteLine("]");
    }
    
}

int[,] array2D = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(array2D);
Console.WriteLine();
FindEvenIndex(array2D);
PrintMatrix(array2D);
