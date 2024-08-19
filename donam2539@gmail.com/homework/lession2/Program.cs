List<int> bai20(int n)
{
    List<int> result = [];
    for (int i = 1; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            result.Add(i);
            if (i != n / i) // Tránh thêm n/i nếu i == căn bậc hai của n
            {
                result.Add(n / i);
            }
        }
    }
    result.Sort();
    return result;
}

int bai21(int n)
{
    List<int> uocso = bai20(n);
    int result = 0;
    for (int i = 0; i < uocso.Count; i++)
    {
        result += uocso[i];
    }

    return result;
}

int bai22(int n)
{
    List<int> uocso = bai20(n);
    int result = 1;
    for (int i = 0; i < uocso.Count; i++)
    {
        result *= uocso[i];
    }

    return result;
}


int bai23(int n)
{
    List<int> uocso = bai20(n);
    return uocso.Count;
}


List<int> bai24(int n)
{
    List<int> uocso = bai20(n);
    List<int> result = [];
    for (int i = 0; i < uocso.Count; i++)
    {
        if (uocso[i] % 2 != 0)
        {
            result.Add(uocso[i]);
        }
    }

    return result;
}


int bai25(int n)
{
    List<int> uocso = bai20(n);
    int result = 0;
    for (int i = 0; i < uocso.Count; i++)
    {
        if (uocso[i] % 2 == 0)
        {
            result += uocso[i];
        }
    }

    return result;
}

int bai26(int n)
{
    List<int> uocso = bai20(n);
    int result = 1;
    for (int i = 0; i < uocso.Count; i++)
    {
        if (uocso[i] % 2 != 0)
        {
            result *= uocso[i];
        }
    }

    return result;
}

int bai27(int n)
{
    List<int> uocso = bai20(n);
    List<int> result = [];
    for (int i = 0; i < uocso.Count; i++)
    {
        if (uocso[i] % 2 == 0)
        {
            result.Add(uocso[i]);
        }
    }

    return result.Count;
}

int bai28(int n)
{
    List<int> uocso = bai20(n);
    int result = 0;
    for (int i = 0; i < uocso.Count - 1; i++)
    {
        result += uocso[i];
    }

    return result;
}

int bai29(int n)
{
    List<int> uocso = bai20(n);
    List<int> result = [];
    for (int i = 0; i < uocso.Count - 1; i++)
    {
        if (uocso[i] % 2 != 0)
        {
            result.Add(uocso[i]);
        }
    }

    return result.Max();
}

bool bai30(int n)
{
    List<int> uocso = bai20(n);
    int sum = 0;
    for (int i = 0; i < uocso.Count - 1; i++)
    {
        sum += uocso[i];
    }

    return sum == n;
}

bool bai31(int n)
{
    bool isPrime = true;
    if (n <= 1 || (n > 2 && n % 2 == 0))
    {
        isPrime = false;
    }
    else
    {
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    return isPrime;
}

bool bai32(int n)
{
    double sqrt = Math.Sqrt(n);
    return (sqrt % 1 == 0);
}


Console.WriteLine("Bai 20: " + string.Join(", ", bai20(int.Parse(args[0]))));
Console.WriteLine("Bai 21: " + bai21(int.Parse(args[0])));
Console.WriteLine("Bai 22: " + bai22(int.Parse(args[0])));
Console.WriteLine("Bai 23: " + bai23(int.Parse(args[0])));
Console.WriteLine("Bai 24: " + string.Join(", ", bai24(int.Parse(args[0]))));
Console.WriteLine("Bai 25: " + bai25(int.Parse(args[0])));
Console.WriteLine("Bai 26: " + bai26(int.Parse(args[0])));
Console.WriteLine("Bai 27: " + bai27(int.Parse(args[0])));
Console.WriteLine("Bai 28: " + bai28(int.Parse(args[0])));
Console.WriteLine("Bai 29: " + bai29(int.Parse(args[0])));
Console.WriteLine("Bai 30: " + "So " + int.Parse(args[0]) + ((bai30(int.Parse(args[0]))) ? " co" : " khong") + " la so hoan hao");
Console.WriteLine("Bai 31: " + "So " + int.Parse(args[0]) + ((bai31(int.Parse(args[0]))) ? " co" : " khong") + " la so nguyen to");
Console.WriteLine("Bai 32: " + "So " + int.Parse(args[0]) + ((bai32(int.Parse(args[0]))) ? " co" : " khong") + " la so chinh phuong");