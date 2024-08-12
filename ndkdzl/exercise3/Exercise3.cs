int exercise21(int n)
{
    int total = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            total += i;
        }
    }
    return total;
}

int exercise22(int n)
{
    int total = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            total *= i;
        }
    }
    return total;
}

int exercise23(int n)
{
    int count= 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            count++;
        }
    }
    return count;
}

int exercise24(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

void exercise25(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            Console.WriteLine("Cac so le thuoc uoc cua " + n + " la: " i);
        }
    }
}

Console.WriteLine(exercise21(12));
Console.WriteLine(exercise22(12));
Console.WriteLine(exercise23(12));
Console.WriteLine(exercise24(12));
exercise25(12);
Console.ReadLine();