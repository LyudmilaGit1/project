//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double b=b2-b1;
double k=k1-k2;
double point= b/k;
Console.WriteLine($"{point}");
