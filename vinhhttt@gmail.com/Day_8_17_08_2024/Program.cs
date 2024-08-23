// Bai 22

long Bai22(int n)
{
    long tich = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            tich *= i;
        }
    }
    return tich;
}

Console.WriteLine(Bai22(10));


// Bai 23

int Bai23(int n)
{
    int dem = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            dem++;
        }
    }
    return dem;
}

Console.WriteLine(Bai23(10));


// Bai 24

void Bai24(int n)
{
    for (int i = 1; i <= n; i += 2)
    {
        if (n % i == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}

Bai24(10);