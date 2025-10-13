using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityRole
public class RESTENHumanActivityRoleEntityRecord : AbstractRESTStructure<ENHumanActivityRoleEntityRecord> {
[JsonProperty("ActivityInstanceId")]
public long? AttrActivityInstanceId;

[JsonProperty("RoleId")]
public string AttrRoleId;

public RESTENHumanActivityRoleEntityRecord() { }

public RESTENHumanActivityRoleEntityRecord (ENHumanActivityRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityInstanceId = ConvertToRestWithoutDefaults(s.ssActivityInstanceId, 0L);
AttrRoleId = ConvertToRestWithoutDefaults(s.ssRoleId, "");
  } else {
AttrActivityInstanceId = (long?) s.ssActivityInstanceId;
AttrRoleId = s.ssRoleId;
  }
}

public static ENHumanActivityRoleEntityRecord ToStructure(ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord obj) { 
  ENHumanActivityRoleEntityRecord s = new ENHumanActivityRoleEntityRecord();
  if(obj != null) {
  s.ssActivityInstanceId = obj.AttrActivityInstanceId == null ? 0L : obj.AttrActivityInstanceId.Value;
  s.ssRoleId = obj.AttrRoleId == null ? "" : obj.AttrRoleId;
  }
  return s;
}

public static Func<ENHumanActivityRoleEntityRecord, ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENHumanActivityRoleEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord FromStructure(ENHumanActivityRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord(s, config);
}

}


