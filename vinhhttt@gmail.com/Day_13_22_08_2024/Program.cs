// Bai 42

int bai42(int n)
{
    int k = 0;
    int S = 0;

    while (S + k + 1 < n)
    {
        k++;
        S += k;
    }

    return k;
}

Console.WriteLine(bai42(10));

// Bai 43

static int Bai43(int n)
{
    int count = 0;

    while (n > 0)
    {
        n /= 10;
        count++;
    }

    return count;
}

Console.WriteLine(Bai43(12345));

// Bai 44


int Bai44(int n)
{
    int sum = 0;

    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }

    return sum;
}

Console.WriteLine(Bai44(12345));