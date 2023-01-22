/*Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 -> 101101
3 ->11
2 ->10*/


string res = DecToBin(2);
Console.WriteLine(res);

string DecToBin(int num)
{
    string result = string.Empty; // пустая строка
    while (num > 0)
    {
        result =  num % 2 + result;
        num = num / 2;
    }
    return result;
}

// второй вариан решения

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int decToBinVarsion2 = DecToBinVarsion2(number);
Console.WriteLine(decToBinVarsion2);

int DecToBinVarsion2(int num)
{
    int result = 0;
    int ostatok = 0;
    int multiplyer = 1;

    while (num != 0)
    {
        ostatok = num % 2;
        result = result + ostatok * multiplyer;
        num = num/2;
        multiplyer*= 10;
    }
    return result;
}*/
