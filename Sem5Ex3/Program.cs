// // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] array = new double[10]; // 

double [] GetArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(-99,100);
    }
    return array;

}

void GetDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i]; 
        }
        else if (array[i]< min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    Console.WriteLine("Максимальное значение "+ max+" Минимальное значение "+ min);
    Console.WriteLine("Разница между максимальным и минимальным значением равна "+diff);
}

GetArray(array);
Console.WriteLine(String.Join(" ",array));
GetDiff(array);

double [] array2 = {-40.15, 0, 12.3, 38, -7,6, 88, -9, 10, -2.25, 25};
Console.WriteLine(String.Join(" ",array2));
GetDiff(array2);

