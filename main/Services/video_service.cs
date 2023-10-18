using main.Models.work;
using main.Models.work.video;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace main.Services {
    public class video_service {
        private readonly IMongoCollection<video> _work_collection;
        public video_service(IOptions<database_settings> settings) {
            var client = new MongoClient(settings.Value.connection_string);
            var database = client.GetDatabase(settings.Value.database_name);
            _work_collection = database.GetCollection<video>(settings.Value.collection_name);
        }
        public async Task<List<video>> get_async() => await _work_collection.Find(video => true).ToListAsync();
        public async Task<video> get_async(string id) => await _work_collection.Find(video => video._id == id).FirstOrDefaultAsync();
        public async Task create_async(video video) => await _work_collection.InsertOneAsync(video);
        public async Task update_async(string id, video video_in) => await _work_collection.ReplaceOneAsync(video => video._id == id, video_in);
        public async Task delete_async(string id) => await _work_collection.DeleteOneAsync(video => video._id == id);
    }
}
