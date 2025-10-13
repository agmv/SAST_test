using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Role
public class RESTENRoleEntityRecord : AbstractRESTStructure<ENRoleEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTENRoleEntityRecord() { }

public RESTENRoleEntityRecord (ENRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static ENRoleEntityRecord ToStructure(ssSystem_.RestRecords.RESTENRoleEntityRecord obj) { 
  ENRoleEntityRecord s = new ENRoleEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<ENRoleEntityRecord, ssSystem_.RestRecords.RESTENRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENRoleEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENRoleEntityRecord FromStructure(ENRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENRoleEntityRecord(s, config);
}

}


