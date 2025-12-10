using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListStructRecord
public class JSONRC_97347e879886250cc6e293fbc6c919f7 : AbstractRESTStructure<RC_97347e879886250cc6e293fbc6c919f7> {
[JsonProperty("SampleListStruct")]
[JsonPropertyName("SampleListStruct")]
public ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure AttrSampleListStruct;

public JSONRC_97347e879886250cc6e293fbc6c919f7() { }

public JSONRC_97347e879886250cc6e293fbc6c919f7 (RC_97347e879886250cc6e293fbc6c919f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSampleListStruct = ConvertToRestWithoutDefaults(s.ssSTSampleListStruct, new ST_00ba72a41660161c6373af90c87d0979Structure(), ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure.FromStructureDelegate(config));
  } else {
AttrSampleListStruct = ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure.FromStructure(s.ssSTSampleListStruct, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_97347e879886250cc6e293fbc6c919f7, RC_97347e879886250cc6e293fbc6c919f7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_97347e879886250cc6e293fbc6c919f7 s) => ToStructure(s, config);
}
public static RC_97347e879886250cc6e293fbc6c919f7 ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_97347e879886250cc6e293fbc6c919f7 obj, IBehaviorsConfiguration config) { 
  RC_97347e879886250cc6e293fbc6c919f7 s = new RC_97347e879886250cc6e293fbc6c919f7();
  if(obj != null) {
  s.ssSTSampleListStruct = ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure.ToStructure(obj.AttrSampleListStruct, config);
  }
  return s;
}

public static Func<RC_97347e879886250cc6e293fbc6c919f7, ssRuntimeDestroyer.RestRecords.JSONRC_97347e879886250cc6e293fbc6c919f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_97347e879886250cc6e293fbc6c919f7 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_97347e879886250cc6e293fbc6c919f7 FromStructure(RC_97347e879886250cc6e293fbc6c919f7 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_97347e879886250cc6e293fbc6c919f7(s, config);
}

}


