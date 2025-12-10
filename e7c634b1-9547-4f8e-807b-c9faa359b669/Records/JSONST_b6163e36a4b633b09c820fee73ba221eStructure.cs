using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HTTPHeader
public class JSONST_b6163e36a4b633b09c820fee73ba221eStructure : AbstractRESTStructure<ST_b6163e36a4b633b09c820fee73ba221eStructure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONST_b6163e36a4b633b09c820fee73ba221eStructure() { }

public JSONST_b6163e36a4b633b09c820fee73ba221eStructure (ST_b6163e36a4b633b09c820fee73ba221eStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrName = s.ssName;
AttrValue = s.ssValue;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure, ST_b6163e36a4b633b09c820fee73ba221eStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure s) => ToStructure(s, config);
}
public static ST_b6163e36a4b633b09c820fee73ba221eStructure ToStructure(ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure obj, IBehaviorsConfiguration config) { 
  ST_b6163e36a4b633b09c820fee73ba221eStructure s = new ST_b6163e36a4b633b09c820fee73ba221eStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_b6163e36a4b633b09c820fee73ba221eStructure, ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b6163e36a4b633b09c820fee73ba221eStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure FromStructure(ST_b6163e36a4b633b09c820fee73ba221eStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure(s, config);
}

}


