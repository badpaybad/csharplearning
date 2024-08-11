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

Console.WriteLine("Bai 1: " + bai1(int.Parse(args[0])));

double bai2(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += Math.Pow(i, 2);
    }
    return r;
}

Console.WriteLine("Bai 2: " + bai2(int.Parse(args[0])));


double bai3(int n)
{
    double r = 0;

    for (var i = 1; i <= n; i++)
    {
        r += (double)1 / i;
    }
    return r;
}


Console.WriteLine("Bai 3: " + bai3(int.Parse(args[0])));

