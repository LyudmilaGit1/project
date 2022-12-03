//Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

while(N>2)
{
   if(N%2==0)
{
 N=N-2;
}
else
if(N%2>0)
{    
   N=N-1;
}
Console.WriteLine(N);
}


