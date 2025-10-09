using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public class RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("Id")]
public long? ssId;
[JsonProperty("HttpMethod")]
public string ssHttpMethod;

        
    public RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86() { }

    public RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86(ST_34ce93e9f60ca0d98b2e231b96135f86Structure structure) {
        this.ssId = 
structure.ssId == 0L ? null : (long)structure.ssId;
this.ssHttpMethod = 
structure.ssHttpMethod == "" ? null : (string)structure.ssHttpMethod;

    }


    public static ST_34ce93e9f60ca0d98b2e231b96135f86Structure ToStructure(RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86 structure) {
        var result = new ST_34ce93e9f60ca0d98b2e231b96135f86Structure ();

        if (structure is null) {
           return result;
        }

        result.ssId = 
structure.ssId == null ? 0L : (long)structure.ssId;
result.ssHttpMethod = 
structure.ssHttpMethod == null ? "" : (string)structure.ssHttpMethod;


        return result;
    }

    public static RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86 FromStructure(ST_34ce93e9f60ca0d98b2e231b96135f86Structure structure) {
        return new RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86(structure)
;
    } 
}
