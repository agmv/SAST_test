using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpRequestStructRecord
public class JSONRC_04ad037e78ae694bb0e09c43b99c8b99 : AbstractRESTStructure<RC_04ad037e78ae694bb0e09c43b99c8b99> {
[JsonProperty("HttpRequestStruct")]
[JsonPropertyName("HttpRequestStruct")]
public ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure AttrHttpRequestStruct;

public JSONRC_04ad037e78ae694bb0e09c43b99c8b99() { }

public JSONRC_04ad037e78ae694bb0e09c43b99c8b99 (RC_04ad037e78ae694bb0e09c43b99c8b99 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpRequestStruct = ConvertToRestWithoutDefaults(s.ssSTHttpRequestStruct, new ST_34ce93e9f60ca0d98b2e231b96135f86Structure(), ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure.FromStructureDelegate(config));
  } else {
AttrHttpRequestStruct = ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure.FromStructure(s.ssSTHttpRequestStruct, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_04ad037e78ae694bb0e09c43b99c8b99, RC_04ad037e78ae694bb0e09c43b99c8b99> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_04ad037e78ae694bb0e09c43b99c8b99 s) => ToStructure(s, config);
}
public static RC_04ad037e78ae694bb0e09c43b99c8b99 ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_04ad037e78ae694bb0e09c43b99c8b99 obj, IBehaviorsConfiguration config) { 
  RC_04ad037e78ae694bb0e09c43b99c8b99 s = new RC_04ad037e78ae694bb0e09c43b99c8b99();
  if(obj != null) {
  s.ssSTHttpRequestStruct = ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure.ToStructure(obj.AttrHttpRequestStruct, config);
  }
  return s;
}

public static Func<RC_04ad037e78ae694bb0e09c43b99c8b99, ssRuntimeDestroyer.RestRecords.JSONRC_04ad037e78ae694bb0e09c43b99c8b99> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04ad037e78ae694bb0e09c43b99c8b99 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_04ad037e78ae694bb0e09c43b99c8b99 FromStructure(RC_04ad037e78ae694bb0e09c43b99c8b99 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_04ad037e78ae694bb0e09c43b99c8b99(s, config);
}

}


