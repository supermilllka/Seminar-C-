/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = 0;


if (number>=100)
{
while (number>=999)
  thirdDigit = number/10;
  if (number>=100 && number <=999)
{
Console.Write($" последняя цифра:{thirdDigit}%10");
}

  //return thirdDigit;
//}
//Console.Write($"Третья цифра: {thirdDigit}%10");
  
} 

else
{
   Console.Write("Третьей цифры нет"); 
}

/*if (number>=100 && number <=999)
{
Console.Write($" последняя цифра:{number%10}");
}*/