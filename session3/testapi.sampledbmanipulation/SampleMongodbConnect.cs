
using cloud.core;
using cloud.core.mongodb;

namespace testapi.sampledbmanipulation;

public class SampleMongodbConnect : BaseMongoObjectIdDbContext
{
    public SampleMongodbConnect() : base(AppSettingsHelper.GetValueByKey("SampleMongodbConnect:ConnectionString"))
    {

    }

    public DbSetObjectId<SampleEntity> Samples { get; set; }    

}


public class SampleEntity : AbstractEntityObjectIdTracking
{
    public string Name { get; set; } = "";
    public string Version { get; set; } = "";

    public object Settings { get; set; } = new object() { };
}