using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutput
public class JSONENActivityOutputEntityRecord : AbstractRESTStructure<ENActivityOutputEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ActivityId")]
[JsonPropertyName("ActivityId")]
public long? AttrActivityId;

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

public JSONENActivityOutputEntityRecord() { }

public JSONENActivityOutputEntityRecord (ENActivityOutputEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrActivityId = ConvertToRestWithoutDefaults(s.ssActivityId, 0L);
AttrOutputDefinitionId = s.ssOutputDefinitionId;
AttrOutputDefinitionKey = s.ssOutputDefinitionKey;
AttrName = s.ssName;
AttrDataType = s.ssDataType;
AttrOutputValue = ConvertToRestWithoutDefaults(s.ssOutputValue, "");
AttrForeignKeyEntityId = ConvertToRestWithoutDefaults(s.ssForeignKeyEntityId, "");
  } else {
AttrId = (long?) s.ssId;
AttrActivityId = (long?) s.ssActivityId;
AttrOutputDefinitionId = s.ssOutputDefinitionId;
AttrOutputDefinitionKey = s.ssOutputDefinitionKey;
AttrName = s.ssName;
AttrDataType = s.ssDataType;
AttrOutputValue = s.ssOutputValue;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENActivityOutputEntityRecord, ENActivityOutputEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENActivityOutputEntityRecord s) => ToStructure(s, config);
}
public static ENActivityOutputEntityRecord ToStructure(ssSystem_.RestRecords.JSONENActivityOutputEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityOutputEntityRecord s = new ENActivityOutputEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssActivityId = obj.AttrActivityId == null ? 0L : obj.AttrActivityId.Value;
  s.ssOutputDefinitionId = obj.AttrOutputDefinitionId == null ? "" : obj.AttrOutputDefinitionId;
  s.ssOutputDefinitionKey = obj.AttrOutputDefinitionKey == null ? "" : obj.AttrOutputDefinitionKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDataType = obj.AttrDataType == null ? "" : obj.AttrDataType;
  s.ssOutputValue = obj.AttrOutputValue == null ? "" : obj.AttrOutputValue;
  s.ssForeignKeyEntityId = obj.AttrForeignKeyEntityId == null ? "" : obj.AttrForeignKeyEntityId;
  }
  return s;
}

public static Func<ENActivityOutputEntityRecord, ssSystem_.RestRecords.JSONENActivityOutputEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityOutputEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENActivityOutputEntityRecord FromStructure(ENActivityOutputEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENActivityOutputEntityRecord(s, config);
}

}


