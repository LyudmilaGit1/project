//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


for(int i=0;i<tabl.GetLength(0);i++)
 {
    int summ=0;
    int min=summ;
       for(int j=0;j<tabl.GetLength(1);j++)
      {
       
       summ=tabl[i,j]+summ; 
       if(summ<min) min=summ;
      }   
      
   Console.Write($"{summ},");   
   
   }
int SumElem(int[,] table, int i)
{
  int sumLine = tabl[i,0];
  for (int j = 1; j < tabl.GetLength(1); j++)
  {
    sumLine += tabl[i,j];
  }
  return sumLine;
}

int minSum = 0;
int sumLine = SumElem(tabl, 0);
for (int k = 1; k < tabl.GetLength(0); k++)
{
  int SumLine = SumElem(tabl, k);
  if (sumLine > SumLine)
  {
    sumLine = SumLine;
    minSum = k;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой({sumLine})");


