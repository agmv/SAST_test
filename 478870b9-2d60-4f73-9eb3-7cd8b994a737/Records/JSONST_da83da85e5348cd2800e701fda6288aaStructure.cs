using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserUpdateInfo
public class JSONST_da83da85e5348cd2800e701fda6288aaStructure : AbstractRESTStructure<ST_da83da85e5348cd2800e701fda6288aaStructure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("PhotoURL")]
[JsonPropertyName("PhotoURL")]
public string AttrPhotoURL;

public JSONST_da83da85e5348cd2800e701fda6288aaStructure() { }

public JSONST_da83da85e5348cd2800e701fda6288aaStructure (ST_da83da85e5348cd2800e701fda6288aaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrPhotoURL = ConvertToRestWithoutDefaults(s.ssPhotoURL, "");
  } else {
AttrName = s.ssName;
AttrPhotoURL = s.ssPhotoURL;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure, ST_da83da85e5348cd2800e701fda6288aaStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure s) => ToStructure(s, config);
}
public static ST_da83da85e5348cd2800e701fda6288aaStructure ToStructure(ssSystem_.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure obj, IBehaviorsConfiguration config) { 
  ST_da83da85e5348cd2800e701fda6288aaStructure s = new ST_da83da85e5348cd2800e701fda6288aaStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssPhotoURL = obj.AttrPhotoURL == null ? "" : obj.AttrPhotoURL;
  }
  return s;
}

public static Func<ST_da83da85e5348cd2800e701fda6288aaStructure, ssSystem_.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_da83da85e5348cd2800e701fda6288aaStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure FromStructure(ST_da83da85e5348cd2800e701fda6288aaStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure(s, config);
}

}


