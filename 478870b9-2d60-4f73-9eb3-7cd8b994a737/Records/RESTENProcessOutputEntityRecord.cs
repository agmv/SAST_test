using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutput
public class RESTENProcessOutputEntityRecord : AbstractRESTStructure<ENProcessOutputEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProcessId")]
public long? AttrProcessId;

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

public RESTENProcessOutputEntityRecord() { }

public RESTENProcessOutputEntityRecord (ENProcessOutputEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENProcessOutputEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessOutputEntityRecord obj) { 
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

public static Func<ENProcessOutputEntityRecord, ssSystem_.RestRecords.RESTENProcessOutputEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessOutputEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessOutputEntityRecord FromStructure(ENProcessOutputEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessOutputEntityRecord(s, config);
}

}


