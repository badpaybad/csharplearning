using System;
using System.Linq;

namespace InternEfConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var mongodb = new TestMongoDbContext();

            mongodb.Abcs.Insert(new Abc { Id = new MongoDB.Bson.ObjectId(),
            StudentName="Nguyen phan du"});

            //https://www.tektutorialshub.com/entity-framework-core/ef-core-console-application/
            Console.WriteLine("Hello World!");
            var db = new SchoolContext();
            db.Add(new Student { StudentID = Guid.NewGuid().ToString(), StudentName = "Manh" });
            
            db.SaveChanges();

            var students = db.Students.ToList();

            foreach(var s in students)
            {
                Console.WriteLine($"sid: {s.StudentID} , snam: {s.StudentName}");
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        //1. tao class nghiep vu cho StudentRepository, CRUD co cac hamg ( create(Student ), read( stringId) , update( Student), delete(studentId) ) dau vao la obj cua class Student

        // 2. tao nghiep vu repo cho Lop Hoc (ClassRepository) . co cac ham : ThemHocSinhVaoLop (lopid,studentid), BoHocSinhRaKhoiLop(lopid, studentid) ,
        // 3. LayDanhSachHocSinhTheoLop( lopid)  tra ve danh sach (array hoac list) co ten lop va ten hoc sinh 
        
    }
}
