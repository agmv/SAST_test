using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public class RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("Id")]
public string ssId;

        
    public RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979() { }

    public RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979(ST_00ba72a41660161c6373af90c87d0979Structure structure) {
        this.ssId = 
structure.ssId == "" ? null : (string)structure.ssId;

    }


    public static ST_00ba72a41660161c6373af90c87d0979Structure ToStructure(RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979 structure) {
        var result = new ST_00ba72a41660161c6373af90c87d0979Structure ();

        if (structure is null) {
           return result;
        }

        result.ssId = 
structure.ssId == null ? "" : (string)structure.ssId;


        return result;
    }

    public static RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979 FromStructure(ST_00ba72a41660161c6373af90c87d0979Structure structure) {
        return new RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979(structure)
;
    } 
}
