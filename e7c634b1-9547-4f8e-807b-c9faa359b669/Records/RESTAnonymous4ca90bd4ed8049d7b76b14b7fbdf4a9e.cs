using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpMethodRecord
public class RESTRC_ee5350e5200eabac6362c9f03f6b7e3b : AbstractRESTStructure<RC_ee5350e5200eabac6362c9f03f6b7e3b> {
[JsonProperty("HttpMethod")]
public ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord AttrHttpMethod;

public RESTRC_ee5350e5200eabac6362c9f03f6b7e3b() { }

public RESTRC_ee5350e5200eabac6362c9f03f6b7e3b (RC_ee5350e5200eabac6362c9f03f6b7e3b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpMethod = ConvertToRestWithoutDefaults(s.ssENHttpMethod, new EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord(), ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.FromStructureDelegate(config));
  } else {
AttrHttpMethod = ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.FromStructure(s.ssENHttpMethod, config);
  }
}

public static RC_ee5350e5200eabac6362c9f03f6b7e3b ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_ee5350e5200eabac6362c9f03f6b7e3b obj) { 
  RC_ee5350e5200eabac6362c9f03f6b7e3b s = new RC_ee5350e5200eabac6362c9f03f6b7e3b();
  if(obj != null) {
  s.ssENHttpMethod = ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.ToStructure(obj.AttrHttpMethod);
  }
  return s;
}

public static Func<RC_ee5350e5200eabac6362c9f03f6b7e3b, ssRuntimeDestroyer.RestRecords.RESTRC_ee5350e5200eabac6362c9f03f6b7e3b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ee5350e5200eabac6362c9f03f6b7e3b s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_ee5350e5200eabac6362c9f03f6b7e3b FromStructure(RC_ee5350e5200eabac6362c9f03f6b7e3b s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_ee5350e5200eabac6362c9f03f6b7e3b(s, config);
}

}


