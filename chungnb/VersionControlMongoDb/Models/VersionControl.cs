using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VersionControlAPI.Models
{
    public class VersionControl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Version")]
        public int Version { get; set; }
    }
}