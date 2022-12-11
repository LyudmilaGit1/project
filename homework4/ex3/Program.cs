//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
 int [] arrRandom(int len)
{
    int[]a=new int[len];
   for(int i=0;i<a.Length;i++)
 {
  a[i]=new Random().Next(0,1000);
 }
  return a;
}
void arrPrint(int[]a)
{
for(int i=0;i<a.Length;i++)
Console.Write($"{a[i]},");
Console.WriteLine();
}
int[] arr=arrRandom(8);
arrPrint(arr);
