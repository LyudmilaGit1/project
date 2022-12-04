//1. программа, которая принимает 5ти значное число и проверяет является ли оно палиндромом.

Console.Write("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int a1=n%10;    //последнее
int n1=n/10%10;    //предпосл
int r=n/10000;      //первое
int k=n/1000%10; //второе
int d=n1*10+a1;
int c=k*10+r;
//Console.WriteLine(d);
//Console.WriteLine(c);
//Console.WriteLine(r);
//Console.WriteLine(k);
if(d==c)
 Console.WriteLine("Ваше число палиндром");
else
if(a1>r||n1>k)
{
Console.WriteLine("Ваше число не палиндром");
}
//else
//if(d>c)
//{
//Console.WriteLine("Ваше число не палиндром");
//}