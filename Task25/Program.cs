/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
 возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumber(number2) ? " " : "Ошибка. Число В должно быть натуральным");

int printPower = PrintPower(number1, number2);
Console.WriteLine($"число {number1} в натуральной степени {number2} -> {printPower}");// не понимаю как мне не выводить эту строчку, если степень отрицательная

bool NaturalNumber(int num2)
{
    return num2 > 0;
}

int PrintPower(int num1, int num2)
{
    int result = 1;

    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
