using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ExternalIdentityProvider
public class RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure : AbstractRESTStructure<ST_7b0e31d9e5a94347cc99b90226c3a090Structure> {
[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("Name")]
public string AttrName;

public RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure() { }

public RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure (ST_7b0e31d9e5a94347cc99b90226c3a090Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKey = s.ssKey;
AttrName = s.ssName;
  } else {
AttrKey = s.ssKey;
AttrName = s.ssName;
  }
}

public static ST_7b0e31d9e5a94347cc99b90226c3a090Structure ToStructure(ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure obj) { 
  ST_7b0e31d9e5a94347cc99b90226c3a090Structure s = new ST_7b0e31d9e5a94347cc99b90226c3a090Structure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ST_7b0e31d9e5a94347cc99b90226c3a090Structure, ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7b0e31d9e5a94347cc99b90226c3a090Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure FromStructure(ST_7b0e31d9e5a94347cc99b90226c3a090Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure(s, config);
}

}


