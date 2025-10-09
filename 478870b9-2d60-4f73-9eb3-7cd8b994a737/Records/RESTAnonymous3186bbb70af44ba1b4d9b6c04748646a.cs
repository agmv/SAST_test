using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UpdateUserFailureReasonRecord
public class RESTRC_5d4c0a98b9773e489e7e27bfe5360793 : AbstractRESTStructure<RC_5d4c0a98b9773e489e7e27bfe5360793> {
[JsonProperty("UpdateUserFailureReason")]
public ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure AttrUpdateUserFailureReason;

public RESTRC_5d4c0a98b9773e489e7e27bfe5360793() { }

public RESTRC_5d4c0a98b9773e489e7e27bfe5360793 (RC_5d4c0a98b9773e489e7e27bfe5360793 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUpdateUserFailureReason = ConvertToRestWithoutDefaults(s.ssSTUpdateUserFailureReason, new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure(), ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure.FromStructureDelegate(config));
  } else {
AttrUpdateUserFailureReason = ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure.FromStructure(s.ssSTUpdateUserFailureReason, config);
  }
}

public static RC_5d4c0a98b9773e489e7e27bfe5360793 ToStructure(ssSystem_.RestRecords.RESTRC_5d4c0a98b9773e489e7e27bfe5360793 obj) { 
  RC_5d4c0a98b9773e489e7e27bfe5360793 s = new RC_5d4c0a98b9773e489e7e27bfe5360793();
  if(obj != null) {
  s.ssSTUpdateUserFailureReason = ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure.ToStructure(obj.AttrUpdateUserFailureReason);
  }
  return s;
}

public static Func<RC_5d4c0a98b9773e489e7e27bfe5360793, ssSystem_.RestRecords.RESTRC_5d4c0a98b9773e489e7e27bfe5360793> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5d4c0a98b9773e489e7e27bfe5360793 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_5d4c0a98b9773e489e7e27bfe5360793 FromStructure(RC_5d4c0a98b9773e489e7e27bfe5360793 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_5d4c0a98b9773e489e7e27bfe5360793(s, config);
}

}


