//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
    for(int j=1;j<tabl.GetLength(1)-1;j++)
    {      
      for (int k = 0; k < tabl.GetLength(1) - 1; k++)
      {
        if (tabl[i, k] < tabl[i, k + 1])
        {
          int change = tabl[i, k + 1];
          tabl[i, k + 1] = tabl[i, k];
          tabl[i, k] = change;
      } 
      }
    }
}
Console.WriteLine();
PrintArray(tabl);
    