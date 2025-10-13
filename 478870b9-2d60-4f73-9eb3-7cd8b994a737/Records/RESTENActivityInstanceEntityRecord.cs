using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityInstance
public class RESTENActivityInstanceEntityRecord : AbstractRESTStructure<ENActivityInstanceEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ActivityDefinitionId")]
public int? AttrActivityDefinitionId;

[JsonProperty("ProcessInstanceId")]
public long? AttrProcessInstanceId;

[JsonProperty("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("Status")]
public long? AttrStatus;

[JsonProperty("StartedOn")]
public String AttrStartedOn;

[JsonProperty("LastModifiedOn")]
public String AttrLastModifiedOn;

[JsonProperty("HasExpired")]
public bool? AttrHasExpired;

public RESTENActivityInstanceEntityRecord() { }

public RESTENActivityInstanceEntityRecord (ENActivityInstanceEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
AttrProcessInstanceId = (long?) s.ssProcessInstanceId;
AttrProcessDefinitionId = ConvertToRestWithoutDefaults(s.ssProcessDefinitionId, 0);
AttrStatus = (long?) s.ssStatus;
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrLastModifiedOn = ConvertDateTimeToRestWithoutDefaults(s.ssLastModifiedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrHasExpired = ConvertToRestWithoutDefaults(s.ssHasExpired, false);
  } else {
AttrId = (long?) s.ssId;
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
AttrProcessInstanceId = (long?) s.ssProcessInstanceId;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrStatus = (long?) s.ssStatus;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrLastModifiedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastModifiedOn, config.DateTimeFormat);
AttrHasExpired = (bool?) s.ssHasExpired;
  }
}

public static ENActivityInstanceEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord obj) { 
  ENActivityInstanceEntityRecord s = new ENActivityInstanceEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssActivityDefinitionId = obj.AttrActivityDefinitionId == null ? 0 : obj.AttrActivityDefinitionId.Value;
  s.ssProcessInstanceId = obj.AttrProcessInstanceId == null ? 0L : obj.AttrProcessInstanceId.Value;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssStatus = obj.AttrStatus == null ? 0L : obj.AttrStatus.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssLastModifiedOn = obj.AttrLastModifiedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastModifiedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssHasExpired = obj.AttrHasExpired == null ? false : obj.AttrHasExpired.Value;
  }
  return s;
}

public static Func<ENActivityInstanceEntityRecord, ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityInstanceEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord FromStructure(ENActivityInstanceEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord(s, config);
}

}


