using System.Threading.Tasks;
using System.Threading;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var counter = 0;

while (true)
{
    if (counter > 3) break;

    Console.WriteLine($"============ {counter}");

    await Log("DoSync",DoSync);
    await Log("DoAsync",DoAsync);

    counter++;
}

async Task Log(string tag, Func<Task> todo)
{
    Console.WriteLine($"------\r\n{tag} begin: {DateTime.Now}");
    var tb = DateTime.Now;
    await todo();
    var te = DateTime.Now;
    Console.WriteLine($"{tag} end: {DateTime.Now}");
    Console.WriteLine($"Elapsed: {(te - tb).TotalMilliseconds}");
}

async Task DoSync()
{
    await BocMy();
    await NauNuoc();
    await TronGiaVi();
    await An();
}

async Task DoAsync()
{
    var t1 = NauNuoc();
    var t2 = BocMy();

    var t12 = Task.WhenAll(t1, t2);

    await TronGiaVi();
    await An();
}

async Task BocMy()
{
    await Task.Delay(1000);
    Console.WriteLine("BocMy done");
}
async Task NauNuoc()
{
    await Task.Delay(5000);
    Console.WriteLine("NauNuoc done");
}
async Task TronGiaVi()
{
    await Task.Delay(2000);
    Console.WriteLine("TronGiaVi done");
}

async Task An()
{
    await Task.Delay(3000);
    Console.WriteLine("An done");
}