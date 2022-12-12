//вывести первые N чисел фибоначи. первое 0, второе 1
WriteLine("Введите число: ");
WriteLine(string.Join(Febonacci(int.Parse(ReadLine()))));
int[] Febonacci(int n);
{
    int[] count = new int[n];
    count[0]=0;
    count[1]=1;
    for(int i=2;i<=count.Length-1;i++)
    {
        count[i]=count[i-1]+count[i-2];
    }
    return count;
}