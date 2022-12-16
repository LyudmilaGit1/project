//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


void PrintDoubleArray(int[,] table)
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
void FillDoubleArray(int[,] table)
{
  for(int i=0;i<table.GetLength(0);i++)
    {
    for(int j=0;j<table.GetLength(1);j++)
      {
       table[i,j]=new Random().Next(-10,20);
      }
    }
}
int [,] tabl= new int[5,7];
FillDoubleArray(tabl);
PrintDoubleArray(tabl);

Console.Write("Введите индекс строки от 0 до 4: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца от 0 до 6: ");
int column = Convert.ToInt32(Console.ReadLine());

if(row>4) 
{
  Console.WriteLine("введите правильные координаты");
}
if(column>6)
{
  Console.WriteLine("введите правильные координаты");
}

Console.Write($"{tabl[row,column]}");
Console.WriteLine();


//if(i[row]==j[column])
