
int exercise62(int a, int b)
{
    // ucln: 30 vs 48 (1,2,3,6) => ucln 6
    // c1:
    int ucln = 1;
    int conditionFor = a > b ? a : b;
    for (int i = 1; i <= conditionFor; i++)
    {
        if(a % i == 0 && b % i == 0)
        {
            ucln = i;
        }
    }

    return ucln;
}

int exercise63(int a, int b)
{
    // ucln: 30 vs 48 (1,2,3,6) => ucln 6
    // c1:
    int ucln = 1;
    int conditionFor = a > b ? a : b;
    for (int i = 2; i <= conditionFor; i++)
    {
        if (a % i == 0 && b % i == 0)
        {
            ucln = i; break;
        }
    }

    return ucln;
}

void exercise64(int a, int b)
{
    if (a == 0)
    {
        if(b == 0)
        {
            Console.WriteLine("Phuong trinh co vo so nghiem");
        }
        else
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
    else
    {
        if(b ==0)
        {
            Console.WriteLine("Phuong trinh co 1 nghiem x = 0");
        }
        else
        {
            Console.WriteLine("Phuong trinh co 1 nghiem x = " + b / (-a));
        }
    }
}

void exercise65(int a, int b, int c) { 
    if(a == 0)
    {
        exercise64(b, c);
    }
    else
    {
        double delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

        if(delta > 0)
        {
            Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1 = " + ((-b + delta) / 2) + " x2 = " + ((-b - delta) / 2));
        }else if(delta == 0)
        {
            Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + delta);
        }
        else
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
}

void exercise66(int a, int b, int c)
{
    if (a == 0)
    {
        exercise64(b, c);
    }
    else
    {
        double delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

        if (delta > 0)
        {
            Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1 = " + ((-b + delta) / (2*a*c)) + " x2 = " + ((-b - delta) / (2*a*c)));
        }
        else if (delta == 0)
        {
            Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + delta);
        }
        else
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
}

double exercise67(int x, int n){
    double total = 0;
    if (n < 1)
    {
        return n;
    }
    for (int i = 0; i <= n; i++) {
        total += (Math.Pow(-1, i + 1) * Math.Pow(x, i));
    }
    return total / 1.0;
}

double exercise68(int x, int n)
{
    double total = 0;
    if (n < 1)
    {
        return n;
    }
    for (int i = 0; i <= n; i++)
    {
        total += (Math.Pow(-1, i) * Math.Pow(x, 2*i));
    }
    return total / 1.0;
}

double exercise69(int x, int n)
{
    double total = 0;
    if (n < 1)
    {
        return n;
    }
    for (int i = 0; i <= n; i++)
    {
        total += (Math.Pow(-1, i) * Math.Pow(x, (2*i)+1));
    }
    return total / 1.0;
}

double exercise70(int x, int n)
{
    double total = 0;
    int seperate = 0;
    for (int i = 1; i <= n; i++)
    {
        seperate += i;
        total += (Math.Pow(-1, i + 1) / seperate);
    }

    return total;
}
Console.WriteLine(exercise62(18,45));
Console.WriteLine(exercise63(5,20));
exercise64(5, 20);
exercise65(3, 4, -7);
exercise66(3, 4, -7);
Console.WriteLine(exercise67(5, 3));
Console.WriteLine(exercise68(5, 1));
Console.WriteLine(exercise69(5, 1));
Console.WriteLine(exercise70(5, 1));
Console.ReadLine();
