/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите  трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int firstDigit = number / 10;

    int secondDigit = firstDigit % 10;

    Console.Write($" вторая  цифра:{secondDigit}");
}
else
{
    Console.Write("Вы ввели не корректное число");
}
