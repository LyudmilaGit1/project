//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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
       table[i,j]=new Random().Next(0,10);
      }
    }
}
int[,] tabl1 = new int[2,2];
FillArray(tabl1);
PrintArray(tabl1);
Console.WriteLine();


int[,] tabl = new int[2,2];
FillArray(tabl);
PrintArray(tabl);
Console.WriteLine();


int[,] result = new int[2,2];
for(int i=0;i<result.GetLength(0);i++)
    {
       for(int j=0;j<result.GetLength(1);j++)
      {
        int sum=0;
        for (int k = 0; k < tabl1.GetLength(1); k++)
      {
        sum += tabl1[i,k] * tabl[k,j];
      }
      result[i,j] = sum; //sum=tabl1[i,j]*tabl[i,j]+tabl1[i,j]*tabl[i,j];
       //result[0,0]=tabl1[0,0]*tabl[0,0]+tabl1[0,1]*tabl[1,0];
       //result[0,1]=tabl1[0,0]*tabl[0,1]+tabl1[0,1]*tabl[1,1];
       //result[1,0]=tabl1[1,0]*tabl[0,0]+tabl1[1,1]*tabl[1,0];
       //result[1,1]=tabl1[1,0]*tabl[0,1]+tabl1[1,1]*tabl[1,1];
      Console.Write($"{sum},");
      }
       Console.WriteLine(); 
    }
FillArray(result);
Console.WriteLine();
 




