using MongoDB.Bson.Serialization.Attributes;

namespace main.Models.work.audio {
    public class track : @base {
        [BsonElement("album")] public string? album { get; set; }
        [BsonElement("number")] public int? number { get; set; }
    }
}
