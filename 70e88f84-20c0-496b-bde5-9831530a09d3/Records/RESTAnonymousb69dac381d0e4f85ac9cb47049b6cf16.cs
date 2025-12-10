using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyerLib.RestRecords;

// HttpResponseStructRecord
public class RESTRC_fbd3e4c28e569cea299f20f76971b2b8 : AbstractRESTStructure<RC_fbd3e4c28e569cea299f20f76971b2b8> {
[JsonProperty("HttpResponseStruct")]
public ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure AttrHttpResponseStruct;

public RESTRC_fbd3e4c28e569cea299f20f76971b2b8() { }

public RESTRC_fbd3e4c28e569cea299f20f76971b2b8 (RC_fbd3e4c28e569cea299f20f76971b2b8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpResponseStruct = ConvertToRestWithoutDefaults(s.ssSTHttpResponseStruct, new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure(), ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure.FromStructureDelegate(config));
  } else {
AttrHttpResponseStruct = ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure.FromStructure(s.ssSTHttpResponseStruct, config);
  }
}

public static RC_fbd3e4c28e569cea299f20f76971b2b8 ToStructure(ssRuntimeDestroyerLib.RestRecords.RESTRC_fbd3e4c28e569cea299f20f76971b2b8 obj) { 
  RC_fbd3e4c28e569cea299f20f76971b2b8 s = new RC_fbd3e4c28e569cea299f20f76971b2b8();
  if(obj != null) {
  s.ssSTHttpResponseStruct = ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure.ToStructure(obj.AttrHttpResponseStruct);
  }
  return s;
}

public static Func<RC_fbd3e4c28e569cea299f20f76971b2b8, ssRuntimeDestroyerLib.RestRecords.RESTRC_fbd3e4c28e569cea299f20f76971b2b8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fbd3e4c28e569cea299f20f76971b2b8 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyerLib.RestRecords.RESTRC_fbd3e4c28e569cea299f20f76971b2b8 FromStructure(RC_fbd3e4c28e569cea299f20f76971b2b8 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyerLib.RestRecords.RESTRC_fbd3e4c28e569cea299f20f76971b2b8(s, config);
}

}


