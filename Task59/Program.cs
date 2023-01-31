/*Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7*/

int[,] array2D = CreateMatrixRndInt(3,4,-10,10);
PrintMatrix(array2D);
int[] indexMinVal = IndexMinVal(array2D);
PrintArray(indexMinVal);
int [,] removeRowColumnCross = RemoveRowColumnCross(array2D, indexMinVal[0], indexMinVal[1]);
PrintMatrix(removeRowColumnCross);

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
                Console.Write($"{matrix[i,j], 5},");
            else
                Console.Write($"{matrix[i,j], 5}  ");
        }
        Console.WriteLine("]");
    }
    
}

int[,] RemoveRowColumnCross(int[,] matrix, int removeRow, int removeColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == removeRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == removeColumn) n++;
            newMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}




int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0,0];
    int indexRow = 0;  //переменная для запоминания индекса
    int indexColumn = 0; //переменная для запоминания индекса
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < min) 
            {
            min = matrix[i,j];
            indexRow = i;
            indexColumn = j;
            }
        }
    }
    return new int[] {indexRow,indexColumn,min};

}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}