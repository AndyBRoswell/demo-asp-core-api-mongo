using main.Models.work;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace main.Services {
    public class work_service {
        private readonly IMongoCollection<work> _work_collection;
        public work_service(IOptions<database_settings> settings) {
            var client = new MongoClient(settings.Value.connection_string);
            var database = client.GetDatabase(settings.Value.database_name);
            _work_collection = database.GetCollection<work>(settings.Value.collection_name);
        }
        public async Task<List<work>> get_async() => await _work_collection.Find(work => true).ToListAsync();
        public async Task<work> get_async(string id) => await _work_collection.Find(work => work._id == id).FirstOrDefaultAsync();
        public async Task create_async(work work) => await _work_collection.InsertOneAsync(work);
        public async Task update_async(string id, work work) => await _work_collection.ReplaceOneAsync(work => work._id == id, work);
        public async Task delete_async(string id) => await _work_collection.DeleteOneAsync(work => work._id == id);
    }
}
