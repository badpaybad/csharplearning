// bai 13

double Bai13(int n, int x)
{

    double sum = 0;
    if (n % 2 == 0)
    {

        for (int i = 2; i <= n; i += 2)
        {
            sum += Math.Pow(x, i);
        }
    }

    return sum;
}

Console.WriteLine(Bai13(4, 2));

//  bai 14

double Bai14(int n, int x)
{
    double sum = 0;
    if (n % 2 != 0)
    {
        for (int i = 1; i <= n; i += 2)
        {
            sum += Math.Pow(x, i);
        }
    }
    return sum;
}

Console.WriteLine(Bai14(3, 2));


//  bai 15

double Bai15(int n, int x)
{
    double sum = 0;
    double ms = 1;
    for (int i = 1; i <= n; i++)
    {
        sum += 1 / ms;
        ms += i + 1;
    }
    return sum;
}

Console.WriteLine(Bai15(3, 2));

