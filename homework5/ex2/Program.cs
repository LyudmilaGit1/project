//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int[] arL(int Len)
{
int[] a = new int[Len];
for(int i=0;i<a.Length;i++)
{
    a[i]=new Random().Next(10,100);
    }
    return a;
}  
    void arPrint(int[] a)
    {
        for(int i=0;i<a.Length;i++)
        Console.Write($"{a[i]}'");
        Console.WriteLine();
    }    
    int []ar=arL(15);
    arPrint(ar);
{
int N= ar.Length;
int sum=0;
for(int i=1;i<N;i=i+2)
{
  sum=sum+ar[i];
}
Console.WriteLine(sum);
}


