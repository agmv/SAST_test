using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUserRegistrationFailureReason
public class JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure : AbstractRESTStructure<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure> {
[JsonProperty("InvalidEmail")]
[JsonPropertyName("InvalidEmail")]
public bool? AttrInvalidEmail;

[JsonProperty("InvalidName")]
[JsonPropertyName("InvalidName")]
public bool? AttrInvalidName;

[JsonProperty("UserAlreadyRegistered")]
[JsonPropertyName("UserAlreadyRegistered")]
public bool? AttrUserAlreadyRegistered;

public JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure() { }

public JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidEmail = ConvertToRestWithoutDefaults(s.ssInvalidEmail, false);
AttrInvalidName = ConvertToRestWithoutDefaults(s.ssInvalidName, false);
AttrUserAlreadyRegistered = ConvertToRestWithoutDefaults(s.ssUserAlreadyRegistered, false);
  } else {
AttrInvalidEmail = (bool?) s.ssInvalidEmail;
AttrInvalidName = (bool?) s.ssInvalidName;
AttrUserAlreadyRegistered = (bool?) s.ssUserAlreadyRegistered;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure, ST_8f28b651568fa9d5ba7b5b342de64a1cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure s) => ToStructure(s, config);
}
public static ST_8f28b651568fa9d5ba7b5b342de64a1cStructure ToStructure(ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure obj, IBehaviorsConfiguration config) { 
  ST_8f28b651568fa9d5ba7b5b342de64a1cStructure s = new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure();
  if(obj != null) {
  s.ssInvalidEmail = obj.AttrInvalidEmail == null ? false : obj.AttrInvalidEmail.Value;
  s.ssInvalidName = obj.AttrInvalidName == null ? false : obj.AttrInvalidName.Value;
  s.ssUserAlreadyRegistered = obj.AttrUserAlreadyRegistered == null ? false : obj.AttrUserAlreadyRegistered.Value;
  }
  return s;
}

public static Func<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure, ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure FromStructure(ST_8f28b651568fa9d5ba7b5b342de64a1cStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure(s, config);
}

}


