// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetSumNum(string text)
{
    int sum = 0;
    for (int i = 0; i < text.Length; i++)
    {
        string symbol = text[i].ToString(); // char text[i]
        // Console.WriteLine(symbol);
        // Console.WriteLine(Convert.ToInt32(symbol));
        sum = sum + Convert.ToInt32(symbol);
    }
    return sum;
}

Console.WriteLine("Введите число");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);

if (num >= 0)
{
    Console.WriteLine(GetSumNum(str));
}
else 
{
    Console.WriteLine("Ошибка");
}
