using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInput
public class RESTENProcessInputEntityRecord : AbstractRESTStructure<ENProcessInputEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProcessId")]
public long? AttrProcessId;

[JsonProperty("InputDefinitionId")]
public string AttrInputDefinitionId;

[JsonProperty("InputDefinitionKey")]
public string AttrInputDefinitionKey;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("DataType")]
public string AttrDataType;

[JsonProperty("InputValue")]
public string AttrInputValue;

[JsonProperty("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public RESTENProcessInputEntityRecord() { }

public RESTENProcessInputEntityRecord (ENProcessInputEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENProcessInputEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessInputEntityRecord obj) { 
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

public static Func<ENProcessInputEntityRecord, ssSystem_.RestRecords.RESTENProcessInputEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessInputEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessInputEntityRecord FromStructure(ENProcessInputEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessInputEntityRecord(s, config);
}

}


