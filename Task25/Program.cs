/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
 возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int printPower = PrintPower(number1, number2);
Console.WriteLine($"число {number1} в натуральной степени {number2} -> {printPower}");

int PrintPower(int num1, int num2)
{
    int result = 1;

    if (num2 < 0)
    {
        Console.WriteLine("Ошибка. Число В должно быть натуральным");
    }
    else
    {
        for (int i = 1; i <= num2; i++)
        {
            result = result * num1;
        }
    }
    return result;
}
