using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// RuntimeType
public class JSONENRuntimeTypeEntityRecord : AbstractRESTStructure<ENRuntimeTypeEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

public JSONENRuntimeTypeEntityRecord() { }

public JSONENRuntimeTypeEntityRecord (ENRuntimeTypeEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIsActive = (bool?) s.ssIsActive;
  } else {
AttrId = s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIsActive = (bool?) s.ssIsActive;
  }
}

public static Func<ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord, ENRuntimeTypeEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord s) => ToStructure(s, config);
}
public static ENRuntimeTypeEntityRecord ToStructure(ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord obj, IBehaviorsConfiguration config) { 
  ENRuntimeTypeEntityRecord s = new ENRuntimeTypeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<ENRuntimeTypeEntityRecord, ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENRuntimeTypeEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord FromStructure(ENRuntimeTypeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord(s, config);
}

}


