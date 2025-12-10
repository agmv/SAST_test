using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpMethodRecord
public class JSONRC_ee5350e5200eabac6362c9f03f6b7e3b : AbstractRESTStructure<RC_ee5350e5200eabac6362c9f03f6b7e3b> {
[JsonProperty("HttpMethod")]
[JsonPropertyName("HttpMethod")]
public ssRuntimeDestroyer.RestRecords.JSONEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord AttrHttpMethod;

public JSONRC_ee5350e5200eabac6362c9f03f6b7e3b() { }

public JSONRC_ee5350e5200eabac6362c9f03f6b7e3b (RC_ee5350e5200eabac6362c9f03f6b7e3b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpMethod = ConvertToRestWithoutDefaults(s.ssENHttpMethod, new EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord(), ssRuntimeDestroyer.RestRecords.JSONEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.FromStructureDelegate(config));
  } else {
AttrHttpMethod = ssRuntimeDestroyer.RestRecords.JSONEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.FromStructure(s.ssENHttpMethod, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_ee5350e5200eabac6362c9f03f6b7e3b, RC_ee5350e5200eabac6362c9f03f6b7e3b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_ee5350e5200eabac6362c9f03f6b7e3b s) => ToStructure(s, config);
}
public static RC_ee5350e5200eabac6362c9f03f6b7e3b ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_ee5350e5200eabac6362c9f03f6b7e3b obj, IBehaviorsConfiguration config) { 
  RC_ee5350e5200eabac6362c9f03f6b7e3b s = new RC_ee5350e5200eabac6362c9f03f6b7e3b();
  if(obj != null) {
  s.ssENHttpMethod = ssRuntimeDestroyer.RestRecords.JSONEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.ToStructure(obj.AttrHttpMethod, config);
  }
  return s;
}

public static Func<RC_ee5350e5200eabac6362c9f03f6b7e3b, ssRuntimeDestroyer.RestRecords.JSONRC_ee5350e5200eabac6362c9f03f6b7e3b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ee5350e5200eabac6362c9f03f6b7e3b s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_ee5350e5200eabac6362c9f03f6b7e3b FromStructure(RC_ee5350e5200eabac6362c9f03f6b7e3b s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_ee5350e5200eabac6362c9f03f6b7e3b(s, config);
}

}


