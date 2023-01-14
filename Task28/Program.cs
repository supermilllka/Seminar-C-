/*Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120*/



Console.Write("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine()); //конвертирует 
int productOfNumbers = ProductOfNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {productOfNumbers}");


int ProductOfNumbers(int num)
{
   int prod =1;
   for (int i = 1; i <= num; i++)
   {
    checked{   //чтобы не вылетать за пределы числа (например, когда произведение больше int)
     prod = prod*i; 
    } 
   }
   return prod;
}