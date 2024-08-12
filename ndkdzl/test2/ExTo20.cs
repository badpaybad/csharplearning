//exercise 11

int exercise11(int n)
{
    int total = 0;
    for(int i = 1; i <= n; i++)
    {
        int count = 1;
        for(int j = 1; j <= i; j++)
        {
            count *= j;
            // i = 1 => count = 1
            // i = 2 => count = 1*2
            // i = 3 => count = 1*2*3
            // i = 4 => count = 1*2*3*4
            // 4 => count = 6*4
        }

        total += count;
    }
    return total;
}

double exercise12(int n, int x){
    double total = 0;
    for(int i = 1; i <= n; i++)
    {
    total += Math.Pow(x, i);
    }

    return total;
}

double exercise13(int n, int x)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        total += Math.Pow(x, 2*i);
    }

    return total;
}

double exercise14(int n, int x)
{
    double total = 0;
    for (int i = 0; i <= n; i++)
    {
        total += Math.Pow(x, (2 * i)+1);
    }

    return total;
}

double exercise15(int n)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        double count = 0;
        for(int j = 1; j <= i; j++)
        {
            count += j;
        }
        total += 1 / count;
    }

    return total;
}

double exercise16(int n, int x)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        double count = 0;
        for (int j = 1; j <= i; j++)
        {
            count += j;
        }
        total += Math.Pow(x, i) / count;
    }

    return total;
}

double exercise17(int n, int x)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        double count = 1;
        for (int j = 1; j <= i; j++)
        {
            count *= j;
        }
        total += Math.Pow(x, i) / count;
    }

    return total;
}

double exercise18(int n, int x)
{
    double total = 1;
    for (int i = 1; i <= n; i++)
    {
        double count = 1;
        for (int j = 1; j <= 2*i; j++)
        {
            count *= j;
        }
        total += Math.Pow(x, 2*i) / count;
    }

    return total;
}

double exercise19(int n, int x)
{
    double total = 1 + x;
    for (int i = 1; i <= n; i++)
    {
        double count = 1;
        for (int j = 1; j <= (2 * i) + 1; j++)
        {
            count *= j;
        }
        total += Math.Pow(x, (2 * i) + 1) / count;
    }

    return total;
}

void exercise20(int n)
{
    for(int i = 1; i<= n; i++)
    {
        if (n % i == 0)
        {
            Console.WriteLine("Boi so cua " + n + " la : " + i);
        }
    }
}

Console.WriteLine(exercise11(5));
Console.WriteLine(exercise12(3,4));
Console.WriteLine(exercise13(3,2));
Console.WriteLine(exercise14(2,2));
Console.WriteLine(exercise15(3));
Console.WriteLine(exercise16(2,2));
Console.WriteLine(exercise17(3,2));
Console.WriteLine(exercise18(3,2));
Console.WriteLine(exercise19(2,2));
exercise20(12);
Console.ReadLine();

