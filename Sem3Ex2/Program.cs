// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine($"Первая точка - ({x1}, {y1}, {z1})");
Console.WriteLine($"Вторая точка - ({x2}, {y2}, {z2})");
Console.WriteLine($"Расстояние между точками - {Math.Round(result, 2,MidpointRounding.ToEven)}");
