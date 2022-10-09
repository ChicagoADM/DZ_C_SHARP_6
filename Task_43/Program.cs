// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach43()
{   Console.Clear();
    Console.WriteLine("Введите первую координату первого отрезка (b1): ");
    double  b1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите вторую координату первого отрезка (k1): ");
    double k1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите первую координату второго отрезка (b2): ");
    double b2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите вторую координату второго отрезка (k2): ");
    double k2 = int.Parse(Console.ReadLine()!);
    double x = (b2-b1)/(k1-k2);
    x = Math.Round(x, 2);
    double y = k1*x + b1;
    y = Math.Round(y, 2);
    Console.WriteLine($"Точка пересечения двух заданных прямых: X = {x}; Y = {y}");
}
Zadach43();
Exit();