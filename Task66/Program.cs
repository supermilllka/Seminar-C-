/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  2 число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M >=0 && N >=0)
{int sumDigits = SumDigits(M, N);
Console.WriteLine(sumDigits);
}
else
Console.WriteLine("Введенные числа должны быть натуральными");
int SumDigits(int first, int second)
{
    if (first > second)
        return first + SumDigits(first - 1, second);

    if (first < second)
        return first + SumDigits(first + 1, second);

    if (first == second)
        return first;
    return first;    
}
