/*Задача 22: Напишите программу, которая
принимает на вход число (N) 
и выдаёт таблицу
квадратов чисел от 1 до N.*/

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintSquares(number);


void PrintSquares(int num)
{
    int index=1;
    while (index<=num)
    {
        Console.WriteLine($"{index} {index*index}");
        index++;
    }
}