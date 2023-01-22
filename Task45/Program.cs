/*Напишите программу, 
которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/
int [] arrayOrigin = CreateArrayRndInt(10,-3,5);
int[] arrayCopy = CopyArray(arrayOrigin);
arrayCopy[0] = 30;          //для проверки
PrintArray(arrayOrigin);
PrintArray(arrayCopy);


int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];  //создаем массив такой же длины
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];             //перезаписываем данные в массив
    }
    return result;
}

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write(arr[i] + " ,");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}


//к дз 41
//string str = "1,4,6,8,0,-56";
//string[] strArr = str.Split(',');