// ВТОРОЙ ВАРИАНТ!!!! Задача 23 
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число N ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= num)
{
    double num2 = Math.Pow(count,3);
    Console.WriteLine(num2);
    count++;
}

