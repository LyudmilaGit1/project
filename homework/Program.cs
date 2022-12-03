
//Напишите программу, которая на вход принимает 2 числа, и выдает какое число больше а какое меньше.
//а =5; b=7; max=7
// a=2; b=10; max=10
// a=-9; b=-3; max=-3

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
Console.WriteLine("первое число больше второго");
}
else
if(n1<n2)
{
Console.WriteLine("второе число больше первого");
}
else
if(n1==n2)
{
Console.WriteLine("ваши числа равны");
}
