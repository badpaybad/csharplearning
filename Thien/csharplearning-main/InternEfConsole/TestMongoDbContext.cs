using MongoDB.Bson;
using System;

public class TestGuidMongoDbContext : RobotCloud.CoreMongoDb.BaseMongoDbContext
{
    public TestGuidMongoDbContext() : base("localhost", "TestAbc", "user", "123123")
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
	public TestMongoDbContext():base("localhost","TestAbc", "user", "123123")
	{
		
	}

	public RobotCloud.CoreMongoDb.MNVN.DbSetUseObjectId<Abc> Abcs { get; set; }
}

public class Abc : RobotCloud.CoreMongoDb.MNVN.IEntityUseObjectId
{	
    public ObjectId Id { get; set; }
	public string StudentName { get; set; }
}