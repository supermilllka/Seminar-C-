/*Задача 65: Задайте значения M и N.
 Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  2 число: ");
int N = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(M,N);

void NaturalNumbersRange(int first, int second)
{
    if (first == second) Console.Write($"{first} ");
    else if (first < second) 
    {
        Console.Write($"{first} ");
        NaturalNumbersRange(first + 1,second);
    
    
    }
    else if (first > second)
    {
        Console.Write($"{first} ");
        NaturalNumbersRange(first - 1,second);
        
    }
}