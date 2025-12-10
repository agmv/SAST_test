using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HTTPHeaderRecord
public class JSONRC_0be95ff147264c7a8eb5d98a9a36670a : AbstractRESTStructure<RC_0be95ff147264c7a8eb5d98a9a36670a> {
[JsonProperty("HTTPHeader")]
[JsonPropertyName("HTTPHeader")]
public ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure AttrHTTPHeader;

public JSONRC_0be95ff147264c7a8eb5d98a9a36670a() { }

public JSONRC_0be95ff147264c7a8eb5d98a9a36670a (RC_0be95ff147264c7a8eb5d98a9a36670a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHTTPHeader = ConvertToRestWithoutDefaults(s.ssSTHTTPHeader, new ST_b6163e36a4b633b09c820fee73ba221eStructure(), ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructureDelegate(config));
  } else {
AttrHTTPHeader = ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructure(s.ssSTHTTPHeader, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_0be95ff147264c7a8eb5d98a9a36670a, RC_0be95ff147264c7a8eb5d98a9a36670a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_0be95ff147264c7a8eb5d98a9a36670a s) => ToStructure(s, config);
}
public static RC_0be95ff147264c7a8eb5d98a9a36670a ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_0be95ff147264c7a8eb5d98a9a36670a obj, IBehaviorsConfiguration config) { 
  RC_0be95ff147264c7a8eb5d98a9a36670a s = new RC_0be95ff147264c7a8eb5d98a9a36670a();
  if(obj != null) {
  s.ssSTHTTPHeader = ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure.ToStructure(obj.AttrHTTPHeader, config);
  }
  return s;
}

public static Func<RC_0be95ff147264c7a8eb5d98a9a36670a, ssRuntimeDestroyer.RestRecords.JSONRC_0be95ff147264c7a8eb5d98a9a36670a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0be95ff147264c7a8eb5d98a9a36670a s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_0be95ff147264c7a8eb5d98a9a36670a FromStructure(RC_0be95ff147264c7a8eb5d98a9a36670a s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_0be95ff147264c7a8eb5d98a9a36670a(s, config);
}

}


