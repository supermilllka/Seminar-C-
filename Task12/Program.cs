// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//34,5 -> не кратно, остаток 4
//16,4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

//bool result = number1 % number2==0; решение через bool
//if (result)

//if (number1 % number2==0)
//{
  //  Console.WriteLine("Кратно");
//}
  //  else
    //{
   //
    //Console.WriteLine($"не кратно, остаток {number1/number2%10}");
//}
// решение через метод:
int res = Multi(number1,number2);
Console.WriteLine(res==0 ? $"Кратно" : $"Не кратно, остаток от деления {res}");
int Multi(int num1,int num2)
{
    return num1%num2;
}