// See https://aka.ms/new-console-template for more information

// abstract class Test1{
//     static void Main(string[] args)
//     {
//         // Display the number of command line arguments.
//         Console.WriteLine(args[0]);
//         Console.WriteLine("Hello, World!");
//     }
// }

// Console.WriteLine(args[0]);
// Console.WriteLine("Hello, World!");

int bai1(int n)
{
    var r = 0;

    for (var i = 1; i <= n; i++)
    {
        r = r + i;
    }
    return r;
}

double bai2(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += Math.Pow(i, 2);
    }
    return r;
}

double bai3(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += (double)1 / i;
    }
    return r;
}

double bai4(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += (double)1 / (2 * i);
    }
    return r;
}

double bai5(int n)
{
    double r = 0;

    for (var i = 0; i < n; i++)
    {
        r += (double)1 / ((2 * i) + 1);
    }
    return r;
}

double bai6(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += (double)1 / (i * (i + 1));
    }
    return r;
}

double bai7(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += (double)i / (i + 1);
    }
    return r;
}

double bai8(int n)
{
    double r = 0;

    for (var i = 0; i < n; i++)
    {
        r += (double)((2 * i) + 1) / ((2 * i) + 2);
    }
    return r;
}

int bai9(int n)
{
    int r = 1;

    for (var i = 1; i <= n; i++)
    {
        r *= i;
    }
    return r;
}

double bai10(int x, int n)
{
    double r = Math.Pow(x, n);
    return r;
}


Console.WriteLine("Bai 1: " + bai1(int.Parse(args[0])));
Console.WriteLine("Bai 2: " + bai2(int.Parse(args[0])));
Console.WriteLine("Bai 3: " + bai3(int.Parse(args[0])));
Console.WriteLine("Bai 4: " + bai4(int.Parse(args[0])));
Console.WriteLine("Bai 5: " + bai5(int.Parse(args[0])));
Console.WriteLine("Bai 6: " + bai6(int.Parse(args[0])));
Console.WriteLine("Bai 7: " + bai7(int.Parse(args[0])));
Console.WriteLine("Bai 8: " + bai8(int.Parse(args[0])));
Console.WriteLine("Bai 9: " + bai9(int.Parse(args[0])));
Console.WriteLine("Bai 10: " + bai10(int.Parse(args[0]), int.Parse(args[1])));