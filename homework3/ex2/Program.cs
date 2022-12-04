//принимает координаты 2х точек и находит расстояние между ними в 3д пространстве
//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координату x: ");
double x= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
double y= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z: ");
double z= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x1: ");
double x1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1= Convert.ToInt32(Console.ReadLine());
double m = x1-x;
double n = y1-y;
double k = z1-z;
double b = 2;
double result =Math.Pow(m,b);
double result1 =Math.Pow(n,b);
double result2 =Math.Pow(k,b);
double L = result+result1+result2;
double res = Math.Sqrt(L);
Console.WriteLine($"Квадратный корень {L} равен: {res}");


