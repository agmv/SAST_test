using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityRole
public class JSONENHumanActivityRoleEntityRecord : AbstractRESTStructure<ENHumanActivityRoleEntityRecord> {
[JsonProperty("ActivityInstanceId")]
[JsonPropertyName("ActivityInstanceId")]
public long? AttrActivityInstanceId;

[JsonProperty("RoleId")]
[JsonPropertyName("RoleId")]
public string AttrRoleId;

public JSONENHumanActivityRoleEntityRecord() { }

public JSONENHumanActivityRoleEntityRecord (ENHumanActivityRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityInstanceId = ConvertToRestWithoutDefaults(s.ssActivityInstanceId, 0L);
AttrRoleId = ConvertToRestWithoutDefaults(s.ssRoleId, "");
  } else {
AttrActivityInstanceId = (long?) s.ssActivityInstanceId;
AttrRoleId = s.ssRoleId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord, ENHumanActivityRoleEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord s) => ToStructure(s, config);
}
public static ENHumanActivityRoleEntityRecord ToStructure(ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord obj, IBehaviorsConfiguration config) { 
  ENHumanActivityRoleEntityRecord s = new ENHumanActivityRoleEntityRecord();
  if(obj != null) {
  s.ssActivityInstanceId = obj.AttrActivityInstanceId == null ? 0L : obj.AttrActivityInstanceId.Value;
  s.ssRoleId = obj.AttrRoleId == null ? "" : obj.AttrRoleId;
  }
  return s;
}

public static Func<ENHumanActivityRoleEntityRecord, ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENHumanActivityRoleEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord FromStructure(ENHumanActivityRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord(s, config);
}

}


