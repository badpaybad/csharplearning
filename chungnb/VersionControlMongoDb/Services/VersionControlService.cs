using MongoDB.Driver;
using VersionControlAPI.Models;

namespace VersionControlAPI.Services
{
    public class VersionControlService
    {
        private readonly IMongoCollection<VersionControl> _versionControlCollection;

        public VersionControlService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("version-control-db");
            _versionControlCollection = database.GetCollection<VersionControl>("VersionControl");
        }

        public async Task<List<VersionControl>> GetAsync() =>
            await _versionControlCollection.Find(_ => true).ToListAsync();

        public async Task<VersionControl?> GetByIdAsync(string id) =>
            await _versionControlCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(VersionControl versionControl) =>
            await _versionControlCollection.InsertOneAsync(versionControl);

        public async Task UpdateAsync(string id, VersionControl updatedVersionControl) =>
            await _versionControlCollection.ReplaceOneAsync(x => x.Id == id, updatedVersionControl);

        public async Task RemoveAsync(string id) =>
            await _versionControlCollection.DeleteOneAsync(x => x.Id == id);
    }
}