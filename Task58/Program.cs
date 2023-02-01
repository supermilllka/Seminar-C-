/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] arrayА = CreateMatrixА(2, 3, 1, 10);
PrintMatrixA(arrayА);
Console.WriteLine();
int[,] arrayB = CreateMatrixB(3, 2, 1, 10);
PrintMatrixB(arrayB);
Console.WriteLine();

if (arrayА.GetLength(1) != arrayB.GetLength(0))
Console.WriteLine("Кол-во столбцов первой матрицы должно быть равно кол-ву строк второй матрицы");
else
{
int[,] matrixMultiplication = MatrixMultiplication(arrayА, arrayB);
PrintMatrixB(matrixMultiplication);
}
int[,] CreateMatrixА(int rowsA, int columnsA, int minA, int maxA)
{
    int[,] matrixA = new int[rowsA, columnsA];
    Random rnd = new Random();
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = rnd.Next(minA, maxA + 1);
        }
    }
    return matrixA;
}

void PrintMatrixA(int[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            if (j < matrixA.GetLength(1) - 1)
                Console.Write($"{matrixA[i, j], 5},");
            else
                Console.Write($"{matrixA[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] CreateMatrixB(int rowsB, int columnsB, int minB, int maxB)
{
    int[,] matrixB = new int[rowsB, columnsB];
    Random rnd = new Random();
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i, j] = rnd.Next(minB, maxB + 1);
        }
    }
    return matrixB;
}

void PrintMatrixB(int[,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            if (j < matrixB.GetLength(1) - 1)
                Console.Write($"{matrixB[i, j], 5},");
            else
                Console.Write($"{matrixB[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
