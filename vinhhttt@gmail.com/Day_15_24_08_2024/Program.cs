// bai 48

int Bai48(int n)
{
    int product = 1;
    bool hasOdd = false;

    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 != 0)
        {
            product *= digit;
            hasOdd = true;
        }
        n /= 10;
    }

    return hasOdd ? product : 0;
}

Console.WriteLine(Bai48(12345));

// bai 49
int Bai49(int n)
{
    while (n >= 10)
    {
        n /= 10;
    }
    return n;
}

Console.WriteLine(Bai49(12345));

// bai 50

int Bai50(int n)
{
    int reversed = 0;

    while (n > 0)
    {
        reversed = reversed * 10 + n % 10;
        n /= 10;
    }

    return reversed;
}

Console.WriteLine(Bai50(12345)); 




