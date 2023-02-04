/*Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите первое неотрицательное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M >=0 && N >=0)
{
int akkerman = Akkerman(M, N);
Console.WriteLine(akkerman);
}
else
Console.WriteLine("Введенные числа должны быть неотрицательными");

int Akkerman(int first, int second)
{
    if (first == 0)
        return second + 1;
    if (first != 0 && second == 0)
        return Akkerman(first - 1, 1);
    if (first > 0 && second > 0)
        return Akkerman(first - 1, Akkerman(first, second - 1));
    return Akkerman(first, second);
}
