using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpRequestStruct
public class JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure : AbstractRESTStructure<ST_34ce93e9f60ca0d98b2e231b96135f86Structure> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("HttpMethod")]
[JsonPropertyName("HttpMethod")]
public string AttrHttpMethod;

public JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure() { }

public JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure (ST_34ce93e9f60ca0d98b2e231b96135f86Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrHttpMethod = ConvertToRestWithoutDefaults(s.ssHttpMethod, "");
  } else {
AttrId = (long?) s.ssId;
AttrHttpMethod = s.ssHttpMethod;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure, ST_34ce93e9f60ca0d98b2e231b96135f86Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure s) => ToStructure(s, config);
}
public static ST_34ce93e9f60ca0d98b2e231b96135f86Structure ToStructure(ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure obj, IBehaviorsConfiguration config) { 
  ST_34ce93e9f60ca0d98b2e231b96135f86Structure s = new ST_34ce93e9f60ca0d98b2e231b96135f86Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssHttpMethod = obj.AttrHttpMethod == null ? "" : obj.AttrHttpMethod;
  }
  return s;
}

public static Func<ST_34ce93e9f60ca0d98b2e231b96135f86Structure, ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_34ce93e9f60ca0d98b2e231b96135f86Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure FromStructure(ST_34ce93e9f60ca0d98b2e231b96135f86Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONST_34ce93e9f60ca0d98b2e231b96135f86Structure(s, config);
}

}


