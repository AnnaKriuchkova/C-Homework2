// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] route = new int[,]
{
{0,0}, {0,1}, {0,2}, {0,3}, {1,3}, {2,3}, {3,3}, {3,2}, {3,1}, {3,0}, {2,0}, {1,0}, {1,1}, {1,2}, {2,2}, {2,1}
};

int [,] array = new int[4,4];

void GetArray()
{
    for (int i = 0; i < route.GetLength(0); i++)
    {
        int j = route[i,0];
        int k = route[i,1];
        array[j,k] = i;
    }
}

void PrintArray()
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
GetArray();
PrintArray();
