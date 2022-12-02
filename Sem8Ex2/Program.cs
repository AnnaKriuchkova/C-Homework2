// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());


int [,] array = new int [rows,rows];
int [] arraySum = new int[rows];
int [,] GetArray()
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           array[i,j] = new Random().Next(0,11);
           arraySum[i]+= array[i,j];
        }
    }
    return array;
}

int [,] PrintArray(int[,]array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
    return array;
}

void GetMaxRow()
{
    int minRowIndex = 0;
    int minSum = arraySum[0];

    for (int i = 0; i < arraySum.Length; i++)
    {
        if(arraySum[i] < minSum)
        {
            minSum = arraySum[i];
            minRowIndex = i;
        }
    }

Console.WriteLine("Номер строки с наименьшей суммой элементов: " +minRowIndex +" строка");
}

PrintArray(GetArray());
Console.WriteLine("____________");
Console.WriteLine(String.Join(" ",arraySum));
GetMaxRow();