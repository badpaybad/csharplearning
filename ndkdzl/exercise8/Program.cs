double exercise71(int x, int n)
{
    double total = 0;
    int seperate = 0;
    for (int i = 1; i <= n; i++)
    {
        seperate = 0;
        for(int j = 1; j <= i; j++)
        {
            seperate += j;
        }
        total += (Math.Pow(-1, i)) * (Math.Pow(x, i) / seperate);
    }

    return total;
}

double exercise72(int x, int n)
{
    double total = 0;
    int seperate = 0;
    for (int i = 1; i <= n; i++)
    {
        seperate = 1;
        for (int j = 1; j <= i; j++)
        {
            seperate *= j;
        }
        total += (Math.Pow(-1, i)) * (Math.Pow(x, i) / seperate);
    }

    return total;
}

double exercise73(int x, int n)
{
    double total = 0;
    for (int i = 0
        ; i <= n; i++)
    {
        int seperate = 1;
        for (int j = 1; j <= 2*i; j++)  
        {
            seperate *= j;
        }
        total += (Math.Pow(-1, i+1)) * (Math.Pow(x, 2*i) / seperate);
    }

    return total;
}

double exercise74(int x, int n)
{
    double total = 1;
    for (int i = 0
        ; i <= n; i++)
    {
        int seperate = 1;
        for (int j = 1; j <= (2 * i) + 1; j++)
        {
            seperate *= j;
        }
        total += (Math.Pow(-1, i + 1)) * (Math.Pow(x, (2 * i)+1) / seperate);
    }

    return total;
}


Console.WriteLine(exercise71(5, 2));
Console.WriteLine(exercise72(5, 2));
Console.WriteLine(exercise73(4, 2));
Console.WriteLine(exercise74(4, 1));
Console.ReadLine();
