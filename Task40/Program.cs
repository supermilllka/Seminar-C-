/* Напишите программу, которая принимает на вход три числа
и проверяет может ли существовать треугольник со сторонами такой длины
(Теорема о неравенстве треугольника -  каждая сторона треугольника меньше суммы двух других сторон)*/

Console.Write("Введите первое: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число : ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool isExistTriangle = IsExistTriangle(number1, number2, number3);
Console.WriteLine(isExistTriangle ? "Такое треугольник существует" : "Такого треугольника не существует");

bool IsExistTriangle(int num1, int num2, int num3)
{
    int sum1 = num1 + num2;
    int sum2 = num2 + num3;
    int sum3 = num3 + num1;

    return sum1 > num3 && sum2 > num1 && sum3 > num2;
       
}

// второй вариант

/*bool PositiveNumbers (int num1, int num2, int num3)
{
    return num1 > 0 && num2 > 0 && num3 > 0;
}

bool IsExistTriangleVersion2(int num1, int num2, int num3)
{
    return num1 >= num2 + num3 || num2 >= num1 + num3 || num3 >= num1 + num2;
}

if (PositiveNumbers(number1, number2, number3))
{
    bool result = IsExistTriangleVersion2(number1, number2, number3);
    Console.WriteLine(result ? "Нет": "Да");
}
else Console.WriteLine("Ошибка ввода числа");*/