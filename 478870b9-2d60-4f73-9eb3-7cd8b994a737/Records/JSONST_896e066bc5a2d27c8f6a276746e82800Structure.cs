using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ChangePasswordFailureReason
public class JSONST_896e066bc5a2d27c8f6a276746e82800Structure : AbstractRESTStructure<ST_896e066bc5a2d27c8f6a276746e82800Structure> {
[JsonProperty("PasswordComplexityPolicyFailed")]
[JsonPropertyName("PasswordComplexityPolicyFailed")]
public bool? AttrPasswordComplexityPolicyFailed;

[JsonProperty("InvalidCredentials")]
[JsonPropertyName("InvalidCredentials")]
public bool? AttrInvalidCredentials;

[JsonProperty("TooManyFailedAttempts")]
[JsonPropertyName("TooManyFailedAttempts")]
public bool? AttrTooManyFailedAttempts;

public JSONST_896e066bc5a2d27c8f6a276746e82800Structure() { }

public JSONST_896e066bc5a2d27c8f6a276746e82800Structure (ST_896e066bc5a2d27c8f6a276746e82800Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordComplexityPolicyFailed = ConvertToRestWithoutDefaults(s.ssPasswordComplexityPolicyFailed, false);
AttrInvalidCredentials = ConvertToRestWithoutDefaults(s.ssInvalidCredentials, false);
AttrTooManyFailedAttempts = ConvertToRestWithoutDefaults(s.ssTooManyFailedAttempts, false);
  } else {
AttrPasswordComplexityPolicyFailed = (bool?) s.ssPasswordComplexityPolicyFailed;
AttrInvalidCredentials = (bool?) s.ssInvalidCredentials;
AttrTooManyFailedAttempts = (bool?) s.ssTooManyFailedAttempts;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure, ST_896e066bc5a2d27c8f6a276746e82800Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure s) => ToStructure(s, config);
}
public static ST_896e066bc5a2d27c8f6a276746e82800Structure ToStructure(ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure obj, IBehaviorsConfiguration config) { 
  ST_896e066bc5a2d27c8f6a276746e82800Structure s = new ST_896e066bc5a2d27c8f6a276746e82800Structure();
  if(obj != null) {
  s.ssPasswordComplexityPolicyFailed = obj.AttrPasswordComplexityPolicyFailed == null ? false : obj.AttrPasswordComplexityPolicyFailed.Value;
  s.ssInvalidCredentials = obj.AttrInvalidCredentials == null ? false : obj.AttrInvalidCredentials.Value;
  s.ssTooManyFailedAttempts = obj.AttrTooManyFailedAttempts == null ? false : obj.AttrTooManyFailedAttempts.Value;
  }
  return s;
}

public static Func<ST_896e066bc5a2d27c8f6a276746e82800Structure, ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_896e066bc5a2d27c8f6a276746e82800Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure FromStructure(ST_896e066bc5a2d27c8f6a276746e82800Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure(s, config);
}

}


