/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] InitMatrix(int m, int n, int firstNumber)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            matrix[i,j] = firstNumber++;
        }
        for (int k = i + 1; k < m - i;  k++)        
        {
            matrix[k,n - 1 - i] = firstNumber++;
        }
        for (int j = n - i - 2; j >= i; j--)
        {
            matrix[n - 1 - i,j] = firstNumber++;
        }
        for (int k = n - 2 -i; k > i; k--)
        {
            matrix[k,i] = firstNumber++;
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = 4;
int n = 4;
Console.Write("Введите начальное значение индекса (0,0): ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InitMatrix(m,n,firstNumber);
Printmatrix(matrix);