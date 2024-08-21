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

Console.WriteLine("Bai 33: " + bai33(int.Parse(args[0])));
Console.WriteLine("Bai 34: " + bai34(int.Parse(args[0])));
Console.WriteLine("Bai 35: " + bai35(int.Parse(args[0])));