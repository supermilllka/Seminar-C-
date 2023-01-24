/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

int[,] CreateMatrixSumIndex(int rows, int columns )
{
    int[,] matrix = new int[rows, columns]; //[0,1] - 0- строки,1- столбцы
    
    for (int i = 0; i < matrix.GetLength(0); i++) //проходим по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проходим по столбцам
        {
            matrix[i, j] = i+j;
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
                Console.Write($"{matrix[i,j], 5},");
            else
                Console.Write($"{matrix[i,j], 5}  ");
        }
        Console.WriteLine("]");
    }
    
}

int[,] matrix = CreateMatrixSumIndex(3,4);
PrintMatrix(matrix);