using MongoDB.Bson;
using System;

public class TestGuidMongoDbContext : RobotCloud.CoreMongoDb.BaseMongoDbContext
{
    public TestGuidMongoDbContext() : base("127.0.0.1", "TestAbcGuid", "sysadmin", "1234a@A")
    {
    }

	public RobotCloud.CoreMongoDb.DbSet<GuidAbc> GuidAbcs { get; set; }
}

public class GuidAbc: RobotCloud.Core.Entities.AbstractEntity
{
	public string Fullname { get; set; }
}


public class TestMongoDbContext: RobotCloud.CoreMongoDb.MNVN.BaseMongoUseObjectIdDbContext
{
	public TestMongoDbContext():base("127.0.0.1","TestAbc", "sysadmin", "1234a@A")
	{
		
	}

	public RobotCloud.CoreMongoDb.MNVN.DbSetUseObjectId<Abc> Abcs { get; set; }
}

public class Abc : RobotCloud.CoreMongoDb.MNVN.IEntityUseObjectId
{	
    public ObjectId Id { get; set; }
	public string StudentName { get; set; }
}