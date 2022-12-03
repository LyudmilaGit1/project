//3. принимает (N), и выдает таблицу кубов от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=N; i++)
{
    Console.WriteLine($"{i}*{i}*{i}={i*i*i}");
}