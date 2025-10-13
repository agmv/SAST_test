using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinition
public class JSONENProcessDefinitionEntityRecord : AbstractRESTStructure<ENProcessDefinitionEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Key")]
[JsonPropertyName("Key")]
public string AttrKey;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Revision")]
[JsonPropertyName("Revision")]
public int? AttrRevision;

public JSONENProcessDefinitionEntityRecord() { }

public JSONENProcessDefinitionEntityRecord (ENProcessDefinitionEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, "");
AttrName = s.ssName;
AttrRevision = ConvertToRestWithoutDefaults(s.ssRevision, 0);
  } else {
AttrId = (int?) s.ssId;
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrRevision = (int?) s.ssRevision;
  }
}

public static Func<ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord, ENProcessDefinitionEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord s) => ToStructure(s, config);
}
public static ENProcessDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord obj, IBehaviorsConfiguration config) { 
  ENProcessDefinitionEntityRecord s = new ENProcessDefinitionEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRevision = obj.AttrRevision == null ? 0 : obj.AttrRevision.Value;
  }
  return s;
}

public static Func<ENProcessDefinitionEntityRecord, ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord FromStructure(ENProcessDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord(s, config);
}

}


