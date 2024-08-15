
int exercise51(int n)
{
    int max = 0;

    while(n > 0)
    {
        int unit = n % 10;
        if(unit > max)
        {
            max = unit;
        }

        n /= 10;
    }

    return max;
}

int exercise52(int n)
{
    int min = 9;

    while (n > 0)
    {
        int unit = n % 10;
        if (unit < min)
        {
            min= unit;
        }

        n /= 10;
    }

    return min;
}

int exercise53(int n)
{
    int max= 0;
    int b = n;
    while (n > 0)
    {
        int unit = n % 10;
        if (unit > max)
        {
            max= unit;
        }

        n /= 10;
    }
    int count = 0;
    while (b > 0)
    {
        int unit = b % 10;
        if (unit == max)
        {
            count++;
        }
        b /= 10;
    }


    return count;
}

int exercise54(int n)
{
    int min= 9;
    int b = n;
    while (n > 0)
    {
        int unit = n % 10;
        if (unit < min)
        {
            min = unit;
        }

        n /= 10;
    }
    int count = 0;
    while (b > 0)
    {
        int unit = b % 10;
        if (unit == min)
        {
            count++;
        }
        b /= 10;
    }


    return count;
}

int exercise55(int n)
{
    int firstNumber = 0;
    int count = 0;
    while (n > 0)
    {
        firstNumber = n % 10;
        break;
    }

    while(n > 0)
    {
        int unit = n % 10;
        if (unit == firstNumber) {
            count++;
        }
        n /= 10;
    }

    return count;
}

int exercise56(int n)
{
    int flag = 0; // khong phai so le
    while (n > 0)
    {
        if((n % 10)%2 == 0)
        {
            flag++; 
        }
        n /= 10;
    }


    return flag;
}

int exercise57(int n)
{
    int flag = 0; // khong phai so le
    while (n > 0)
    {
        if ((n % 10) % 2 != 0)
        {
            flag++;
        }
        n /= 10;
    }


    return flag;
}

int exercise58(int n)
{
    int flag = 0; // khong phai so le
    while (n > 0)
    {
        if ((n % 10) % 2 != 0)
        {
            flag++;
        }
        n /= 10;
    }


    return flag;
}

Console.WriteLine(exercise51(4582));
Console.WriteLine(exercise52(4582));
Console.WriteLine(exercise53(458282));
Console.WriteLine(exercise54(11121));
Console.WriteLine(exercise55(15345));
Console.WriteLine(exercise56(24526));
Console.WriteLine(exercise57(24526));
Console.WriteLine(exercise58(24526));
Console.ReadLine();
