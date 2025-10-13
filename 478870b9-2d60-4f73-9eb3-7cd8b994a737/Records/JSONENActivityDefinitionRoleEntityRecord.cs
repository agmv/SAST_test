using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionRole
public class JSONENActivityDefinitionRoleEntityRecord : AbstractRESTStructure<ENActivityDefinitionRoleEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RoleId")]
[JsonPropertyName("RoleId")]
public string AttrRoleId;

[JsonProperty("ActivityDefinitionId")]
[JsonPropertyName("ActivityDefinitionId")]
public int? AttrActivityDefinitionId;

public JSONENActivityDefinitionRoleEntityRecord() { }

public JSONENActivityDefinitionRoleEntityRecord (ENActivityDefinitionRoleEntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord, ENActivityDefinitionRoleEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord s) => ToStructure(s, config);
}
public static ENActivityDefinitionRoleEntityRecord ToStructure(ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityDefinitionRoleEntityRecord s = new ENActivityDefinitionRoleEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRoleId = obj.AttrRoleId == null ? "" : obj.AttrRoleId;
  s.ssActivityDefinitionId = obj.AttrActivityDefinitionId == null ? 0 : obj.AttrActivityDefinitionId.Value;
  }
  return s;
}

public static Func<ENActivityDefinitionRoleEntityRecord, ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionRoleEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord FromStructure(ENActivityDefinitionRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord(s, config);
}

}


