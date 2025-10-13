using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UpdateUserFailureReason
public class RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure : AbstractRESTStructure<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure> {
[JsonProperty("InvalidCredentials")]
public bool? AttrInvalidCredentials;

[JsonProperty("InvalidName")]
public bool? AttrInvalidName;

[JsonProperty("InvalidPhotoURL")]
public bool? AttrInvalidPhotoURL;

public RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure() { }

public RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidCredentials = ConvertToRestWithoutDefaults(s.ssInvalidCredentials, false);
AttrInvalidName = ConvertToRestWithoutDefaults(s.ssInvalidName, false);
AttrInvalidPhotoURL = ConvertToRestWithoutDefaults(s.ssInvalidPhotoURL, false);
  } else {
AttrInvalidCredentials = (bool?) s.ssInvalidCredentials;
AttrInvalidName = (bool?) s.ssInvalidName;
AttrInvalidPhotoURL = (bool?) s.ssInvalidPhotoURL;
  }
}

public static ST_6f88d6be05f2234ba151435ee8bf2cd4Structure ToStructure(ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure obj) { 
  ST_6f88d6be05f2234ba151435ee8bf2cd4Structure s = new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure();
  if(obj != null) {
  s.ssInvalidCredentials = obj.AttrInvalidCredentials == null ? false : obj.AttrInvalidCredentials.Value;
  s.ssInvalidName = obj.AttrInvalidName == null ? false : obj.AttrInvalidName.Value;
  s.ssInvalidPhotoURL = obj.AttrInvalidPhotoURL == null ? false : obj.AttrInvalidPhotoURL.Value;
  }
  return s;
}

public static Func<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure, ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure FromStructure(ST_6f88d6be05f2234ba151435ee8bf2cd4Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure(s, config);
}

}


