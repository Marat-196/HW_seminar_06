// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = b2 - b1 / (k1 - k2) -> x = 4 - 2/ (5 - 9) = -0,5
// y = k1 * x + b1 -> y = 5*(-0,5) + 2 = -0,5

void IntersectionLines(double numb1, double numk1, double numb2, double numk2)
{
    double x = (numb2 - numb1) / (numk1 - numk2);
    double y = numk2 * x + numb2;
    Console.Write($"({x}, {y})");
}

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
// x = b2 - b1 / (k1 - k2) -> x = 4 - 2/ (5 - 9) = -0,5
// y = k1 * x + b1 -> y = 5*(-0,5) + 2 = -0,5

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
IntersectionLines(b1, k1, b2, k2);



