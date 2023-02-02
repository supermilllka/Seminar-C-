/*Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(MathPow(number,degree));

int MathPow(int num, int deg)
{
    if (deg == 0) return 1;
    else return num * MathPow(num, deg - 1);//уменьшаем степень, пока она не станет равной нулю. Тогда выполнится условие стр. 16 и мы выйдем

}