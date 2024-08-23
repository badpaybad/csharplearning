// bai 28

int Bai28(int n)
{
    int sum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    return sum;
}

Console.WriteLine(Bai28(10)); 

// Bai 29

int Bai29(int n)
{
    int maxOddDivisor = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            maxOddDivisor = i;
        }
    }
    return maxOddDivisor;
}

Console.WriteLine(Bai29(100)); 


// Bai 30

int Bai30(int n)
{
    int sum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    return sum == n ? 1 : 0;
}

Console.WriteLine(Bai30(28)); 
