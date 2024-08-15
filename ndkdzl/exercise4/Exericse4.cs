void exercise31(int n)
{
    bool flag = true;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            flag = false;
        }
    }

    if (flag && n > 1)
    {
        Console.WriteLine(n + " la so nguyen to");
    }
    else
    {
        Console.WriteLine(n + " khong la so nguyen to");
    }
}

void exercise32(int n)
{
    bool flag = false;
    for (int i = 0; i <= n; i++)
    {
        if (Math.Sqrt(n) == i)
        {
            flag = true;
        }
    }

    if (flag)
    {
        Console.WriteLine(n + " la so chinh phuong");
    }
    else
    {
        Console.WriteLine(n + " khong la so chinh phuong");
    }
}

double exercise33(int n)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        total = Math.Sqrt(2 + total);
    }
    return total;
}

double exercise34(int n)
{
    double total = 0;
    for (int i = 0; i < n; i++)
    {
        total = Math.Sqrt(n - i);
    }
    if(n > 1)
    {
        total += Math.Sqrt(n);
    }
    return total;
}

double exercise35(int n)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        total = Math.Sqrt((n - i) + Math.Sqrt(n));
    }
    return total;
}

long tinhGiaiThua(int n)
{
    if(n > 1)
    {
        int total = 1;
        for (int i = 1; i <= n; i++)
        {
            total *= i;
        }

        return total;
    }
 
    return 1;
}

double exercise36(int n)
{
    double total = 0;
    if(n > 1)
    {
        for (int i = 0; i < n; i++)
        {
            total = Math.Sqrt(tinhGiaiThua(n) + Math.Sqrt(tinhGiaiThua(n - i)));
        }
        return total;

    }

    return n;
}

double exercise37(int n)
{
    double total = 0;
    if(n > 1)
    {
        for (int i = 0; i < n; i++)
        {
            total = Math.Pow(n + (Math.Pow(n-1 + Math.Pow(3 + Math.Sqrt(2), 1.0/3), 1.0/n-1)), 1.0/n) ;
        }
        return total;
    }
    return n;
}

// failed
//double exercise38(int n)
//{
//    double total = 0;
//    if (n > 1)
//    {
//        for (int i = 0; i < n; i++)
//        {
//            total = Math.Pow(n + (Math.Pow(n - 1 + Math.Pow(2 + Math.Sqrt(1), 1.0 / 3), 1.0 / n)), 1.0 / n+1);
//        }
//        return total;
//    }
//    return n;
//}



exercise31(4);
exercise32(226);
Console.WriteLine(exercise33(2));
Console.WriteLine(exercise34(3));
Console.WriteLine(exercise35(2));
Console.WriteLine(exercise36(4));
Console.WriteLine(exercise37(2));
//Console.WriteLine(exercise38(2));
Console.ReadLine();

// pending: 39, 40, 41 (không có casio check)