

//bai 10


double Bai10(double x, int n)
{
    return Math.Pow(x, n);
}

Console.WriteLine(Bai10(2, 3));


//bai 11


int Bai11(int n)
{
    if (n == 0)
        return 1;
    else
        return n * Bai11(n - 1);
}

Console.WriteLine(Bai11(5));


//bai 12


double Bai12(int n, int x)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(x, i);
    }
    return sum;
}

Console.WriteLine(Bai12(3, 2));