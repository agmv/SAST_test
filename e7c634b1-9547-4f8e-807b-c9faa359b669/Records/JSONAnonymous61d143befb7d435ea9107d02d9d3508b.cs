using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Enum_colorRecord
public class JSONRC_8bd458d44b2829526bf34cf688a965a6 : AbstractRESTStructure<RC_8bd458d44b2829526bf34cf688a965a6> {
[JsonProperty("Enum_color")]
[JsonPropertyName("Enum_color")]
public ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord AttrEnum_color;

public JSONRC_8bd458d44b2829526bf34cf688a965a6() { }

public JSONRC_8bd458d44b2829526bf34cf688a965a6 (RC_8bd458d44b2829526bf34cf688a965a6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEnum_color = ConvertToRestWithoutDefaults(s.ssENEnum_color, new EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord(), ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord.FromStructureDelegate(config));
  } else {
AttrEnum_color = ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord.FromStructure(s.ssENEnum_color, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_8bd458d44b2829526bf34cf688a965a6, RC_8bd458d44b2829526bf34cf688a965a6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_8bd458d44b2829526bf34cf688a965a6 s) => ToStructure(s, config);
}
public static RC_8bd458d44b2829526bf34cf688a965a6 ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_8bd458d44b2829526bf34cf688a965a6 obj, IBehaviorsConfiguration config) { 
  RC_8bd458d44b2829526bf34cf688a965a6 s = new RC_8bd458d44b2829526bf34cf688a965a6();
  if(obj != null) {
  s.ssENEnum_color = ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord.ToStructure(obj.AttrEnum_color, config);
  }
  return s;
}

public static Func<RC_8bd458d44b2829526bf34cf688a965a6, ssRuntimeDestroyer.RestRecords.JSONRC_8bd458d44b2829526bf34cf688a965a6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8bd458d44b2829526bf34cf688a965a6 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_8bd458d44b2829526bf34cf688a965a6 FromStructure(RC_8bd458d44b2829526bf34cf688a965a6 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_8bd458d44b2829526bf34cf688a965a6(s, config);
}

}


