using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutput
public class RESTENActivityOutputEntityRecord : AbstractRESTStructure<ENActivityOutputEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ActivityId")]
public long? AttrActivityId;

[JsonProperty("OutputDefinitionId")]
public string AttrOutputDefinitionId;

[JsonProperty("OutputDefinitionKey")]
public string AttrOutputDefinitionKey;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("DataType")]
public string AttrDataType;

[JsonProperty("OutputValue")]
public string AttrOutputValue;

[JsonProperty("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public RESTENActivityOutputEntityRecord() { }

public RESTENActivityOutputEntityRecord (ENActivityOutputEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENActivityOutputEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityOutputEntityRecord obj) { 
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

public static Func<ENActivityOutputEntityRecord, ssSystem_.RestRecords.RESTENActivityOutputEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityOutputEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityOutputEntityRecord FromStructure(ENActivityOutputEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityOutputEntityRecord(s, config);
}

}


