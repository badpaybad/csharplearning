// Bai 51

int Bai51(int n)
{
    int maxDigit = 0;

    while (n > 0)
    {
        int digit = n % 10;
        if (digit > maxDigit)
        {
            maxDigit = digit;
        }
        n /= 10;
    }

    return maxDigit;
}

Console.WriteLine(Bai51(12345));


// Bai 52

int Bai52(int n)
{
    int minDigit = 9;

    while (n > 0)
    {
        int digit = n % 10;
        if (digit < minDigit)
        {
            minDigit = digit;
        }
        n /= 10;
    }

    return minDigit;
}

Console.WriteLine(Bai52(12345));

// Bai 53
int Bai53(int n)
{
    int maxDigit = 0;
    int count = 0;

    while (n > 0)
    {
        int digit = n % 10;
        if (digit > maxDigit)
        {
            maxDigit = digit;
            count = 1;
        }
        else if (digit == maxDigit)
        {
            count++;
        }
        n /= 10;
    }

    return count;
}

Console.WriteLine(Bai53(123455));

