using AuthSample.Dal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSample
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using(var db = new AuthDbContext())
            {
                var existed = db.Users.Where(i => i.Username == "admin").FirstOrDefault();

                if (existed == null)
                {
                    existed = new User
                    {
                        UserId = Guid.NewGuid(),
                        Username = "admin",
                        Password = "123456"
                    };
                    db.Users.Insert(existed);

                    // db.UserAcls.Insert(new UserAcl { });
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
