using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionRole
public class RESTENActivityDefinitionRoleEntityRecord : AbstractRESTStructure<ENActivityDefinitionRoleEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RoleId")]
public string AttrRoleId;

[JsonProperty("ActivityDefinitionId")]
public int? AttrActivityDefinitionId;

public RESTENActivityDefinitionRoleEntityRecord() { }

public RESTENActivityDefinitionRoleEntityRecord (ENActivityDefinitionRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRoleId = s.ssRoleId;
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
  } else {
AttrId = (long?) s.ssId;
AttrRoleId = s.ssRoleId;
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
  }
}

public static ENActivityDefinitionRoleEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord obj) { 
  ENActivityDefinitionRoleEntityRecord s = new ENActivityDefinitionRoleEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRoleId = obj.AttrRoleId == null ? "" : obj.AttrRoleId;
  s.ssActivityDefinitionId = obj.AttrActivityDefinitionId == null ? 0 : obj.AttrActivityDefinitionId.Value;
  }
  return s;
}

public static Func<ENActivityDefinitionRoleEntityRecord, ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionRoleEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord FromStructure(ENActivityDefinitionRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord(s, config);
}

}


