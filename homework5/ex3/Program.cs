
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int[] arL(int Len)
{
int[] a = new int[Len];
for(int i=0;i<a.Length;i++)
{
    a[i]=new Random().Next(0,100);
    }
    return a;
}  
    void arPrint(int[] a)
    {
        for(int i=0;i<a.Length;i++)
        Console.Write($"{a[i]}'");
        Console.WriteLine();
    }    
    int []ar=arL(11);
    arPrint(ar);
{
int N=ar.Length;    
int max=ar[0];
int min=ar[0];

for(int i=0;i<N;i++)
{
   if(ar[i]>max)

  max=ar[i];
else
if(ar[i]<min)

  min=ar[i];
}
Console.WriteLine(max-min);
}