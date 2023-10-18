using MongoDB.Bson.Serialization.Attributes;

namespace main.Models.work.video {
    public class @base {
        [BsonElement("director")] public string? director { get; set; }
        [BsonElement("second_unit_or_assistant_director")] public string? second_unit_or_assistant_director { get; set; }
        [BsonElement("writer")] public string? writer { get; set; }
        [BsonElement("script_and_continuity")] public string? script_and_continuity { get; set; }
        [BsonElement("cast")] public string? cast { get; set; }
        [BsonElement("producer")] public string? producer { get; set; }
        [BsonElement("production_design")] public string? production_design { get; set; }
        [BsonElement("production_management")] public string? production_management { get; set; }
        [BsonElement("set_decoration")] public string? set_decoration { get; set; }
        [BsonElement("music")] public string? music { get; set; }
        [BsonElement("music_department")] public string? music_department { get; set; }
        [BsonElement("cinematographer")] public string? cinematographer { get; set; }
        [BsonElement("editor")] public string? editor { get; set; }
        [BsonElement("editorial_department")] public string? editorial_department { get; set; }
        [BsonElement("studio")] public string? studio { get; set; }
        [BsonElement("art_director")] public string? art_director { get; set; }
        [BsonElement("art_department")] public string? art_department { get; set; }
        [BsonElement("sound")] public string? sound { get; set; }
        [BsonElement("visual_effect")] public string? visual_effect { get; set; }
        [BsonElement("special_effect")] public string? special_effect { get; set; }
        [BsonElement("costume")] public string? costume { get; set; }
        [BsonElement("makeup")] public string? makeup { get; set; }
        [BsonElement("stunt")] public string? stunt { get; set; }
        [BsonElement("animation")] public string? animation { get; set; }
        [BsonElement("camera")] public string? camera { get; set; }
        [BsonElement("electrical")] public string? electrical { get; set; }
        [BsonElement("location_management")] public string? location_management { get; set; }
        [BsonElement("transportation")] public string? transportation { get; set; }
        [BsonElement("additional_crew")] public string? additional_crew { get; set; }
        [BsonElement("thanks")] public string? thanks { get; set; }
    }
}
