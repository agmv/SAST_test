using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// RoleRecord
public class RESTRC_13630884b629a3a59e929e1cdea42eb1 : AbstractRESTStructure<RC_13630884b629a3a59e929e1cdea42eb1> {
[JsonProperty("Role")]
public ssSystem_.RestRecords.RESTENRoleEntityRecord AttrRole;

public RESTRC_13630884b629a3a59e929e1cdea42eb1() { }

public RESTRC_13630884b629a3a59e929e1cdea42eb1 (RC_13630884b629a3a59e929e1cdea42eb1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRole = ConvertToRestWithoutDefaults(s.ssENRole, new ENRoleEntityRecord(), ssSystem_.RestRecords.RESTENRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrRole = ssSystem_.RestRecords.RESTENRoleEntityRecord.FromStructure(s.ssENRole, config);
  }
}

public static RC_13630884b629a3a59e929e1cdea42eb1 ToStructure(ssSystem_.RestRecords.RESTRC_13630884b629a3a59e929e1cdea42eb1 obj) { 
  RC_13630884b629a3a59e929e1cdea42eb1 s = new RC_13630884b629a3a59e929e1cdea42eb1();
  if(obj != null) {
  s.ssENRole = ssSystem_.RestRecords.RESTENRoleEntityRecord.ToStructure(obj.AttrRole);
  }
  return s;
}

public static Func<RC_13630884b629a3a59e929e1cdea42eb1, ssSystem_.RestRecords.RESTRC_13630884b629a3a59e929e1cdea42eb1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_13630884b629a3a59e929e1cdea42eb1 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_13630884b629a3a59e929e1cdea42eb1 FromStructure(RC_13630884b629a3a59e929e1cdea42eb1 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_13630884b629a3a59e929e1cdea42eb1(s, config);
}

}


