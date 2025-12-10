using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIRole
public class JSONENAIRoleEntityRecord : AbstractRESTStructure<ENAIRoleEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENAIRoleEntityRecord() { }

public JSONENAIRoleEntityRecord (ENAIRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONENAIRoleEntityRecord, ENAIRoleEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONENAIRoleEntityRecord s) => ToStructure(s, config);
}
public static ENAIRoleEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONENAIRoleEntityRecord obj, IBehaviorsConfiguration config) { 
  ENAIRoleEntityRecord s = new ENAIRoleEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENAIRoleEntityRecord, ssRuntimeDestroyer.RestRecords.JSONENAIRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENAIRoleEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONENAIRoleEntityRecord FromStructure(ENAIRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONENAIRoleEntityRecord(s, config);
}

}


