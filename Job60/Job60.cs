/*Задача 60:Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента. Массив размером 2 x 2 x 2.
Например:
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] InitArray(int m, int n, int z)
{
    int [,,] array = new int[m,n,z];
    var knownNumber = new HashSet<int>();
    int newElement;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                {
                    newElement = rnd.Next(10,100);
                }
                while (!knownNumber.Add(newElement));
                {
                    array[i,j,k] = newElement;
                } 
            }
        }
    }

    return array;
}

void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int m = 2;
int n = 2;
int z = 2;
int[,,] array = InitArray(m, n, z);
PrintArray(array);
Console.WriteLine();