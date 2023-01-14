Console.WriteLine("Введите  пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}

if (number >= 10000 && number <=99999)
{
    Console.WriteLine(Palindrome(number) ? "Да" : "нет");
}
else
{
    Console.Write("Введены некорректные данные");
}

bool Palindrome(int num)
{
    return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;

}


