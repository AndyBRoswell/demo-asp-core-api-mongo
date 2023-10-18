namespace main.Models.work.audio {
    using MongoDB.Bson.Serialization.Attributes;
    public class album : @base {
        [BsonElement("ISRC")] public string? ISRC { get; set; }
        [BsonElement("label")] public List<track>? label { get; set; }
    }
}
