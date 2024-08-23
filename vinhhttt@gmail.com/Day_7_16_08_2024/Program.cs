// bai 19

double Bai19(int n, double x)
{
    double sum = 1;

    for (int i = 1; i <= n; i++)
    {
        double factorial = 1;
        for (int j = 1; j <= 2 * i + 1; j++)
        {
            factorial *= j;
        }
        x = Math.Pow(x, 2 * i + 1) / factorial;
        sum += x;
    }
    return sum;
}
Console.WriteLine(Bai19(3, 2));

// bai 20

 void Bai20(int n)
{
 
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}
Bai20(12);

//bai 21

 int Bai21(int n)
{
    int tong = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            tong += i;
        }
    }
    return tong;
}
Console.WriteLine(Bai21(12));