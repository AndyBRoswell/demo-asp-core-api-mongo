using MongoDB.Bson.Serialization.Attributes;

namespace main.Models.work.video {
    public class @base {
        [BsonElement("director")] public string? director { get; set; }
        [BsonElement("performer")] public string? performer { get; set; }
        [BsonElement("writer")] public string? writer { get; set; }
        [BsonElement("producer")] public string? producer { get; set; }
        [BsonElement("production_company")] public string? production_company { get; set; }
    }
}
