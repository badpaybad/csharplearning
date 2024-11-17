

using cloud.core;
using cloud.core.mongodb;
using MongoDB.Bson;
namespace testapi.sampledbmanipulation;
public class SampleDomain
{

    public async Task<ObjectId> Create(string name, string version)
    {
        var db = new SampleMongodbConnect();

        var obj = new SampleEntity();
        obj.Name = name;
        obj.Version = version;

        await db.Samples.Insert(obj);

        //todo: infuture should be call ApplyChange() ; and do publish event SampleCreated to other business work with it
        return obj.Id;
    }

    //todo: to do in future ObjectId id should be new SampleDomain(id).ChangeInfo( name, version) to compatible DDD 
    public async Task<bool> ChangeInfo(ObjectId id, string name, string version)
    {

        var db = new SampleMongodbConnect();

        await db.Samples.UpdatePartial(i => i.Id == id,
            new Dictionary<System.Linq.Expressions.Expression<Func<SampleEntity, object>>, object>{
                {f=>f.Name,name},
                {f=>f.Version,version},
            });


        //todo: infuture should be call ApplyChange() ; and do publish event ChangegInfo to other business work with it
        return true;
    }
    public async Task<bool> ChangeSettings(ObjectId id, object settings)
    {

        var db = new SampleMongodbConnect();

        await db.Samples.UpdatePartial(i => i.Id == id,
            new Dictionary<System.Linq.Expressions.Expression<Func<SampleEntity, object>>, object>{
                {f=>f.Settings,settings},
            });


        //todo: infuture should be call ApplyChange() ; and do publish event ChangegInfo to other business work with it
        return true;
    }

}