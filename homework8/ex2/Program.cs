//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7
void PrintArray(int[,] table)
{
for(int i=0;i<table.GetLength(0);i++)
  {
    for(int j=0;j<table.GetLength(1);j++)
    {
        Console.Write($"{table[i,j]},");
    }
    Console.WriteLine();
}  
}
void FillArray(int[,] table)
{
  for(int i=0;i<table.GetLength(0);i++)
    {
    for(int j=0;j<table.GetLength(1);j++)
      {
       table[i,j]=new Random().Next(-10,20);
      }
    }
}
int [,] tabl= new int[3,4];
FillArray(tabl);
PrintArray(tabl);
Console.WriteLine();
int summ=0;
int summ1=0;
int summ2=0;




for(int i=0;i<tabl.GetLength(0);i++)
 {
    for(int j=0;j<tabl.GetLength(1);j++)
      {
        if(i==0) summ=tabl[i,j]+summ; 
        if(i==1) summ1=tabl[i,j]+summ1; 
        if(i==2) summ2=tabl[i,j]+summ2;
           
     }
     }
     Console.Write($"{summ},{summ1},{summ2},"); 
     Console.WriteLine();
     if(summ<summ1 && summ<summ2)
     Console.Write($"первая строка{summ}");
     if(summ1<summ && summ1<summ2)
     Console.Write($"вторая строка{summ1}");
     if(summ2<summ && summ2<summ1)
     Console.Write($"третья строка{summ2}");

   Console.WriteLine();
