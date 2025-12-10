using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIRole
public class RESTENAIRoleEntityRecord : AbstractRESTStructure<ENAIRoleEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTENAIRoleEntityRecord() { }

public RESTENAIRoleEntityRecord (ENAIRoleEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static ENAIRoleEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord obj) { 
  ENAIRoleEntityRecord s = new ENAIRoleEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENAIRoleEntityRecord, ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENAIRoleEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord FromStructure(ENAIRoleEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord(s, config);
}

}


