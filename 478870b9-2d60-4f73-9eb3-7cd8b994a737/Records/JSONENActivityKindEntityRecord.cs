using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityKind
public class JSONENActivityKindEntityRecord : AbstractRESTStructure<ENActivityKindEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENActivityKindEntityRecord() { }

public JSONENActivityKindEntityRecord (ENActivityKindEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssSystem_.RestRecords.JSONENActivityKindEntityRecord, ENActivityKindEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENActivityKindEntityRecord s) => ToStructure(s, config);
}
public static ENActivityKindEntityRecord ToStructure(ssSystem_.RestRecords.JSONENActivityKindEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityKindEntityRecord s = new ENActivityKindEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENActivityKindEntityRecord, ssSystem_.RestRecords.JSONENActivityKindEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityKindEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENActivityKindEntityRecord FromStructure(ENActivityKindEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENActivityKindEntityRecord(s, config);
}

}


