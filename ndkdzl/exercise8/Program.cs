double exercise71(int x, int n)
{
    double total = 0;
    int seperate = 0;
    for (int i = 1; i <= n; i++)
    {
        seperate = 0;
        for(int j = 1; j <= i; j++)
        {
            seperate += j;
        }
        total += (Math.Pow(-1, i)) * (Math.Pow(x, i) / seperate);
    }

    return total;
}

double exercise72(int x, int n)
{
    double total = 0;
    int seperate = 0;
    for (int i = 1; i <= n; i++)
    {
        seperate = 1;
        for (int j = 1; j <= i; j++)
        {
            seperate *= j;
        }
        total += (Math.Pow(-1, i)) * (Math.Pow(x, i) / seperate);
    }

    return total;
}

double exercise73(int x, int n)
{
    double total = 0;
    for (int i = 0
        ; i <= n; i++)
    {
        int seperate = 1;
        for (int j = 1; j <= 2*i; j++)  
        {
            seperate *= j;
        }
        total += (Math.Pow(-1, i+1)) * (Math.Pow(x, 2*i) / seperate);
    }

    return total;
}

double exercise74(int x, int n)
{
    double total = 1;
    for (int i = 0
        ; i <= n; i++)
    {
        int seperate = 1;
        for (int j = 1; j <= (2 * i) + 1; j++)
        {
            seperate *= j;
        }
        total += (Math.Pow(-1, i + 1)) * (Math.Pow(x, (2 * i)+1) / seperate);
    }

    return total;
}

//exercise 75 (pending)
//exercise 76 (pending)

int exercise77(int n)
{
    int total = 0;
    if(n > 0)
    {
        for (int i = 1; i <= n; ++i) {
            total += i;
        }

        return total;
    }

    return 0;
}

int[] exercise78(int n)
{
    List<int> ucln = new List<int>();
    if (n > 0)
    {
        for (int i = 1; i <= n; ++i)
        {
            if( n % i == 0)
            {
                ucln.Add(i);
            }
        }

        return ucln.ToArray();
    }

    return new int[0];
}

void lietKeUocSo(int n)
{
    int[] uocSo = exercise78(n);

    Console.WriteLine("Cac uoc so cua " + n + " La " + string.Join(", ", uocSo));
}

int exercise79(int n)
{
    int count = 0;
    if (n > 0)
    {
        for (int i = 1; i <= n; ++i)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
    }

    return count;
}

double exercise80(int x, int n)
{
    double total = 0;
    int divide= 0;
    for(int i = 1; i <= n; i++)
    {
        divide += i;
        total += Math.Pow(x, i) / divide;
    }

    return total;
}

Console.WriteLine(exercise71(5, 2));
Console.WriteLine(exercise72(5, 2));
Console.WriteLine(exercise73(4, 2));
Console.WriteLine(exercise74(4, 1));
Console.WriteLine(exercise77(4));
//Console.WriteLine(exercise78(10));
lietKeUocSo(10);
Console.WriteLine(exercise79(10));
Console.WriteLine(exercise80(2,3));
Console.ReadLine();
