// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество чисел");
int count = Convert.ToInt32(Console.ReadLine());
int positive = 0;

int [] array = new int [count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine("Введите число");
    int num =Convert.ToInt32(Console.ReadLine());

    array[i]= num;
    if(array[i] > 0)
    {
        positive++;
    }
}

Console.WriteLine(String.Join(" ",array));
Console.WriteLine("Количество чисел больше 0 равно "+positive);