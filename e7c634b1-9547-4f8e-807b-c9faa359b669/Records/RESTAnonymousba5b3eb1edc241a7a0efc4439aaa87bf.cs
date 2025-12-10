using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// EmployeeRecord
public class RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76 : AbstractRESTStructure<RC_3b55179c5be20c3d1041cf4a1dcf3f76> {
[JsonProperty("Employee")]
public ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord AttrEmployee;

public RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76() { }

public RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76 (RC_3b55179c5be20c3d1041cf4a1dcf3f76 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmployee = ConvertToRestWithoutDefaults(s.ssENEmployee, new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord(), ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.FromStructureDelegate(config));
  } else {
AttrEmployee = ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.FromStructure(s.ssENEmployee, config);
  }
}

public static RC_3b55179c5be20c3d1041cf4a1dcf3f76 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76 obj) { 
  RC_3b55179c5be20c3d1041cf4a1dcf3f76 s = new RC_3b55179c5be20c3d1041cf4a1dcf3f76();
  if(obj != null) {
  s.ssENEmployee = ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.ToStructure(obj.AttrEmployee);
  }
  return s;
}

public static Func<RC_3b55179c5be20c3d1041cf4a1dcf3f76, ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b55179c5be20c3d1041cf4a1dcf3f76 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76 FromStructure(RC_3b55179c5be20c3d1041cf4a1dcf3f76 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76(s, config);
}

}


