using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyerLib.RestRecords;

// HttpResponseStruct
public class RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure : AbstractRESTStructure<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure> {
[JsonProperty("StatusCode")]
public int? AttrStatusCode;

[JsonProperty("Body")]
public string AttrBody;

public RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure() { }

public RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStatusCode = ConvertToRestWithoutDefaults(s.ssStatusCode, 0);
AttrBody = ConvertToRestWithoutDefaults(s.ssBody, "");
  } else {
AttrStatusCode = (int?) s.ssStatusCode;
AttrBody = s.ssBody;
  }
}

public static ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure ToStructure(ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure obj) { 
  ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure s = new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure();
  if(obj != null) {
  s.ssStatusCode = obj.AttrStatusCode == null ? 0 : obj.AttrStatusCode.Value;
  s.ssBody = obj.AttrBody == null ? "" : obj.AttrBody;
  }
  return s;
}

public static Func<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure, ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure FromStructure(ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyerLib.RestRecords.RESTST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure(s, config);
}

}


