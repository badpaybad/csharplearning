
using EntityFrameWorkJoin.MongoModels;
using System;
using MongoDB.Driver;
using MongoDB.Bson;
using EntityFrameWorkJoin.MongoStringTest;

namespace EntityFrameWorkJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository a = new StudentRepository();
            //a.Create("thiện1");
            // a.Read(Guid.Parse("76265929-58b2-41ea-ab96-28c807e93935"));
            //a.Update((Guid.Parse("76265929-58b2-41ea-ab96-28c807e93935")),"thiendemo2");
            //a.DeleteStudent(Guid.Parse("76265929-58b2-41ea-ab96-28c807e93935"));
            a.Read(Guid.Parse("76265929-58b2-41ea-ab96-28c807e93935"));

            
        }
    }
}
