using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInstance
public class JSONENProcessInstanceEntityRecord : AbstractRESTStructure<ENProcessInstanceEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProcessDefinitionId")]
[JsonPropertyName("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public long? AttrStatus;

[JsonProperty("StartedOn")]
[JsonPropertyName("StartedOn")]
public String AttrStartedOn;

[JsonProperty("LastModifiedOn")]
[JsonPropertyName("LastModifiedOn")]
public String AttrLastModifiedOn;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

public JSONENProcessInstanceEntityRecord() { }

public JSONENProcessInstanceEntityRecord (ENProcessInstanceEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrStatus = (long?) s.ssStatus;
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrLastModifiedOn = ConvertDateTimeToRestWithoutDefaults(s.ssLastModifiedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
  } else {
AttrId = (long?) s.ssId;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrStatus = (long?) s.ssStatus;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrLastModifiedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastModifiedOn, config.DateTimeFormat);
AttrLabel = s.ssLabel;
  }
}

public static Func<ssSystem_.RestRecords.JSONENProcessInstanceEntityRecord, ENProcessInstanceEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENProcessInstanceEntityRecord s) => ToStructure(s, config);
}
public static ENProcessInstanceEntityRecord ToStructure(ssSystem_.RestRecords.JSONENProcessInstanceEntityRecord obj, IBehaviorsConfiguration config) { 
  ENProcessInstanceEntityRecord s = new ENProcessInstanceEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssStatus = obj.AttrStatus == null ? 0L : obj.AttrStatus.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, config.DateTimeFormat);
  s.ssLastModifiedOn = obj.AttrLastModifiedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastModifiedOn, config.DateTimeFormat);
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<ENProcessInstanceEntityRecord, ssSystem_.RestRecords.JSONENProcessInstanceEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessInstanceEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENProcessInstanceEntityRecord FromStructure(ENProcessInstanceEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENProcessInstanceEntityRecord(s, config);
}

}


