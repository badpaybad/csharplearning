// Bai 54
 int Bai54(int n)
{
    int minDigit = 9;
    int count = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit < minDigit)
        {
            minDigit = digit;
            count = 1;
        }
        else if (digit == minDigit)
        {
            count++;
        }
        n /= 10;
    }
    return count;
}

Console.WriteLine(Bai54(123456789));

// Bai 55
 int Bai55(int n)
{
    int firstDigit = n;
    while (firstDigit >= 10)
    {
        firstDigit /= 10;
    }
    int count = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit == firstDigit)
        {
            count++;
        }
        n /= 10;
    }
    return count;
}

Console.WriteLine(Bai55(123456789));

//  Bai 56
bool Bai56(int n)
{
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 == 0)
        {
            return false;
        }
        n /= 10;
    }
    return true;
}

Console.WriteLine(Bai56(123456789));