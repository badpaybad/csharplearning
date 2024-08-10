// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Mu2(int n)
{
    return n * n;
}

int SumMu2(int n)
{
    var r = 0;
    for (var i = 0; i <= n; i++)
    {
        r = Mu2(i) + r;
    }
    return r;
}
System.Diagnostics.Stopwatch sw= System.Diagnostics.Stopwatch.StartNew();
var x=SumMu2(2);
sw.Stop();
Console.WriteLine(x);

Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds}");