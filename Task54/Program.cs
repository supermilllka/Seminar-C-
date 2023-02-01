﻿/*Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] array2D = CreateMatrixRndInt(5, 5, -5, 20);
PrintMatrix(array2D);
Console.WriteLine();
DecreaseRow(array2D);
PrintMatrix(array2D);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
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

void DecreaseRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int currentRow = matrix.GetLength(1) - 1; currentRow > j; currentRow--)
                if (matrix[i,currentRow] < matrix[i,currentRow - 1])
                {
                    int tmp = matrix[i, currentRow];
                    matrix[i, currentRow] = matrix[i, currentRow - 1];
                    matrix[i, currentRow - 1] = tmp;
                }
        }
    }
}
