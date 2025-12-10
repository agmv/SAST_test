using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpRequestStructRecord
public class RESTRC_04ad037e78ae694bb0e09c43b99c8b99 : AbstractRESTStructure<RC_04ad037e78ae694bb0e09c43b99c8b99> {
[JsonProperty("HttpRequestStruct")]
public ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure AttrHttpRequestStruct;

public RESTRC_04ad037e78ae694bb0e09c43b99c8b99() { }

public RESTRC_04ad037e78ae694bb0e09c43b99c8b99 (RC_04ad037e78ae694bb0e09c43b99c8b99 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpRequestStruct = ConvertToRestWithoutDefaults(s.ssSTHttpRequestStruct, new ST_34ce93e9f60ca0d98b2e231b96135f86Structure(), ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure.FromStructureDelegate(config));
  } else {
AttrHttpRequestStruct = ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure.FromStructure(s.ssSTHttpRequestStruct, config);
  }
}

public static RC_04ad037e78ae694bb0e09c43b99c8b99 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_04ad037e78ae694bb0e09c43b99c8b99 obj) { 
  RC_04ad037e78ae694bb0e09c43b99c8b99 s = new RC_04ad037e78ae694bb0e09c43b99c8b99();
  if(obj != null) {
  s.ssSTHttpRequestStruct = ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure.ToStructure(obj.AttrHttpRequestStruct);
  }
  return s;
}

public static Func<RC_04ad037e78ae694bb0e09c43b99c8b99, ssRuntimeDestroyer.RestRecords.RESTRC_04ad037e78ae694bb0e09c43b99c8b99> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04ad037e78ae694bb0e09c43b99c8b99 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_04ad037e78ae694bb0e09c43b99c8b99 FromStructure(RC_04ad037e78ae694bb0e09c43b99c8b99 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_04ad037e78ae694bb0e09c43b99c8b99(s, config);
}

}


