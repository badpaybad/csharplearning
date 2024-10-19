using System.Threading.Tasks;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var counter = 0;

while (true)
{
    if (counter > 3) break;

    Console.WriteLine($"============ {counter}");

    await Log("DoSync", DoSync);
    await Log("DoAsync", DoAsync);

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
    var my = await BocMy();
    var nc = await NauNuoc();
    await TronGiaVi((long)my,(string) nc);
    await An();
}

async Task DoAsync()
{
    var t1 = NauNuoc();
    var t2 = BocMy();

    var res = await Task.WhenAll(t1, t2);

    await TronGiaVi((long)res[1], (string)res[0]);
    await An();
}

async Task<object> BocMy()
{
    await Task.Delay(3000);
    Console.WriteLine("BocMy done");
    return DateTime.Now.Ticks;
}
async Task<object> NauNuoc()
{
    try
    {
        await Task.Delay(5000);
        Console.WriteLine("NauNuoc done");
        return "ok naunuoc " + DateTime.Now;
    }
    catch
    {
        return "";
    }
}
async Task TronGiaVi(long my, string nuoc)
{
    await Task.Delay(2000);
    Console.WriteLine($"TronGiaVi done {my} {nuoc}");
}

async Task An()
{
    await Task.Delay(3000);
    Console.WriteLine("An done");

    var db =new AdsMongoDbContext();

}

  /// class này là tương đương 1 database
            public class AdsMongoDbContext : BaseMongoObjectIdDbContext
            {
                public AdsMongoDbContext() : base(AppSettingsHelper.GetValueByKey("AdsMongoDbContext:ConnectionString"))
                {

                }

                /// tương đương 1 collection
                public DbSetObjectId<AdsPlaceEntity> AdsPlace { get; set; }

            }


            public class AdsPlaceEntity : AbstractEntityObjectIdTracking
            {
                public MongoDB.Bson.ObjectId UserOwnerId { get; set; }
                public string PlaceName { get; set; }
                public string PlaceAddress { get; set; }

                public long LastUpdated{get;set;}
            }