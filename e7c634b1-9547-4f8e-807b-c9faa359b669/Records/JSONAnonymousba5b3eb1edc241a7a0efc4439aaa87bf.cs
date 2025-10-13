using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// EmployeeRecord
public class JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76 : AbstractRESTStructure<RC_3b55179c5be20c3d1041cf4a1dcf3f76> {
[JsonProperty("Employee")]
[JsonPropertyName("Employee")]
public ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord AttrEmployee;

public JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76() { }

public JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76 (RC_3b55179c5be20c3d1041cf4a1dcf3f76 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmployee = ConvertToRestWithoutDefaults(s.ssENEmployee, new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord(), ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.FromStructureDelegate(config));
  } else {
AttrEmployee = ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.FromStructure(s.ssENEmployee, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76, RC_3b55179c5be20c3d1041cf4a1dcf3f76> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76 s) => ToStructure(s, config);
}
public static RC_3b55179c5be20c3d1041cf4a1dcf3f76 ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76 obj, IBehaviorsConfiguration config) { 
  RC_3b55179c5be20c3d1041cf4a1dcf3f76 s = new RC_3b55179c5be20c3d1041cf4a1dcf3f76();
  if(obj != null) {
  s.ssENEmployee = ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.ToStructure(obj.AttrEmployee, config);
  }
  return s;
}

public static Func<RC_3b55179c5be20c3d1041cf4a1dcf3f76, ssRuntimeDestroyer.RestRecords.JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b55179c5be20c3d1041cf4a1dcf3f76 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76 FromStructure(RC_3b55179c5be20c3d1041cf4a1dcf3f76 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_3b55179c5be20c3d1041cf4a1dcf3f76(s, config);
}

}


