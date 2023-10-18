using MongoDB.Bson.Serialization.Attributes;

namespace main.Models.work.audio {
    public class track : audio {
        [BsonElement("album")] public string? album { get; set; }
        [BsonElement("number")] public int? number { get; set; }
    }
}
