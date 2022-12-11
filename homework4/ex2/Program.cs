//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.Write("Введите число: ");
int x=Convert.ToInt32(Console.ReadLine());
string Num =Convert.ToString(x);

int L=Num.Length;
int[] M=new int[L];
int m=x;
int n=0;
for(int i=0;i<L;i++)
{
  M[i]=m%10;
  m/=10;
 
 n=M[i]+n;
}
Console.WriteLine(n);