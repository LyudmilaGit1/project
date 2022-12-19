//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
void PrintArray(int[, ,] table)
{
for(int i=0;i<table.GetLength(0);i++)
  {
    for(int j=0;j<table.GetLength(1);j++)
    {
        for(int k=0;k<table.GetLength(1);k++)
        {
            Console.Write($"{table[i,j,k]},");
        }
    }
    Console.WriteLine();
}  
}
void FillArray(int[, ,] table)
{
  for(int i=0;i<table.GetLength(0);i++)
    {
    for(int j=0;j<table.GetLength(1);j++)
      {
       for(int k=0;k<table.GetLength(1);k++)
        {
            table[i,j,k]=new Random().Next(-10,20);
      }
    }
}
}
int [, ,] tabl= new int[2,2,2];

FillArray(tabl);
PrintArray(tabl);
Console.WriteLine();

for(int i=0;i<tabl.GetLength(0);i++)
    {
    for(int j=0;j<tabl.GetLength(1);j++)
      {
       for(int k=0;k<tabl.GetLength(1);k++)
        {
            Console.Write($"{tabl[i,j,k]},({i}{j}{k}),");
        }
      }
    }