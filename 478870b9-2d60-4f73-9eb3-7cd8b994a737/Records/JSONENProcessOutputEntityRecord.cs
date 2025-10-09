using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutput
public class JSONENProcessOutputEntityRecord : AbstractRESTStructure<ENProcessOutputEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProcessId")]
[JsonPropertyName("ProcessId")]
public long? AttrProcessId;

[JsonProperty("OutputDefinitionId")]
[JsonPropertyName("OutputDefinitionId")]
public string AttrOutputDefinitionId;

[JsonProperty("OutputDefinitionKey")]
[JsonPropertyName("OutputDefinitionKey")]
public string AttrOutputDefinitionKey;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("DataType")]
[JsonPropertyName("DataType")]
public string AttrDataType;

[JsonProperty("OutputValue")]
[JsonPropertyName("OutputValue")]
public string AttrOutputValue;

[JsonProperty("ForeignKeyEntityId")]
[JsonPropertyName("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public JSONENProcessOutputEntityRecord() { }

public JSONENProcessOutputEntityRecord (ENProcessOutputEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessId = ConvertToRestWithoutDefaults(s.ssProcessId, 0L);
AttrOutputDefinitionId = s.ssOutputDefinitionId;
AttrOutputDefinitionKey = s.ssOutputDefinitionKey;
AttrName = s.ssName;
AttrDataType = s.ssDataType;
AttrOutputValue = ConvertToRestWithoutDefaults(s.ssOutputValue, "");
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  } else {
AttrId = (long?) s.ssId;
AttrProcessId = (long?) s.ssProcessId;
AttrOutputDefinitionId = s.ssOutputDefinitionId;
AttrOutputDefinitionKey = s.ssOutputDefinitionKey;
AttrName = s.ssName;
AttrDataType = s.ssDataType;
AttrOutputValue = s.ssOutputValue;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENProcessOutputEntityRecord, ENProcessOutputEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENProcessOutputEntityRecord s) => ToStructure(s, config);
}
public static ENProcessOutputEntityRecord ToStructure(ssSystem_.RestRecords.JSONENProcessOutputEntityRecord obj, IBehaviorsConfiguration config) { 
  ENProcessOutputEntityRecord s = new ENProcessOutputEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessId = obj.AttrProcessId == null ? 0L : obj.AttrProcessId.Value;
  s.ssOutputDefinitionId = obj.AttrOutputDefinitionId == null ? "" : obj.AttrOutputDefinitionId;
  s.ssOutputDefinitionKey = obj.AttrOutputDefinitionKey == null ? "" : obj.AttrOutputDefinitionKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDataType = obj.AttrDataType == null ? "" : obj.AttrDataType;
  s.ssOutputValue = obj.AttrOutputValue == null ? "" : obj.AttrOutputValue;
  s.ssForeignKeyEntityId = obj.AttrForeignKeyEntityId == null ? "" : obj.AttrForeignKeyEntityId;
  }
  return s;
}

public static Func<ENProcessOutputEntityRecord, ssSystem_.RestRecords.JSONENProcessOutputEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessOutputEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENProcessOutputEntityRecord FromStructure(ENProcessOutputEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENProcessOutputEntityRecord(s, config);
}

}


