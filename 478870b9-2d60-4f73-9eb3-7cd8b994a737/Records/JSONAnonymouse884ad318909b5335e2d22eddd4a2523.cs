using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// RoleRecord
public class JSONRC_13630884b629a3a59e929e1cdea42eb1 : AbstractRESTStructure<RC_13630884b629a3a59e929e1cdea42eb1> {
[JsonProperty("Role")]
[JsonPropertyName("Role")]
public ssSystem_.RestRecords.JSONENRoleEntityRecord AttrRole;

public JSONRC_13630884b629a3a59e929e1cdea42eb1() { }

public JSONRC_13630884b629a3a59e929e1cdea42eb1 (RC_13630884b629a3a59e929e1cdea42eb1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRole = ConvertToRestWithoutDefaults(s.ssENRole, new ENRoleEntityRecord(), ssSystem_.RestRecords.JSONENRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrRole = ssSystem_.RestRecords.JSONENRoleEntityRecord.FromStructure(s.ssENRole, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_13630884b629a3a59e929e1cdea42eb1, RC_13630884b629a3a59e929e1cdea42eb1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_13630884b629a3a59e929e1cdea42eb1 s) => ToStructure(s, config);
}
public static RC_13630884b629a3a59e929e1cdea42eb1 ToStructure(ssSystem_.RestRecords.JSONRC_13630884b629a3a59e929e1cdea42eb1 obj, IBehaviorsConfiguration config) { 
  RC_13630884b629a3a59e929e1cdea42eb1 s = new RC_13630884b629a3a59e929e1cdea42eb1();
  if(obj != null) {
  s.ssENRole = ssSystem_.RestRecords.JSONENRoleEntityRecord.ToStructure(obj.AttrRole, config);
  }
  return s;
}

public static Func<RC_13630884b629a3a59e929e1cdea42eb1, ssSystem_.RestRecords.JSONRC_13630884b629a3a59e929e1cdea42eb1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_13630884b629a3a59e929e1cdea42eb1 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_13630884b629a3a59e929e1cdea42eb1 FromStructure(RC_13630884b629a3a59e929e1cdea42eb1 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_13630884b629a3a59e929e1cdea42eb1(s, config);
}

}


