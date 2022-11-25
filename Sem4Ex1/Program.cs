// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double MethodPow(int a, int b)
{
    double result = Math.Pow(a,b);
    return result;
}

Console.WriteLine("Введите перое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(MethodPow(num, num2));


