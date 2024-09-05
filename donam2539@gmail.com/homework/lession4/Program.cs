static int bai43(int n)
{
    return n.ToString().Length;
}

static int bai44(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }

    return sum;
}

static int bai45(int n)
{
    int result = 1;

    while (n != 0)
    {
        result *= n % 10;
        n /= 10;
    }

    return result;
}

static int bai46(int n)
{
    int result = 0;

    while (n != 0)
    {
        int digit = n % 10;

        if (digit % 2 != 0)
        {
            result++;
        }

        n /= 10;
    }

    return result;
}

static int bai47(int n)
{
    int sum = 0;

    while (n != 0)
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

static int bai48(int n)
{
    int result = 1;
    bool hasOddDigits = false;

    while (n != 0)
    {
        int digit = n % 10;

        if (digit % 2 != 0)
        {
            result *= digit;
            hasOddDigits = true;
        }

        n /= 10;
    }

    return hasOddDigits ? result : 0;
}

static int bai49(int n)
{
    while (n >= 10)
    {
        n /= 10;
    }
    return n;
}

static int bai50(int n)
{
    int reversed = 0;

    while (n != 0)
    {
        int digit = n % 10;
        reversed = reversed * 10 + digit;
        n /= 10;
    }

    return reversed;
}

static int bai51(int n)
{
    int maxDigit = 0;

    while (n != 0)
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

static int bai52(int n)
{
    int minDigit = 9;

    while (n != 0)
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


static int bai53(int n)
{
    int maxDigit = 0;
    int maxDigitCount = 0;

    int temp = n;
    while (temp != 0)
    {
        int digit = temp % 10;
        if (digit > maxDigit)
        {
            maxDigit = digit;
        }
        temp /= 10;
    }

    temp = n;
    while (temp != 0)
    {
        int digit = temp % 10;
        if (digit == maxDigit)
        {
            maxDigitCount++;
        }
        temp /= 10;
    }

    return maxDigitCount;
}

static int bai54(int n)
{
    int minDigit = 9;
    int minDigitCount = 0;

    int temp = n;
    while (temp != 0)
    {
        int digit = temp % 10;
        if (digit < minDigit)
        {
            minDigit = digit;
        }
        temp /= 10;
    }

    temp = n;
    while (temp != 0)
    {
        int digit = temp % 10;
        if (digit == minDigit)
        {
            minDigitCount++;
        }
        temp /= 10;
    }

    return minDigitCount;
}

static int bai55(int n)
{
    int firstDigit = n;
    while (firstDigit >= 10)
    {
        firstDigit /= 10;
    }

    int count = 0;
    int length = n.ToString().Length;

    for (int i = 0; i < length; i++)
    {
        int digit = n % 10;
        n /= 10;

        if (digit == firstDigit)
        {
            count++;
        }
    }
    return count;

}

static bool bai56(int n)
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


Console.WriteLine("Bai 43: " + bai43(int.Parse(args[0])));
Console.WriteLine("Bai 44: " + bai44(int.Parse(args[0])));
Console.WriteLine("Bai 45: " + bai45(int.Parse(args[0])));
Console.WriteLine("Bai 46: " + bai46(int.Parse(args[0])));
Console.WriteLine("Bai 47: " + bai47(int.Parse(args[0])));
Console.WriteLine("Bai 48: " + bai48(int.Parse(args[0])));
Console.WriteLine("Bai 49: " + bai49(int.Parse(args[0])));
Console.WriteLine("Bai 50: " + bai50(int.Parse(args[0])));
Console.WriteLine("Bai 51: " + bai51(int.Parse(args[0])));
Console.WriteLine("Bai 52: " + bai52(int.Parse(args[0])));
Console.WriteLine("Bai 53: " + bai53(int.Parse(args[0])));
Console.WriteLine("Bai 54: " + bai54(int.Parse(args[0])));
Console.WriteLine("Bai 55: " + bai55(int.Parse(args[0])));
Console.WriteLine("Bai 56: " + bai56(int.Parse(args[0])));
