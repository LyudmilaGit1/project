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
int min=summ;

if(summ>summ1) min=summ1;
 if(summ2<summ1) min=summ2;
 int result=Math.Min(min,summ);

  Console.Write($"{result}");   
   Console.WriteLine();