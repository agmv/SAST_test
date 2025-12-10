using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public class RestConsumeStructure_Employee2_c6c92e08cc1756053230783f07370fc0 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("id")]
public string ssid;
[JsonProperty("name")]
public string ssname;
[JsonProperty("color")]
public string? sscolor;

        
    public RestConsumeStructure_Employee2_c6c92e08cc1756053230783f07370fc0() { }

    public RestConsumeStructure_Employee2_c6c92e08cc1756053230783f07370fc0(ST_c6c92e08cc1756053230783f07370fc0Structure structure) {
        this.ssid = 
structure.ssid == "" ? null : (string)structure.ssid;
this.ssname = 
structure.ssname == "" ? null : (string)structure.ssname;
this.sscolor = 
structure.sscolor == (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue ? null : (string)structure.sscolor;

    }


    public static ST_c6c92e08cc1756053230783f07370fc0Structure ToStructure(RestConsumeStructure_Employee2_c6c92e08cc1756053230783f07370fc0 structure) {
        var result = new ST_c6c92e08cc1756053230783f07370fc0Structure ();

        if (structure is null) {
           return result;
        }

        result.ssid = 
structure.ssid == null ? "" : (string)structure.ssid;
result.ssname = 
structure.ssname == null ? "" : (string)structure.ssname;
result.sscolor = 
structure.sscolor == null ? (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue : (string)structure.sscolor;


        return result;
    }

    public static RestConsumeStructure_Employee2_c6c92e08cc1756053230783f07370fc0 FromStructure(ST_c6c92e08cc1756053230783f07370fc0Structure structure) {
        return new RestConsumeStructure_Employee2_c6c92e08cc1756053230783f07370fc0(structure)
;
    } 
}
