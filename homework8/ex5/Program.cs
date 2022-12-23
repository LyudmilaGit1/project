//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

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
 int m = 5;
 int n = 5;
 
 int s = 1;
 
int[,] tabl = new int[m,n];

        //Заполняем периметр массива по часовой стрелке.
 for (int j = 0; j < n; j++) 
     {
        tabl[0,j] = s;
         s++;
    }
     for (int i = 1; i < m; i++) 
     {
         tabl[i,n - 1] = s;
         s++;
        }
        for (int j = n - 2; j >= 0; j--) 
        {
            tabl[m - 1,j] = s;
            s++;
        }
        for (int i = m - 2; i > 0; i--)
         {
           tabl[i,0] = s;
            s++;
        }
    
        int c = 1;
        int d = 1;
 
        while (s < m * n)
         {
             
            //вправо.
            while (tabl[c,d + 1] == 0) 
            {
                tabl[c,d] = s;
                s++;
                d++;
            }
 
            // вниз.
            while (tabl[c + 1,d] == 0) 
            {
                tabl[c,d] = s;
                s++;
                c++;
            }
 
            // влево.
            while (tabl[c,d - 1] == 0) 
            {
                tabl[c,d] = s;
                s++;
                d--;
            }
 
            // вверх.
            while (tabl[c - 1,d] == 0) {
                tabl[c,d] = s;
                s++;
                c--;
            }
        }
 
 
         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++) 
            {
                if (tabl[i,j] == 0) 
                    tabl[i,j] = s;
                 
          }
        
        }
PrintArray(tabl);

