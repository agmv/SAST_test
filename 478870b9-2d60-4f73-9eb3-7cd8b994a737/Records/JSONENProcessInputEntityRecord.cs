using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInput
public class JSONENProcessInputEntityRecord : AbstractRESTStructure<ENProcessInputEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProcessId")]
[JsonPropertyName("ProcessId")]
public long? AttrProcessId;

[JsonProperty("InputDefinitionId")]
[JsonPropertyName("InputDefinitionId")]
public string AttrInputDefinitionId;

[JsonProperty("InputDefinitionKey")]
[JsonPropertyName("InputDefinitionKey")]
public string AttrInputDefinitionKey;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("DataType")]
[JsonPropertyName("DataType")]
public string AttrDataType;

[JsonProperty("InputValue")]
[JsonPropertyName("InputValue")]
public string AttrInputValue;

[JsonProperty("ForeignKeyEntityId")]
[JsonPropertyName("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public JSONENProcessInputEntityRecord() { }

public JSONENProcessInputEntityRecord (ENProcessInputEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessId = (long?) s.ssProcessId;
AttrInputDefinitionId = s.ssInputDefinitionId;
AttrInputDefinitionKey = s.ssInputDefinitionKey;
AttrName = s.ssName;
AttrDataType = s.ssDataType;
AttrInputValue = ConvertToRestWithoutDefaults(s.ssInputValue, "");
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  } else {
AttrId = (long?) s.ssId;
AttrProcessId = (long?) s.ssProcessId;
AttrInputDefinitionId = s.ssInputDefinitionId;
AttrInputDefinitionKey = s.ssInputDefinitionKey;
AttrName = s.ssName;
AttrDataType = s.ssDataType;
AttrInputValue = s.ssInputValue;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENProcessInputEntityRecord, ENProcessInputEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENProcessInputEntityRecord s) => ToStructure(s, config);
}
public static ENProcessInputEntityRecord ToStructure(ssSystem_.RestRecords.JSONENProcessInputEntityRecord obj, IBehaviorsConfiguration config) { 
  ENProcessInputEntityRecord s = new ENProcessInputEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessId = obj.AttrProcessId == null ? 0L : obj.AttrProcessId.Value;
  s.ssInputDefinitionId = obj.AttrInputDefinitionId == null ? "" : obj.AttrInputDefinitionId;
  s.ssInputDefinitionKey = obj.AttrInputDefinitionKey == null ? "" : obj.AttrInputDefinitionKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDataType = obj.AttrDataType == null ? "" : obj.AttrDataType;
  s.ssInputValue = obj.AttrInputValue == null ? "" : obj.AttrInputValue;
  s.ssForeignKeyEntityId = obj.AttrForeignKeyEntityId == null ? "" : obj.AttrForeignKeyEntityId;
  }
  return s;
}

public static Func<ENProcessInputEntityRecord, ssSystem_.RestRecords.JSONENProcessInputEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessInputEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENProcessInputEntityRecord FromStructure(ENProcessInputEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENProcessInputEntityRecord(s, config);
}

}


