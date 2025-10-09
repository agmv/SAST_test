using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UpdateUserFailureReasonRecord
public class JSONRC_5d4c0a98b9773e489e7e27bfe5360793 : AbstractRESTStructure<RC_5d4c0a98b9773e489e7e27bfe5360793> {
[JsonProperty("UpdateUserFailureReason")]
[JsonPropertyName("UpdateUserFailureReason")]
public ssSystem_.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure AttrUpdateUserFailureReason;

public JSONRC_5d4c0a98b9773e489e7e27bfe5360793() { }

public JSONRC_5d4c0a98b9773e489e7e27bfe5360793 (RC_5d4c0a98b9773e489e7e27bfe5360793 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUpdateUserFailureReason = ConvertToRestWithoutDefaults(s.ssSTUpdateUserFailureReason, new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure(), ssSystem_.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure.FromStructureDelegate(config));
  } else {
AttrUpdateUserFailureReason = ssSystem_.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure.FromStructure(s.ssSTUpdateUserFailureReason, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_5d4c0a98b9773e489e7e27bfe5360793, RC_5d4c0a98b9773e489e7e27bfe5360793> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_5d4c0a98b9773e489e7e27bfe5360793 s) => ToStructure(s, config);
}
public static RC_5d4c0a98b9773e489e7e27bfe5360793 ToStructure(ssSystem_.RestRecords.JSONRC_5d4c0a98b9773e489e7e27bfe5360793 obj, IBehaviorsConfiguration config) { 
  RC_5d4c0a98b9773e489e7e27bfe5360793 s = new RC_5d4c0a98b9773e489e7e27bfe5360793();
  if(obj != null) {
  s.ssSTUpdateUserFailureReason = ssSystem_.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure.ToStructure(obj.AttrUpdateUserFailureReason, config);
  }
  return s;
}

public static Func<RC_5d4c0a98b9773e489e7e27bfe5360793, ssSystem_.RestRecords.JSONRC_5d4c0a98b9773e489e7e27bfe5360793> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5d4c0a98b9773e489e7e27bfe5360793 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_5d4c0a98b9773e489e7e27bfe5360793 FromStructure(RC_5d4c0a98b9773e489e7e27bfe5360793 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_5d4c0a98b9773e489e7e27bfe5360793(s, config);
}

}


