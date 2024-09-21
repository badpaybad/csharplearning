# tpcip

https://vi.wikipedia.org/wiki/TCP/IP

# http

https://vi.wikipedia.org/wiki/Hypertext_Transfer_Protocol


# client server, FE - BE

https://vi.wikipedia.org/wiki/M%C3%B4_h%C3%ACnh_kh%C3%A1ch_%E2%80%93_ch%E1%BB%A7

# CGI

https://en.wikipedia.org/wiki/Common_Gateway_Interface

# asp.net core 

https://learn.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-8.0


https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio

https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio-code#create-a-web-project


# nuget 

https://www.nuget.org/

https://nugets.airobotics.vn/

# EF 

https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli

# Guide line (chú ý học hết fundamentals) https://learn.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-8.0&tabs=linux

                1. start https://learn.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-8.0&tabs=linux
                
                2. routing https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-8.0

                3. middleware https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0

                4. DI https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0

                5. Setting (env) https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-8.0

                6. Call to other api (httpclient) https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-8.0


# Details init prj : xem prj mẫu ở folder ./session3/testapi 

cmd create api prj

                dotnet new list

                dotnet new webapi --use-controllers -o testapi
                cd testapi

all commandlines should run inside folder: testapi

cmd add nuget source: https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-nuget-add-source


                dotnet nuget add source "https://nugets.airobotics.vn/v3/index.json" --name "omt" --username "${NUGETUID}" --password "${NUGETPWD}" --store-password-in-clear-text


cmd add nuget package


                dotnet add package MongoDB.Driver
                dotnet add package Newtonsoft.Json
                dotnet add package cloud.core

cmd create controller file

                dotnet new apicontroller -n MyApiController

appsettings.json

                {

                "AdsMongoDbContext": {
                    "ConnectionString": "mongodb://your accc:your pwd@118.70.117.208:27017/your database name/?serverSelectionTimeoutMS=50000&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1"
                },
                "Logging": {
                    "LogLevel": {
                    "Default": "Information",
                    "Microsoft.AspNetCore": "Warning"
                    }
                },
                "AllowedHosts": "*"
                }


cmd create your mongodbcontext file vd mẫu:

               
cloud.core đã wrap mongodb driver thành dạng EF để dùng xem mẫu phía dưới

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


-----usage: MyApiController.cs


                using Microsoft.AspNetCore.Http;
                using Microsoft.AspNetCore.Mvc;
                using Microsoft.AspNetCore.Authorization;
                using Newtonsoft.Json;
                using System.ComponentModel;
                using System.ComponentModel.DataAnnotations.Schema;
                using cloud.core;
                using cloud.core.mongodb;
                using MongoDB.Bson;
                using MongoDB.Driver;
                using MongoDB.Driver.Linq;
                using System.Threading;
                using System.Threading.Tasks;
                using System.Collections;
                using System.Collections.Generic;
                using System.Collections.Concurrent;

                ... select

                using (var db = new AdsMongoDbContext())
                {
                    var placesData = db.AdsPlace.Where(i => i.UserOwnerId == MongoDB.Bson.ObjectId.Parse(value.userOwnerId))
                    .ToList();
                }

                ... create

                using (var db = new AdsMongoDbContext())
                {
                    var existed = db.AdsPlace.Where(i => i.PlaceName == placeName && i.UserOwnerId == userOwnerId).FirstOrDefault();
                    if (existed == null)
                    {
                        AdsPlaceEntity objs = new AdsPlaceEntity
                        {
                            PlaceName = placeName,
                            UserOwnerId = userOwnerId,
                            PlaceAddress = placeAddress,
                        };
                        if (placeId != null)
                        {
                            objs.Id = placeId.Value;
                        }

                        await db.AdsPlace.Insert(objs);
                    }
                }

                .... update partial

                using (var db = new AdsMongoDbContext())
                {
                    await db.AdsPlace.UpdatePartial(i => i.Id == placeId,
                    new Dictionary<System.Linq.Expressions.Expression<Func<AdsPlaceEntity, object>>, dynamic> { { f => f.UserOwnerId, userOwnerId }, }
                    );
                }

                .... update full object

                 using (var db = new AdsMongoDbContext())
                {
                    var existed = db.AdsPlace.Where(i => i.PlaceName == placeName && i.UserOwnerId == userOwnerId).FirstOrDefault();
                
                    existed.PlaceName=" new value";
                    ....... do somthing change your value 
                    await db.AdsPlace.Update(existed);
                }

                .... delete

                using (var db = new AdsMongoDbContext())
                {
                    await db.AdsPlace.Delete(placeId);
                }

# Cần mỗi người tự tạo git riêng hôm tới a sẽ chạy từng máy tính của ae

# Bai tap mongodb :


mỗi người tự tạo db riêng dựa vào connection string .../your database name/?...
tạo collection tên là : VersionControl có các property { Id: ObjectId, Name:String, Version: int}

                    viết api crud 
                    

# Bài tập về KỸ THUẬT TÍNH TỔNG cần làm api để đưa request có response ( tự phân tích đầu bài, đâu là input đâu là output và làm api)

                    210.Tính tổng các giá trị có chữ số đầu tiên là chữ số chẵn có trong mảng 
                    các số nguyên (tongdauchan).
                    211.Tính trung bình cộng các số nguyên tố trong mảng một chiều các số
                    nguyên (tbnguyento).
                    212.Tính trung bình cộng các số dương trong mảng một chiều các số thực 
                    (trungbinhcong).
                    213.Tính trung bình cộng các giá trị lớn hơn giá trị x trong mảng một chiều 
                    các số thực (tbclonhon).
                    214.Tính trung bình nhân các giá trị dương có trong mảng một chiều các số
                    thực (trungbinhnhan)
                   