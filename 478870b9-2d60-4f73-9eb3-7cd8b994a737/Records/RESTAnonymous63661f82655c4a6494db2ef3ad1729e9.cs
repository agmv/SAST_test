using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityRoleRecord
public class RESTRC_87c777c37ddf7c1355edbd72c4b71391 : AbstractRESTStructure<RC_87c777c37ddf7c1355edbd72c4b71391> {
[JsonProperty("HumanActivityRole")]
public ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord AttrHumanActivityRole;

public RESTRC_87c777c37ddf7c1355edbd72c4b71391() { }

public RESTRC_87c777c37ddf7c1355edbd72c4b71391 (RC_87c777c37ddf7c1355edbd72c4b71391 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHumanActivityRole = ConvertToRestWithoutDefaults(s.ssENHumanActivityRole, new ENHumanActivityRoleEntityRecord(), ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrHumanActivityRole = ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord.FromStructure(s.ssENHumanActivityRole, config);
  }
}

public static RC_87c777c37ddf7c1355edbd72c4b71391 ToStructure(ssSystem_.RestRecords.RESTRC_87c777c37ddf7c1355edbd72c4b71391 obj) { 
  RC_87c777c37ddf7c1355edbd72c4b71391 s = new RC_87c777c37ddf7c1355edbd72c4b71391();
  if(obj != null) {
  s.ssENHumanActivityRole = ssSystem_.RestRecords.RESTENHumanActivityRoleEntityRecord.ToStructure(obj.AttrHumanActivityRole);
  }
  return s;
}

public static Func<RC_87c777c37ddf7c1355edbd72c4b71391, ssSystem_.RestRecords.RESTRC_87c777c37ddf7c1355edbd72c4b71391> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87c777c37ddf7c1355edbd72c4b71391 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_87c777c37ddf7c1355edbd72c4b71391 FromStructure(RC_87c777c37ddf7c1355edbd72c4b71391 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_87c777c37ddf7c1355edbd72c4b71391(s, config);
}

}


