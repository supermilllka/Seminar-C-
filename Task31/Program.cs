/*Задача 31: Задайте массив из 12 элементов, 
заполненный
случайными числами из промежутка [-9, 9]. 
Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве 
[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, 
сумма отрицательных равна
-20.*/

int[] CreateArrayRndInt (int size, int min, int max) //создает массив
{
    int[] arr = new int[size]; //создаем массив
    Random rnd = new Random(); //для получения псевдослучайных чисел
   // var rnd = new Random();// для неявной типизации
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); //чтобы все входило в диапозон
    }
    return arr;
}

void PrintArray(int[] arr) //метод печатает массив
{
    Console.Write("["); //чтобы вывод массива был в скобках
for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write(arr[i] + ","); // если i меньше последнего элемента массива
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]"); //чтобы вывод массива был в скобках
}

int GetSumPositiveElem(int[] arr) //возвращает сумму положительных элементов
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum +=arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr) //возвращает сумму отрицательных элементов
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum +=arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12,-9,9); //вызов метода
PrintArray(array); //вывоз метода

int sumPositive = GetSumPositiveElem(array); //вызов метода
int sumNegative = GetSumNegativeElem(array); //вызов метода

Console.WriteLine($"Сумма положительных элементов = {sumPositive} "); //вывод результата
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative} "); //вывод результата



/* решение через один метод
int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        else if (arr[i] < 0) sumNeg += arr[i];
    }

    return new int[]{sumPos, sumNeg};
}

int[] sumPositiveNegative = GetSumPositiveNegativElem(array);

Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegative[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegative[1]}");*/
