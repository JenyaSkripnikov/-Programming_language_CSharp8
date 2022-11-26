/*Задача 58:
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] InitMatrix1(int m, int n)
{
    int [,] matrix1 = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rnd.Next(0, 10);
        }
    }

    return matrix1;
}

int[,] InitMatrix2(int m, int n)
{
    int [,] matrix2 = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = rnd.Next(0, 10);
        }
    }

    return matrix2;
}

void PrintMatrix1(int [,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintMatrix2(int [,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] MatrixComposition(int [,] matrix1, int [,] matrix2)
{
    int [,] composition = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                composition[i, j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }

    return composition;
}

void PrintMatrixComposition(int [,] composition)
{
    for (int i = 0; i < composition.GetLength(0); i++)
    {
        for (int j = 0; j < composition.GetLength(1); j++)
        {
            Console.Write($"{composition[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк и столбцов матриц: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int[,] matrix1 = InitMatrix1(m,n);
int[,] matrix2 = InitMatrix2(m,n);
PrintMatrix1(matrix1);
Console.WriteLine();
PrintMatrix2(matrix2);
Console.WriteLine();
int[,] composition = MatrixComposition(matrix1, matrix2);
PrintMatrixComposition(composition);