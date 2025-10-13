using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HTTPHeaderRecord
public class RESTRC_0be95ff147264c7a8eb5d98a9a36670a : AbstractRESTStructure<RC_0be95ff147264c7a8eb5d98a9a36670a> {
[JsonProperty("HTTPHeader")]
public ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure AttrHTTPHeader;

public RESTRC_0be95ff147264c7a8eb5d98a9a36670a() { }

public RESTRC_0be95ff147264c7a8eb5d98a9a36670a (RC_0be95ff147264c7a8eb5d98a9a36670a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHTTPHeader = ConvertToRestWithoutDefaults(s.ssSTHTTPHeader, new ST_b6163e36a4b633b09c820fee73ba221eStructure(), ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructureDelegate(config));
  } else {
AttrHTTPHeader = ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructure(s.ssSTHTTPHeader, config);
  }
}

public static RC_0be95ff147264c7a8eb5d98a9a36670a ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_0be95ff147264c7a8eb5d98a9a36670a obj) { 
  RC_0be95ff147264c7a8eb5d98a9a36670a s = new RC_0be95ff147264c7a8eb5d98a9a36670a();
  if(obj != null) {
  s.ssSTHTTPHeader = ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure.ToStructure(obj.AttrHTTPHeader);
  }
  return s;
}

public static Func<RC_0be95ff147264c7a8eb5d98a9a36670a, ssRuntimeDestroyer.RestRecords.RESTRC_0be95ff147264c7a8eb5d98a9a36670a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0be95ff147264c7a8eb5d98a9a36670a s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_0be95ff147264c7a8eb5d98a9a36670a FromStructure(RC_0be95ff147264c7a8eb5d98a9a36670a s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_0be95ff147264c7a8eb5d98a9a36670a(s, config);
}

}


