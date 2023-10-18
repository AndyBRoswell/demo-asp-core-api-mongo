using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace main.Models.work.audio {
    public class audio: work {
        [BsonElement("artist")] public string? artist { get; set; }
        [BsonElement("songwriter")] public string? songwriter { get; set; }
        [BsonElement("performer")] public string? performer { get; set; }
        [BsonElement("lyricist")] public string? lyricist { get; set; }
        [BsonElement("composer")] public string? composer { get; set; }
        [BsonElement("arranger")] public string? arranger { get; set; }
        [BsonElement("conductor")] public string? conductor { get; set; }
        [BsonElement("orchestra")] public string? orchestra { get; set; }
        [BsonElement("studio")] public string? studio { get; set; }
        [BsonElement("duration")] public string? duration { get; set; }
        [BsonElement("channel")] public int? channel { get; set; }
        [BsonElement("bit_depth")] public int? bit_depth { get; set; }
        [BsonElement("sample_rate")] public int? sample_rate { get; set; }
    }
}
