using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Role
public class JSONENRoleEntityRecord : AbstractRESTStructure<ENRoleEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONENRoleEntityRecord() { }

public JSONENRoleEntityRecord (ENRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENRoleEntityRecord, ENRoleEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENRoleEntityRecord s) => ToStructure(s, config);
}
public static ENRoleEntityRecord ToStructure(ssSystem_.RestRecords.JSONENRoleEntityRecord obj, IBehaviorsConfiguration config) { 
  ENRoleEntityRecord s = new ENRoleEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<ENRoleEntityRecord, ssSystem_.RestRecords.JSONENRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENRoleEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENRoleEntityRecord FromStructure(ENRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENRoleEntityRecord(s, config);
}

}


