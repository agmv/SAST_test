using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserInfo
public class JSONST_401f0448f59979847b24ebdd2db9e1ebStructure : AbstractRESTStructure<ST_401f0448f59979847b24ebdd2db9e1ebStructure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("PhotoURL")]
[JsonPropertyName("PhotoURL")]
public string AttrPhotoURL;

public JSONST_401f0448f59979847b24ebdd2db9e1ebStructure() { }

public JSONST_401f0448f59979847b24ebdd2db9e1ebStructure (ST_401f0448f59979847b24ebdd2db9e1ebStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrPhotoURL = ConvertToRestWithoutDefaults(s.ssPhotoURL, "");
  } else {
AttrName = s.ssName;
AttrEmail = s.ssEmail;
AttrPhotoURL = s.ssPhotoURL;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure, ST_401f0448f59979847b24ebdd2db9e1ebStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure s) => ToStructure(s, config);
}
public static ST_401f0448f59979847b24ebdd2db9e1ebStructure ToStructure(ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure obj, IBehaviorsConfiguration config) { 
  ST_401f0448f59979847b24ebdd2db9e1ebStructure s = new ST_401f0448f59979847b24ebdd2db9e1ebStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssPhotoURL = obj.AttrPhotoURL == null ? "" : obj.AttrPhotoURL;
  }
  return s;
}

public static Func<ST_401f0448f59979847b24ebdd2db9e1ebStructure, ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_401f0448f59979847b24ebdd2db9e1ebStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure FromStructure(ST_401f0448f59979847b24ebdd2db9e1ebStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_401f0448f59979847b24ebdd2db9e1ebStructure(s, config);
}

}


