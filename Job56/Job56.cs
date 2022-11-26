/*Задача 56:Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

int[,] InitArray(int m, int n)
{
    int [,] array = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
    }

    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] StringsValue(int [,] array)
{
    int[] result = new int[array.GetLength(0)];
    int sum = new int();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; 
        }
        result[i] = sum;
        sum = 0;
    }

    return result;
}

void Minsum(int[] array)
{
    int result = new int();
    int min = array.Min();
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == min) result = i + 1;
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
Console.WriteLine();
int[] stringsValue = StringsValue(array: array);
Minsum(array: stringsValue);