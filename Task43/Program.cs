/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите значение переменной b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение переменной k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение переменной b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение переменной k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


double findX = FindX(b1,k1,b2,k2);
double findY = FindY(findX,k1,b1);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({findX}; {findY})");

double FindX(double b01, double k01, double b02, double k02)
{
    double x = (b02 - b01)/(k01-k02);
    return x;
}

double FindY(double x1, double k01, double b01)
{
    double y = k01*x1+b01;
    return y;
}