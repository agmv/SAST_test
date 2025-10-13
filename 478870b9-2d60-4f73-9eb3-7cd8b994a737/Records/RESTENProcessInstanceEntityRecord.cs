using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInstance
public class RESTENProcessInstanceEntityRecord : AbstractRESTStructure<ENProcessInstanceEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("Status")]
public long? AttrStatus;

[JsonProperty("StartedOn")]
public String AttrStartedOn;

[JsonProperty("LastModifiedOn")]
public String AttrLastModifiedOn;

[JsonProperty("Label")]
public string AttrLabel;

public RESTENProcessInstanceEntityRecord() { }

public RESTENProcessInstanceEntityRecord (ENProcessInstanceEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENProcessInstanceEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord obj) { 
  ENProcessInstanceEntityRecord s = new ENProcessInstanceEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssStatus = obj.AttrStatus == null ? 0L : obj.AttrStatus.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssLastModifiedOn = obj.AttrLastModifiedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastModifiedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<ENProcessInstanceEntityRecord, ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessInstanceEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord FromStructure(ENProcessInstanceEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord(s, config);
}

}


