using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public class RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("Name")]
public string ssName;
[JsonProperty("Value")]
public string ssValue;

        
    public RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e() { }

    public RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e(ST_b6163e36a4b633b09c820fee73ba221eStructure structure) {
        this.ssName = 
structure.ssName == "" ? null : (string)structure.ssName;
this.ssValue = 
structure.ssValue == "" ? null : (string)structure.ssValue;

    }


    public static ST_b6163e36a4b633b09c820fee73ba221eStructure ToStructure(RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e structure) {
        var result = new ST_b6163e36a4b633b09c820fee73ba221eStructure ();

        if (structure is null) {
           return result;
        }

        result.ssName = 
structure.ssName == null ? "" : (string)structure.ssName;
result.ssValue = 
structure.ssValue == null ? "" : (string)structure.ssValue;


        return result;
    }

    public static RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e FromStructure(ST_b6163e36a4b633b09c820fee73ba221eStructure structure) {
        return new RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e(structure)
;
    } 
}
