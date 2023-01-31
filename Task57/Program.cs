/*Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.Набор данных: 
{ 1, 9, 9, 0, 2, 8, 0, 9 } 

Частотный массив:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

Набор данных: 
1, 2, 3
4, 6, 1
2, 1, 6

Частотный массив:
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/

int[,] array2D = CreateMatrixRndInt(3,4,-99,99);
PrintMatrix(array2D);
Console.WriteLine();
int[] array = MatrixToArray(array2D);
PrintArray(array);
Console.WriteLine();
Array.Sort(array); //метод сортирует массив от меньшего к большему
PrintArray(array);

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

int[] MatrixToArray(int[,] matrix)  // делаем из двумерного массива одномерный
{

int[] array = new int[matrix.GetLength(0)*matrix.GetLength(1)];
int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i,j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        
        Console.Write(arr[i] + ", ");
    }
}

int[,] UniqElementary(int[] arr)
{
int count = 0;
int[] uniqNum = arr.Distinct().ToArray();
int[,] arr2D = new int[uniqNum.Length,1];

int currentElem = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (currentElem == array[i]) count++;
    else
    {
        arr2D[k,1] = count;

    }
}

}
//вариант 1 недоделан
//вариант 2
 int[] NumberDictionary(int[,] matrix)
 {
    int[] array = new int[matrix.Length]; //размет всего двумерного массива
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i,j]; //присваиваем значения двумерного массива элементам одномерного массива
            index++;
        }
    }
    return array;
 }

void Dictionary(int[] array)
{
 int number = array[0];
 int count = 1;
 for (int i = 1; i < array.Length; i++)
 {
    if (array[i] == number) count++;
    else
    {
        Console.WriteLine($"{number} -> {count}");
        number = array[i];
        count = 1;
    }
 }
    Console.WriteLine($"{number} -> {count}");
}