/*Задача 54:Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

int[,] NewArray(int[,] array, int m, int n)
{
    int temp = new int();
        
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if((array[i, j] < array[i, k]))
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
             
        }   
    }

    return array;
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
Console.WriteLine();
int[,] newArray = NewArray(array, m, n);
PrintArray(newArray);
