/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Сколько чисел вы будете вводить?: ");
int amount = Convert.ToInt32(Console.ReadLine());

int[] array = GetNewArray(amount);
PrintArray(array);
int countPositiveNumber = CountPositiveNumber(array);
Console.WriteLine($"{countPositiveNumber} чисел больше нуля ввел пользователь");


int[] GetNewArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write("Введите число: ");
        arr [i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + " ");
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine();
}

int CountPositiveNumber(int arr[i]);
{ int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        count = count + 1;

    }
    return count;
}