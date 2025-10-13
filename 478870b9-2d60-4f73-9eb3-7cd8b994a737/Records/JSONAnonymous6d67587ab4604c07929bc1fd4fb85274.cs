using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserInfoRecord
public class JSONRC_79f003baa030e546826ed42c3962f582 : AbstractRESTStructure<RC_79f003baa030e546826ed42c3962f582> {
[JsonProperty("UserInfo")]
[JsonPropertyName("UserInfo")]
public ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure AttrUserInfo;

public JSONRC_79f003baa030e546826ed42c3962f582() { }

public JSONRC_79f003baa030e546826ed42c3962f582 (RC_79f003baa030e546826ed42c3962f582 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserInfo = ConvertToRestWithoutDefaults(s.ssSTUserInfo, new ST_401f0448f59979847b24ebdd2db9e1ebStructure(), ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure.FromStructureDelegate(config));
  } else {
AttrUserInfo = ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure.FromStructure(s.ssSTUserInfo, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_79f003baa030e546826ed42c3962f582, RC_79f003baa030e546826ed42c3962f582> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_79f003baa030e546826ed42c3962f582 s) => ToStructure(s, config);
}
public static RC_79f003baa030e546826ed42c3962f582 ToStructure(ssSystem_.RestRecords.JSONRC_79f003baa030e546826ed42c3962f582 obj, IBehaviorsConfiguration config) { 
  RC_79f003baa030e546826ed42c3962f582 s = new RC_79f003baa030e546826ed42c3962f582();
  if(obj != null) {
  s.ssSTUserInfo = ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure.ToStructure(obj.AttrUserInfo, config);
  }
  return s;
}

public static Func<RC_79f003baa030e546826ed42c3962f582, ssSystem_.RestRecords.JSONRC_79f003baa030e546826ed42c3962f582> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_79f003baa030e546826ed42c3962f582 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_79f003baa030e546826ed42c3962f582 FromStructure(RC_79f003baa030e546826ed42c3962f582 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_79f003baa030e546826ed42c3962f582(s, config);
}

}


