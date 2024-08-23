// Bai 25
int Bai25(int n)
{
    int tong = 0;
    for (int i = 2; i <= n; i += 2)
    {
        if (n % i == 0)
        {
            tong += i;
        }
    }
    return tong;
}

Console.WriteLine(Bai25(10));

// Bai 26
int Bai26(int n)
{
    int product = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            product *= i;
        }
    }
    return product;
}

Console.WriteLine(Bai26(10));

//Bai 27

int Bai27(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(Bai27(10)); // Output: 2

