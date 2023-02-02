/*Задача 67: Напишите программу, 
которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));
int SumDigits(int num)
{
    if (num == 0) return 0; // условие выхода
    else return num%10 + SumDigits(num/10); //сложение выполняется, когда условия из 13 строки выполнены.До этого метод делит и возвращает
}//всегда сначала выполняются рекурсионные вызовы, потом все остальное