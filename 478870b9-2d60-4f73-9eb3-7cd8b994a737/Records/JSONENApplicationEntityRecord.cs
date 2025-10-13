using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Application
public class JSONENApplicationEntityRecord : AbstractRESTStructure<ENApplicationEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

public JSONENApplicationEntityRecord() { }

public JSONENApplicationEntityRecord (ENApplicationEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrName = s.ssName;
AttrType = ConvertToRestWithoutDefaults(s.ssType, "");
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
AttrType = s.ssType;
  }
}

public static Func<ssSystem_.RestRecords.JSONENApplicationEntityRecord, ENApplicationEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENApplicationEntityRecord s) => ToStructure(s, config);
}
public static ENApplicationEntityRecord ToStructure(ssSystem_.RestRecords.JSONENApplicationEntityRecord obj, IBehaviorsConfiguration config) { 
  ENApplicationEntityRecord s = new ENApplicationEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<ENApplicationEntityRecord, ssSystem_.RestRecords.JSONENApplicationEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENApplicationEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENApplicationEntityRecord FromStructure(ENApplicationEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENApplicationEntityRecord(s, config);
}

}


