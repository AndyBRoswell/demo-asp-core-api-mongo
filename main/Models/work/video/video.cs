using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace main.Models.work.video {
    public class video : work {
        [BsonElement("director")] public string? director { get; set; }
        [BsonElement("second_unit_or_assistant_director")] public string? second_unit_or_assistant_director { get; set; }
        [BsonElement("writer")] public string? writer { get; set; }
        [BsonElement("script_and_continuity")] public string? script_and_continuity { get; set; }
        [BsonElement("cast")] public string? cast { get; set; }
        [BsonElement("casting_department")] public string? casting_department { get; set; }
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
        [BsonElement("camera_department")] public string? camera_department { get; set; }
        [BsonElement("electrical")] public string? electrical { get; set; }
        [BsonElement("location_management")] public string? location_management { get; set; }
        [BsonElement("transportation")] public string? transportation { get; set; }
        [BsonElement("additional_crew")] public string? additional_crew { get; set; }
        [BsonElement("thanks")] public string? thanks { get; set; }
        [BsonElement("duration")] public string? duration { get; set; }
        [BsonElement("aspect_ratio")] public List<string>? aspect_ratio { get; set; }
        [BsonElement("resolution")] public string? resolution { get; set; }
        [BsonElement("frame_rate")] public string? frame_rate { get; set; }
        [BsonElement("color")] public string? color { get; set; }
        [BsonElement("sound_mix")] public List<string>? sound_mix { get; set; }
        [BsonElement("camera")] public List<string>? camera { get; set; }
        [BsonElement("laboratory")] public List<string>? laboratory { get; set; }
        [BsonElement("negative_format")] public List<string>? negative_format { get; set; }
        [BsonElement("film_length")] public string? film_length { get; set; }
        [BsonElement("cinematographic_process")] public Dictionary<string, string>? cinematographic_process { get; set; }
        [BsonElement("printed_film_format")] public List<string>? printed_film_format { get; set; }
    }
}
