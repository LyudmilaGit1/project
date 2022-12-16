//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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


{
double Summa=0;
double Summa1=0;
double Summa2=0;
double Summa3=0;

 for(int i=0;i<tabl.GetLength(0);i++)
 {
   for(int j=0;j<tabl.GetLength(1);j++)
   {
    if(j==0)
     Summa +=tabl[i,j];
     else
    if(j==1)
     Summa1 +=tabl[i,j];
    else
    if(j==2)
     Summa2 +=tabl[i,j];
    else
    if(j==3)
     Summa3 +=tabl[i,j];
   }
}
  
double Means=Summa/3;
double Means1=Summa1/3;
double Means2=Summa2/3;
double Means3=Summa3/3;
Console.WriteLine($"сумма: {Summa},{Summa1},{Summa2},{Summa3}");
Console.WriteLine($"среднее арифметическое: {Means},{Means1},{Means2},{Means3}");
}
      
//Console.WriteLine($"{Mean}");



 