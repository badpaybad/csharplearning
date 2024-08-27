double bai33(int n)
{
    double result = 0;
    for (int i = 0; i < n; i++)
    {
        result = Math.Sqrt(2 + result);
    }
    return result;
}

double bai34(int n)
{
    if (n == 0)
        return 0;
    double result = 1;
    for (int i = 1; i < n; i++)
    {
        result = Math.Sqrt((i + 1) + result);
    }
    return result;
}

double bai35(int n)
{
    if (n == 0)
        return 0;
    double result = Math.Sqrt(n);
    for (int i = n - 1; i >= 1; i--)
    {
        result = Math.Sqrt(i + result);
    }
    return result;
}

double bai36(int n)
{
    if (n == 0)
        return 0;
    double result = 1;
    for (int i = 1; i < n; i++)
    {
        int value = 1;
        for (int j = 1; j <= (i + 1); j++)
        {
            value *= j;
        }
        result = Math.Sqrt(value + result);
    }
    return result;
}

double bai37(int n)
{
    if (n == 0)
        return 0;
    double result = Math.Sqrt(2);
    for (int i = 3; i <= n; i++)
    {
        result = Math.Pow((i + result), (double)1 / i);
    }
    return result;
}

double bai38(int n)
{
    if (n == 0)
        return 0;
    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        result = Math.Pow((i + result), (double)1 / (i + 1));
    }
    return result;
}

double bai39(int n)
{
    if (n == 0)
        return 0;
    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        int value = 1;
        for (int j = 1; j <= i; j++)
        {
            value *= j;
        }
        result = Math.Pow((value + result), (double)1 / (i + 1));
    }
    return result;
}

double bai40(int n, int x)
{
    double result = 0;
    for (int i = 1; i <= n; i++)
    {
        result = Math.Sqrt(Math.Pow(x, i) + result);
    }
    return result;
}

Console.WriteLine("Bai 33: " + bai33(int.Parse(args[0])));
Console.WriteLine("Bai 34: " + bai34(int.Parse(args[0])));
Console.WriteLine("Bai 35: " + bai35(int.Parse(args[0])));
Console.WriteLine("Bai 36: " + bai36(int.Parse(args[0])));
Console.WriteLine("Bai 37: " + bai37(int.Parse(args[0])));
Console.WriteLine("Bai 38: " + bai38(int.Parse(args[0])));
Console.WriteLine("Bai 39: " + bai39(int.Parse(args[0])));
Console.WriteLine("Bai 40: " + bai40(int.Parse(args[0]), int.Parse(args[1])));