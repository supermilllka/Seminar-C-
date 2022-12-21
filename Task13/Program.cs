/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = 0;
index = 0;

if (number>=999)
{
while (number>=999) 
{
  thirdDigit = number/10;
  index++;

Console.Write({number}%10);
  
} 
}
else
{
   Console.Write("Третьей цифры нет"); 
}