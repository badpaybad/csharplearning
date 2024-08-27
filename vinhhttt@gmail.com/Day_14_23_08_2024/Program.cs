// Bai 45
int Bai45(int n)
{
    int x = 1;

    while (n > 0)
    {
        x *= n % 10;
        n /= 10;
    }

    return x;
}

Console.WriteLine(Bai45(12345));

// Bai 46

int Bai46(int n)
{
    int count = 0;

    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 != 0)
        {
            count++;
        }
        n /= 10;
    }

    return count;
}

Console.WriteLine(Bai46(12345));


// Bai 47

static int Bbai47(int n)
{
    int sum = 0;

    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 == 0)
        {
            sum += digit;
        }
        n /= 10;
    }

    return sum;
}

Console.WriteLine(Bbai47(12345));