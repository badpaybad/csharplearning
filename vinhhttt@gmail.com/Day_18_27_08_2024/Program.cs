
// bai 57
bool Bai57(int n)
{
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 != 0)
        {
            return false;
        }
        n /= 10;
    }
    return true;
}

Console.WriteLine(Bai57(2468)); 

// Bai 59
bool Bai59(int n)
{
    int reversed = 0, original = n;
    while (n > 0)
    {
        reversed = reversed * 10 + n % 10;
        n /= 10;
    }
    return original == reversed;
}

Console.WriteLine(Bai59(12321));

// Bai 60
bool Bai60(int n)
{
    int previousDigit = 10;

    while (n > 0)
    {
        int currentDigit = n % 10;
        if (currentDigit >= previousDigit)
        {
            return false;
        }
        previousDigit = currentDigit;
        n /= 10;
    }

    return true;
}

Console.WriteLine(Bai60(1234));