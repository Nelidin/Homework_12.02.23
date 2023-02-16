// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//                                     значения b1, k1, b2 и k2 задаются пользователем.

//                                      b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("введите значение b1");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение k1");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение b2");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение k2");
double k2 = int.Parse(Console.ReadLine()!);

if (k1 != k2 && b1 != b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

Check(k1, b1, k2, b2);

void Check(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают во всех своих точках.");
    else if (k1 == k2)
        Console.WriteLine("Точки пересечения нет, прямые параллельны.");
}