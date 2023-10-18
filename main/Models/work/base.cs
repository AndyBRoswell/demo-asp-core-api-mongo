namespace main.Models.work {
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class @base {
        [BsonId][BsonRepresentation(BsonType.ObjectId)] public string? _id { get; set; }
        [BsonElement("title")] public string? title { get; set; }
        [BsonElement("genre")] public string? genre { get; set; }
        [BsonRepresentation(BsonType.DateTime)][BsonElement("date")] public DateTime? date { get; set; }
        [BsonElement("language")] public string? language { get; set; }
        [BsonElement("country")] public string? region { get; set; }
        [BsonElement("publisher")] public string? publisher { get; set; }
        [BsonElement("distributor")] public string? distributor { get; set; }
        [BsonElement("medium")] public string? medium { get; set; }
        [BsonElement("URL")] public string? URL { get; set; }
        [BsonElement("DOI")] public string? DOI { get; set; }
        [BsonElement("description")] public string? description { get; set; }
        [BsonElement("tag")] public List<string>? tag { get; set; }
    }
}
