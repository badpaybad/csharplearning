// bai 31

int Bai31(int n)
{
    if (n < 2) return 0;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return 0;
        }
    }
    return 1;
}

Console.WriteLine(Bai31(29));


// bai 32

int Bai32(int n)
{
    int sqrt = (int)Math.Sqrt(n);
    return sqrt * sqrt == n ? 1 : 0;
}

Console.WriteLine(Bai32(25));


// Bai 33

static double Bai33(int n)
{
    if (n == 1)
    {
        return Math.Sqrt(2);
    }
    else
    {
        return Math.Sqrt(2 + Bai33(n - 1));
    }
}

Console.WriteLine(Bai33(3));