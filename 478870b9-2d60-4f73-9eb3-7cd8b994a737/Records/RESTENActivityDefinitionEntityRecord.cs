using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinition
public class RESTENActivityDefinitionEntityRecord : AbstractRESTStructure<ENActivityDefinitionEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Kind")]
public long? AttrKind;

public RESTENActivityDefinitionEntityRecord() { }

public RESTENActivityDefinitionEntityRecord (ENActivityDefinitionEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENActivityDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord obj) { 
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

public static Func<ENActivityDefinitionEntityRecord, ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord FromStructure(ENActivityDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord(s, config);
}

}


