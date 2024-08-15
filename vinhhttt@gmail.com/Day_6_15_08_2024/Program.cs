// bai 16


double Bai16(double x, int n)
{
    double sum = x;
    double ms = 2;
    double lt = x * x; 
    for (int i = 2; i <= n; i++)
    {
        ms += i + 1;
        lt *= x;
        sum += lt / ms;
    }
    return sum;
}

Console.WriteLine(Bai16(2, 3));


// Bai 17

double Bai17(double x, int n)
{
    double sum = 1;
    double gt = 1;
    double lt = x;
    for (int i = 1; i <= n; i++)
    {
        gt *= i;
        lt *= x;
        sum += lt / gt;
    }
    return sum;
}

Console.WriteLine(Bai17(2, 3));


// Bai 18

double Bai18(double x, int n)
{
    double sum = 1;
    double gt = 1;
    double lt = x;

    if (n % 2 == 0)
    {
        for (int i = 1; i <= n; i += 2) 
        {
            gt *= i * (i + 1);
            lt *= x * x;
            sum += lt / gt;
        }
    }
 
    return sum;
}

Console.WriteLine(Bai18(2, 3));