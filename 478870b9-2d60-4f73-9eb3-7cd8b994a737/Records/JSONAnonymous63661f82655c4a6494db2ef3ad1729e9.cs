using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityRoleRecord
public class JSONRC_87c777c37ddf7c1355edbd72c4b71391 : AbstractRESTStructure<RC_87c777c37ddf7c1355edbd72c4b71391> {
[JsonProperty("HumanActivityRole")]
[JsonPropertyName("HumanActivityRole")]
public ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord AttrHumanActivityRole;

public JSONRC_87c777c37ddf7c1355edbd72c4b71391() { }

public JSONRC_87c777c37ddf7c1355edbd72c4b71391 (RC_87c777c37ddf7c1355edbd72c4b71391 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHumanActivityRole = ConvertToRestWithoutDefaults(s.ssENHumanActivityRole, new ENHumanActivityRoleEntityRecord(), ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrHumanActivityRole = ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord.FromStructure(s.ssENHumanActivityRole, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_87c777c37ddf7c1355edbd72c4b71391, RC_87c777c37ddf7c1355edbd72c4b71391> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_87c777c37ddf7c1355edbd72c4b71391 s) => ToStructure(s, config);
}
public static RC_87c777c37ddf7c1355edbd72c4b71391 ToStructure(ssSystem_.RestRecords.JSONRC_87c777c37ddf7c1355edbd72c4b71391 obj, IBehaviorsConfiguration config) { 
  RC_87c777c37ddf7c1355edbd72c4b71391 s = new RC_87c777c37ddf7c1355edbd72c4b71391();
  if(obj != null) {
  s.ssENHumanActivityRole = ssSystem_.RestRecords.JSONENHumanActivityRoleEntityRecord.ToStructure(obj.AttrHumanActivityRole, config);
  }
  return s;
}

public static Func<RC_87c777c37ddf7c1355edbd72c4b71391, ssSystem_.RestRecords.JSONRC_87c777c37ddf7c1355edbd72c4b71391> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87c777c37ddf7c1355edbd72c4b71391 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_87c777c37ddf7c1355edbd72c4b71391 FromStructure(RC_87c777c37ddf7c1355edbd72c4b71391 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_87c777c37ddf7c1355edbd72c4b71391(s, config);
}

}


