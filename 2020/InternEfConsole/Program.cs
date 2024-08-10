using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InternEfConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var mitomBusinessAsync = new TaskAsyncSample();
            var sw = Stopwatch.StartNew();
            var tnn = mitomBusinessAsync.NauNuoc();
            var txm = mitomBusinessAsync.XeMi();
            var txgv = mitomBusinessAsync.XeGiaVi();
            await Task.WhenAll(tnn, txm, txgv);
            sw.Stop();
            Console.WriteLine($"Async nau nuoc, xe mi + gia vi: {sw.ElapsedMilliseconds}");

            sw = Stopwatch.StartNew();
            var ttm = mitomBusinessAsync.TronMi();
            await ttm;
            await mitomBusinessAsync.An();

            sw.Stop();

            Console.WriteLine($"Async Total: {sw.ElapsedMilliseconds}");

            var mitomBusiness = new SyncSample();
            sw = Stopwatch.StartNew();            
            mitomBusiness.XeMi();
            mitomBusiness.XeGiaVi();
            mitomBusiness.TronMi();
            mitomBusiness.An();
            sw.Stop();

            Console.WriteLine($"Sycn Total: {sw.ElapsedMilliseconds}");



            Console.ReadLine();

            //    var mongodb = new TestMongoDbContext();

            //    mongodb.Abcs.Insert(new Abc
            //    {
            //        Id = new MongoDB.Bson.ObjectId(),
            //        StudentName = "Nguyen phan du"
            //    });

            //    var mongodbGuid = new TestGuidMongoDbContext();
            //    mongodbGuid.GuidAbcs.Insert(new GuidAbc
            //    {
            //        Id = Guid.NewGuid(),
            //        Fullname = "Nguyen phan du"
            //    });


            //    //https://www.tektutorialshub.com/entity-framework-core/ef-core-console-application/
            //    Console.WriteLine("Hello World!");
            //    var db = new SchoolContext();
            //    db.Add(new Student { StudentID = Guid.NewGuid().ToString(), StudentName = "Manh" });

            //    db.SaveChanges();

            //    var students = db.Students.ToList();

            //    foreach (var s in students)
            //    {
            //        Console.WriteLine($"sid: {s.StudentID} , snam: {s.StudentName}");
            //    }

            //    Console.WriteLine("Done!");
            //    Console.ReadLine();
            //}

            ////1. tao class nghiep vu cho StudentRepository, CRUD co cac hamg ( create(Student ), read( stringId) , update( Student), delete(studentId) ) dau vao la obj cua class Student

            //// 2. tao nghiep vu repo cho Lop Hoc (ClassRepository) . co cac ham : ThemHocSinhVaoLop (lopid,studentid), BoHocSinhRaKhoiLop(lopid, studentid) ,
            //// 3. LayDanhSachHocSinhTheoLop( lopid)  tra ve danh sach (array hoac list) co ten lop va ten hoc sinh 

        }
    }
}
