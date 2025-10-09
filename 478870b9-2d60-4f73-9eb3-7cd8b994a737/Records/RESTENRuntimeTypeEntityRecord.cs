using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// RuntimeType
public class RESTENRuntimeTypeEntityRecord : AbstractRESTStructure<ENRuntimeTypeEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

public RESTENRuntimeTypeEntityRecord() { }

public RESTENRuntimeTypeEntityRecord (ENRuntimeTypeEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENRuntimeTypeEntityRecord ToStructure(ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord obj) { 
  ENRuntimeTypeEntityRecord s = new ENRuntimeTypeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<ENRuntimeTypeEntityRecord, ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENRuntimeTypeEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord FromStructure(ENRuntimeTypeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord(s, config);
}

}


