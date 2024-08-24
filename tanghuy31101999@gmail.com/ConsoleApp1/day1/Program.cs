
int bai1(int n)
{
    int sum = 0;
    if (n == 0)
    {
        return sum;
    }
    sum = n * (n + 1) / 2;
    return sum;
}

Console.WriteLine($"bai tap 1: {bai1(6)}");

int bai2(int n)
{
    int sum = 0;
    if (n == 0)
    {
        return sum;
    }
    sum = n * (n + 1) * (2 * n + 1) / 6;
    return sum;
}

Console.WriteLine($"bai tap 2: {bai2(6)}");

double bai3(double n)
{
    double sum = 1;
    if (n == 0){
        return sum;
    }
    for (double i = 1; i <= n; i++)
    {
        sum += 1 / i;
    }
    return sum;
}

Console.WriteLine($"bai tap 3: {bai3(6)}");


double bai4(double n)
{
    double sum = 1;
    if (n == 0)
    {
        return sum/2;
    }
    
    for (double i = 1; i <= n; i++)
    {
        sum += 1 / (i * 2);
    }
    return sum;
}

Console.WriteLine($"bai tap 4: {bai4(6)}");

double bai5(double n)
{
    double sum = 1;
    if (n == 0)
    {
        return sum;
    }
    for (double i = 1; i <= n; i++)
       {
            sum += 1 / (i * 2 + 1);
        }
    return sum;
}

Console.WriteLine($"bai tap 5: {bai5(6)}");


double bai6(double n)
{
    double sum = 0;
    if (n == 0)
    {
        return sum;
    }
    for (double i = 1; i <= n; i++)
    {
        sum += 1 / (i * (i + 1));
    }
    return sum;
}

Console.WriteLine($"bai tap 6: {bai6(6)}");