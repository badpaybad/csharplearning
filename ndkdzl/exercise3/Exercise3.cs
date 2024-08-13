int exercise21(int n)
{
    int total = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            total += i;
        }
    }
    return total;
}

int exercise22(int n)
{
    int total = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            total *= i;
        }
    }
    return total;
}

int exercise23(int n)
{
    int count= 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            count++;
        }
    }
    return count;
}

int exercise24(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

//void exercise25(int n)
//{
//    Console.WriteLine("Cac so le thuoc uoc cua " + n + " la: ");
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0 && i % 2 != 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

int exercise25(int n){
    int total = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 == 0)
        {
            total += i;
        }

    }
    return total;
}

int exercise26(int n)
{
    int total = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            total *= i;
        }

    }
    return total;
}

int exercise27(int n)
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

int exercise28(int n)
{
    int total = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            total += i;
        }

    }
    return total;
}

int exercise29(int n)
{
    int max = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 != 0)
        {
            max = i;
        }

    }
    return max;
}

void exercise30(int n)
{
    // số hoàn thiện
    // ví dụ: 6 , các ước số: 1 2 3 = 1 + 2 + 3 = 6 (ko tinh chinh no)
    // ví dụ: 28 , các ước số: 1 2 4 7 14 = 1 + 2 + 4 + 7 + 14 = 28 (ko tinh chinh no)
    int compare = 0;
    for (int i = 1; i < n; i++)
    {
        
        if (n % i == 0)
        {
            compare += i;
        }

    }
    
    if(compare == n)
    {
        Console.WriteLine(n + " la so hoan hao");
    }
    else
    {
        Console.WriteLine(n + " khong phai so hoan hao");
    }
}

Console.WriteLine(exercise21(12));
Console.WriteLine(exercise22(12));
Console.WriteLine(exercise23(12));
Console.WriteLine(exercise24(12));
Console.WriteLine(exercise25(12));
Console.WriteLine(exercise26(5));
Console.WriteLine(exercise27(12));
Console.WriteLine(exercise28(12));
Console.WriteLine(exercise29(100));
exercise30(28);
Console.ReadLine();