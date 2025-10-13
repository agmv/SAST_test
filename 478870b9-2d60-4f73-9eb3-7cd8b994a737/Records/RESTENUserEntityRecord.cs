using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// User
public class RESTENUserEntityRecord : AbstractRESTStructure<ENUserEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("PhotoUrl")]
public string AttrPhotoUrl;

[JsonProperty("Username")]
public string AttrUsername;

public RESTENUserEntityRecord() { }

public RESTENUserEntityRecord (ENUserEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENUserEntityRecord ToStructure(ssSystem_.RestRecords.RESTENUserEntityRecord obj) { 
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

public static Func<ENUserEntityRecord, ssSystem_.RestRecords.RESTENUserEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENUserEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENUserEntityRecord FromStructure(ENUserEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENUserEntityRecord(s, config);
}

}


