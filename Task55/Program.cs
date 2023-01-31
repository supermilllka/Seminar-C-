/*Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/

int matrixRows = 6;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxnValue = 11;

int[,] matrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxnValue);
PrintMatrix(matrix);
if (matrixRows == matrixColumns)
{
    Console.WriteLine(string.Empty);
    int[,] newMatrix = ChangeRowsColunmsMatrix(matrix);
    PrintMatrix(newMatrix);
}

else Console.WriteLine("Матрица должна быть квадратной");

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
                Console.Write($"{matrix[i, j], 5},");
            else
                Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] ChangeRowsColunmsMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
        
    }
    return newMatrix;
}

// вариант два
/*void ChangeRowsColunmsMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = newMatrix[i, j];
            newMatrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
        
    }
    
}*/
