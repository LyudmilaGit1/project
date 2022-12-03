\\ Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1>num2>num3)
{
Console.WriteLine("num1-максимальное число");
}
else
if(num1>num2<num3)
{
Console.WriteLine("num3-максимальное число");
}
else
if(num2>num1>num3)
{
Console.WriteLine("num2-максимальное число");
}
