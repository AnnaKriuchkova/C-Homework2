//Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите размерность матриц");
int rows = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = new int [rows,rows];
int [,] matrix2 = new int [rows,rows];
int [,] matrix3 = new int [rows,rows];

int [,] GetArray(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(0,11);
        }
    }
    return matrix;
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

int [,] Multiplication(int[,]m1, int[,]m2, int[,]m3)
{
     for (int i = 0; i < m3.GetLength(0); i++)
    {
        for (int j = 0; j < m3.GetLength(1); j++)
        {
            m3[i,j] = m1[i,j]*m2[i,j];
        }
    }
    return m3;
}


Console.WriteLine("Матрица 1");
GetArray(matrix1);
PrintArray(matrix1);
Console.WriteLine("____________");
Console.WriteLine("Матрица 2");
GetArray(matrix2);
PrintArray(matrix2);
Console.WriteLine("____________");
Console.WriteLine("Матрица 3");
Multiplication(matrix1, matrix2, matrix3);
PrintArray(matrix3);