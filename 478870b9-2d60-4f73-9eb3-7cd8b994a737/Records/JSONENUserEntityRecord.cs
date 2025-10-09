using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// User
public class JSONENUserEntityRecord : AbstractRESTStructure<ENUserEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("PhotoUrl")]
[JsonPropertyName("PhotoUrl")]
public string AttrPhotoUrl;

[JsonProperty("Username")]
[JsonPropertyName("Username")]
public string AttrUsername;

public JSONENUserEntityRecord() { }

public JSONENUserEntityRecord (ENUserEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrPhotoUrl = ConvertToRestWithoutDefaults(s.ssPhotoUrl, "");
AttrUsername = ConvertToRestWithoutDefaults(s.ssUsername, "");
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
AttrEmail = s.ssEmail;
AttrPhotoUrl = s.ssPhotoUrl;
AttrUsername = s.ssUsername;
  }
}

public static Func<ssSystem_.RestRecords.JSONENUserEntityRecord, ENUserEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENUserEntityRecord s) => ToStructure(s, config);
}
public static ENUserEntityRecord ToStructure(ssSystem_.RestRecords.JSONENUserEntityRecord obj, IBehaviorsConfiguration config) { 
  ENUserEntityRecord s = new ENUserEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssPhotoUrl = obj.AttrPhotoUrl == null ? "" : obj.AttrPhotoUrl;
  s.ssUsername = obj.AttrUsername == null ? "" : obj.AttrUsername;
  }
  return s;
}

public static Func<ENUserEntityRecord, ssSystem_.RestRecords.JSONENUserEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENUserEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENUserEntityRecord FromStructure(ENUserEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENUserEntityRecord(s, config);
}

}


