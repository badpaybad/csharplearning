// bai 33

static double Bai33(int n)
{
    if (n == 1)
    {
        return Math.Sqrt(1);
    }
    else
    {
        return Math.Sqrt(n + Bai33(n - 1));
    }
}

Console.WriteLine(Bai33(5));


// bai 34

static double Bai34(int n)
{
    double result = Math.Sqrt(n);

    for (int i = n - 1; i >= 1; i--)
    {
        result = Math.Sqrt(i + result);
    }

    return result;
}

Console.WriteLine(Bai34(5));


// Bai 35


static double Factorial(int n)
{
    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

static double Bai35(int n)
{
    double result = Math.Sqrt(Factorial(n));

    for (int i = n - 1; i >= 1; i--)
    {
        result = Math.Sqrt(Factorial(i) + result); 
    }

    return result;

}

Console.WriteLine(Bai35(5));