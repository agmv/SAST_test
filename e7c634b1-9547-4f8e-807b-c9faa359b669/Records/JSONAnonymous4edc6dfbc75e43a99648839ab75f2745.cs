using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// EmployeeNameRecord
public class JSONRC_bfa970c705c6402f0a2a74e513cf30f2 : AbstractRESTStructure<RC_bfa970c705c6402f0a2a74e513cf30f2> {
[JsonProperty("EmployeeName")]
[JsonPropertyName("EmployeeName")]
public ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure AttrEmployeeName;

public JSONRC_bfa970c705c6402f0a2a74e513cf30f2() { }

public JSONRC_bfa970c705c6402f0a2a74e513cf30f2 (RC_bfa970c705c6402f0a2a74e513cf30f2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmployeeName = ConvertToRestWithoutDefaults(s.ssSTEmployeeName, new ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure(), ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure.FromStructureDelegate(config));
  } else {
AttrEmployeeName = ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure.FromStructure(s.ssSTEmployeeName, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_bfa970c705c6402f0a2a74e513cf30f2, RC_bfa970c705c6402f0a2a74e513cf30f2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_bfa970c705c6402f0a2a74e513cf30f2 s) => ToStructure(s, config);
}
public static RC_bfa970c705c6402f0a2a74e513cf30f2 ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_bfa970c705c6402f0a2a74e513cf30f2 obj, IBehaviorsConfiguration config) { 
  RC_bfa970c705c6402f0a2a74e513cf30f2 s = new RC_bfa970c705c6402f0a2a74e513cf30f2();
  if(obj != null) {
  s.ssSTEmployeeName = ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure.ToStructure(obj.AttrEmployeeName, config);
  }
  return s;
}

public static Func<RC_bfa970c705c6402f0a2a74e513cf30f2, ssRuntimeDestroyer.RestRecords.JSONRC_bfa970c705c6402f0a2a74e513cf30f2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bfa970c705c6402f0a2a74e513cf30f2 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_bfa970c705c6402f0a2a74e513cf30f2 FromStructure(RC_bfa970c705c6402f0a2a74e513cf30f2 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_bfa970c705c6402f0a2a74e513cf30f2(s, config);
}

}


