
// Второй вариант!!!!! Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if((num >= 100)&&(num < 1000))
{
    int num2 = num/10;
    int result = num2%10;
    Console.WriteLine("Вторая цифра числа "+num+" это "+result);
}
else
{
    Console.WriteLine("Ошибка");
}