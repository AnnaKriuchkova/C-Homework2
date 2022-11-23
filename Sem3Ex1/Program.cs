// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);

if((num >= 10000)&&(num < 100000))
{
    if((str[0] == str[4])&&(str[1] == str[3]))
    {
        Console.WriteLine(str+" является палиндромом");
    }
    else
    {
        Console.WriteLine(str+" не является палиндромом");
    }
}
else 
{
    Console.WriteLine("Ошибка");
}

