// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int MethodPow(int a, int b)
{
    int pow = a;
    for (int i = 1; i < b; i++)
        {
            pow = pow*a;
        }
        return pow;
}
    
Console.WriteLine("Введите перое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num+" в "+num2+" степени равно "+(MethodPow(num, num2)));