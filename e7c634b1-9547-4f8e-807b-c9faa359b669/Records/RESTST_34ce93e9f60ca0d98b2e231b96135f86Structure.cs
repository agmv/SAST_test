using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpRequestStruct
public class RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure : AbstractRESTStructure<ST_34ce93e9f60ca0d98b2e231b96135f86Structure> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("HttpMethod")]
public string AttrHttpMethod;

public RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure() { }

public RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure (ST_34ce93e9f60ca0d98b2e231b96135f86Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrHttpMethod = ConvertToRestWithoutDefaults(s.ssHttpMethod, "");
  } else {
AttrId = (long?) s.ssId;
AttrHttpMethod = s.ssHttpMethod;
  }
}

public static ST_34ce93e9f60ca0d98b2e231b96135f86Structure ToStructure(ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure obj) { 
  ST_34ce93e9f60ca0d98b2e231b96135f86Structure s = new ST_34ce93e9f60ca0d98b2e231b96135f86Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssHttpMethod = obj.AttrHttpMethod == null ? "" : obj.AttrHttpMethod;
  }
  return s;
}

public static Func<ST_34ce93e9f60ca0d98b2e231b96135f86Structure, ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_34ce93e9f60ca0d98b2e231b96135f86Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure FromStructure(ST_34ce93e9f60ca0d98b2e231b96135f86Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTST_34ce93e9f60ca0d98b2e231b96135f86Structure(s, config);
}

}


