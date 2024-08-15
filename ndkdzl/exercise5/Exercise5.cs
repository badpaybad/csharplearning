
int exercise42(int a)
{
    int total = 0;
    int result = 0;
    if (a > 0)
    {
        for (int i = 0; i <= a; i++)
        {
            total += i;
            if (total > a)
            {
                break;
            }
            result = i;
        }

        return result;
    }
    return 0;
}

int exercise43(int n)
{
    string count = n.ToString();
    int quantity = count.Length;

    return quantity;
}

int exercise44(int n)
{
    // 120 => 1 + 2 + 0  
    int total = 0;
    while (n > 0)
    {
        total += n % 10;  
        n /= 10;        
    }

    return total;
}

int exercise45(int n)
{
    // 120 => 1 + 2 + 0  
    int total = 1;
    while (n > 0)
    {
        total *= n % 10;
        n /= 10;
    }

    return total;
}

int exercise46(int n)
{
    // 120 => 1 + 2 + 0  
    int count= 0;
    while (n > 0)
    {
        int unit = n % 10;
        if(unit % 2 != 0)
        {
            count++;
        }
        n /= 10;
    }

    return count;
}

int exercise47(int n)
{
    // 120 => 1 + 2 + 0  
    int count = 0;
    while (n > 0)
    {
        int unit = n % 10;
        if (unit % 2 == 0)
        {
            count++;
        }
        n /= 10;
    }

    return count;
}

int exercise48(int n)
{
    // 120 => 1 + 2 + 0  
    int total = 1;
    while (n > 0)
    {
        int unit = n % 10;
        if (unit % 2 != 0)
        {
           total *= unit;
        }
        n /= 10;
    }

    return total;
}

int exercise49(int n)
{
    // 120 => 1 + 2 + 0  
    return n % 10;
}

int exercise50(int n)
{
    // 120 => 1 + 2 + 0  
    int total = 0;
    while (n > 0)
    {
        total += (n % 10);
        n /= 10;
        if(n > 0)
        {
            total *= 10;
        }
    }

    return total;
}

Console.WriteLine(exercise42(12));
Console.WriteLine(exercise43(102));
Console.WriteLine(exercise44(122));
Console.WriteLine(exercise45(120));
Console.WriteLine(exercise46(12345));
Console.WriteLine(exercise47(12345));
Console.WriteLine(exercise48(12345));
Console.WriteLine(exercise49(24258));
Console.WriteLine(exercise50(24258));
Console.ReadLine();
