/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
    number = number * (-1);

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма  цифр в числе {number} -> {sumNumbers}");

int SumNumbers(int digit)
{
    int result = 0;
    while (digit > 0)
    {
        result = result + digit % 10;
        digit = digit / 10;
    }
    return result;
}
