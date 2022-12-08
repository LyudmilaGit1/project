//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Write("Введите число: ");
double x= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
double y= Convert.ToInt32(Console.ReadLine());
double res =Math.Abs(y);
double result= Math.Pow(x,res);
Console.WriteLine(result);