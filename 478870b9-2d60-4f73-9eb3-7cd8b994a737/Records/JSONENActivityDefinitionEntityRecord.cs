using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinition
public class JSONENActivityDefinitionEntityRecord : AbstractRESTStructure<ENActivityDefinitionEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Key")]
[JsonPropertyName("Key")]
public string AttrKey;

[JsonProperty("ProcessDefinitionId")]
[JsonPropertyName("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Kind")]
[JsonPropertyName("Kind")]
public long? AttrKind;

public JSONENActivityDefinitionEntityRecord() { }

public JSONENActivityDefinitionEntityRecord (ENActivityDefinitionEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, "");
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrKind = (long?) s.ssKind;
  } else {
AttrId = (int?) s.ssId;
AttrKey = s.ssKey;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrName = s.ssName;
AttrKind = (long?) s.ssKind;
  }
}

public static Func<ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord, ENActivityDefinitionEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord s) => ToStructure(s, config);
}
public static ENActivityDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityDefinitionEntityRecord s = new ENActivityDefinitionEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssKind = obj.AttrKind == null ? 0L : obj.AttrKind.Value;
  }
  return s;
}

public static Func<ENActivityDefinitionEntityRecord, ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord FromStructure(ENActivityDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord(s, config);
}

}


