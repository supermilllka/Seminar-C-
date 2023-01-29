/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/
int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxnValue = 11;

int[,] matrix = CreateMatrix(matrixRows,matrixColumns,matrixMinValue,matrixMaxnValue);
PrintMatrix(matrix);
ChangeFirstLastRows(matrix);
Console.WriteLine(string.Empty);
PrintMatrix(matrix);


int[,] CreateMatrix(int rows, int columns, int min, int max)
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
                Console.Write($"{matrix[i,j], 5},");
            else
                Console.Write($"{matrix[i,j], 5}  ");
        }
        Console.WriteLine("]");
    }
    
}

void ChangeFirstLastRows(int[,] matrixForChange)
{
    int firstRow = 0;
    int lastRow = matrixForChange.GetLength(0)-1;
    for (int i = 0; i < matrixForChange.GetLength(1); i++)
    {
        int temp = matrixForChange[firstRow, i];
        matrixForChange[firstRow, i] = matrixForChange[lastRow, i];
        matrixForChange[lastRow, i] = temp;
    }
}