namespace main.Models.work.audio {
    using MongoDB.Bson.Serialization.Attributes;
    public class album : audio {
        [BsonElement("ISRC")] public string? ISRC { get; set; }
        [BsonElement("label")] public List<track>? label { get; set; }
    }
}
