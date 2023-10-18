using main.Models.work;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace main.Services {
    public class work_service {
        private readonly IMongoCollection<work> _work_collection;
        public work_service(IOptions<Models.work.database_settings> settings) {
            var client = new MongoClient(settings.Value.connection_string);
            var database = client.GetDatabase(settings.Value.database_name);
            _work_collection = database.GetCollection<work>(settings.Value.collection_name);
        }
        
    }
}
