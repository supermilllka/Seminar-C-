/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

double[] array = CreateArrayRndDouble(5,-10,10);
PrintArrayDouble(array);
double maxNumbers = MaxNumbers(array);
double minNumbers = MinNumbers(array);
double difference = maxNumbers-minNumbers;
Console.WriteLine($" Разница между максимальным элементом  {maxNumbers}  и минимальным элементом {minNumbers} равна {difference}");

double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
   
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double MaxNumbers(double[] arr) 
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return  max;
}

double MinNumbers(double[] arr) 
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return  min;
}
