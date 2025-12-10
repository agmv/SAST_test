using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIRoleRecord
public class RESTRC_ed6dfadde1ed7fb74003b4bf09b19473 : AbstractRESTStructure<RC_ed6dfadde1ed7fb74003b4bf09b19473> {
[JsonProperty("AIRole")]
public ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord AttrAIRole;

public RESTRC_ed6dfadde1ed7fb74003b4bf09b19473() { }

public RESTRC_ed6dfadde1ed7fb74003b4bf09b19473 (RC_ed6dfadde1ed7fb74003b4bf09b19473 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIRole = ConvertToRestWithoutDefaults(s.ssENAIRole, new ENAIRoleEntityRecord(), ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrAIRole = ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord.FromStructure(s.ssENAIRole, config);
  }
}

public static RC_ed6dfadde1ed7fb74003b4bf09b19473 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_ed6dfadde1ed7fb74003b4bf09b19473 obj) { 
  RC_ed6dfadde1ed7fb74003b4bf09b19473 s = new RC_ed6dfadde1ed7fb74003b4bf09b19473();
  if(obj != null) {
  s.ssENAIRole = ssRuntimeDestroyer.RestRecords.RESTENAIRoleEntityRecord.ToStructure(obj.AttrAIRole);
  }
  return s;
}

public static Func<RC_ed6dfadde1ed7fb74003b4bf09b19473, ssRuntimeDestroyer.RestRecords.RESTRC_ed6dfadde1ed7fb74003b4bf09b19473> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ed6dfadde1ed7fb74003b4bf09b19473 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_ed6dfadde1ed7fb74003b4bf09b19473 FromStructure(RC_ed6dfadde1ed7fb74003b4bf09b19473 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_ed6dfadde1ed7fb74003b4bf09b19473(s, config);
}

}


