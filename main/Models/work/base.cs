namespace main.Models.work {
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class @base {
        [BsonId][BsonRepresentation(BsonType.ObjectId)] public string? _id { get; set; }
        [BsonElement("title")] public string? title { get; set; }
        [BsonElement("genre")] public string? genre { get; set; }
        [BsonRepresentation(BsonType.DateTime)][BsonElement("date")] public DateTime? date { get; set; }
        [BsonElement("language")] public string? language { get; set; }
        [BsonElement("publisher")] public string? publisher { get; set; }
    }
}
