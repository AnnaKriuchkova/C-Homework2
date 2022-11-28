// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = new int[10];  
int evenN = 0;

int [] GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(100,1000);
        if(array[i]%2 == 0)
        {
            evenN += 1;

        }
    }
    return array;

}
GetArray(array);

Console.WriteLine(String.Join(" ",array));

Console.WriteLine("Количество четных чисел в массиве равно "+evenN);
