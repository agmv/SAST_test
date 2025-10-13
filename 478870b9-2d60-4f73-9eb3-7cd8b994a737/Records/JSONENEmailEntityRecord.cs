using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Email
public class JSONENEmailEntityRecord : AbstractRESTStructure<ENEmailEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public int? AttrSize;

public JSONENEmailEntityRecord() { }

public JSONENEmailEntityRecord (ENEmailEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0);
  } else {
AttrId = (long?) s.ssId;
AttrSize = (int?) s.ssSize;
  }
}

public static Func<ssSystem_.RestRecords.JSONENEmailEntityRecord, ENEmailEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENEmailEntityRecord s) => ToStructure(s, config);
}
public static ENEmailEntityRecord ToStructure(ssSystem_.RestRecords.JSONENEmailEntityRecord obj, IBehaviorsConfiguration config) { 
  ENEmailEntityRecord s = new ENEmailEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSize = obj.AttrSize == null ? 0 : obj.AttrSize.Value;
  }
  return s;
}

public static Func<ENEmailEntityRecord, ssSystem_.RestRecords.JSONENEmailEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENEmailEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENEmailEntityRecord FromStructure(ENEmailEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENEmailEntityRecord(s, config);
}

}


