using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishResetPasswordFailureReason
public class JSONST_9b153b9b179efd305d9e3eb52006065fStructure : AbstractRESTStructure<ST_9b153b9b179efd305d9e3eb52006065fStructure> {
[JsonProperty("PasswordComplexityPolicyFailed")]
[JsonPropertyName("PasswordComplexityPolicyFailed")]
public bool? AttrPasswordComplexityPolicyFailed;

[JsonProperty("InvalidVerificationCode")]
[JsonPropertyName("InvalidVerificationCode")]
public bool? AttrInvalidVerificationCode;

[JsonProperty("InvalidEmail")]
[JsonPropertyName("InvalidEmail")]
public bool? AttrInvalidEmail;

public JSONST_9b153b9b179efd305d9e3eb52006065fStructure() { }

public JSONST_9b153b9b179efd305d9e3eb52006065fStructure (ST_9b153b9b179efd305d9e3eb52006065fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordComplexityPolicyFailed = ConvertToRestWithoutDefaults(s.ssPasswordComplexityPolicyFailed, false);
AttrInvalidVerificationCode = ConvertToRestWithoutDefaults(s.ssInvalidVerificationCode, false);
AttrInvalidEmail = ConvertToRestWithoutDefaults(s.ssInvalidEmail, false);
  } else {
AttrPasswordComplexityPolicyFailed = (bool?) s.ssPasswordComplexityPolicyFailed;
AttrInvalidVerificationCode = (bool?) s.ssInvalidVerificationCode;
AttrInvalidEmail = (bool?) s.ssInvalidEmail;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure, ST_9b153b9b179efd305d9e3eb52006065fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure s) => ToStructure(s, config);
}
public static ST_9b153b9b179efd305d9e3eb52006065fStructure ToStructure(ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure obj, IBehaviorsConfiguration config) { 
  ST_9b153b9b179efd305d9e3eb52006065fStructure s = new ST_9b153b9b179efd305d9e3eb52006065fStructure();
  if(obj != null) {
  s.ssPasswordComplexityPolicyFailed = obj.AttrPasswordComplexityPolicyFailed == null ? false : obj.AttrPasswordComplexityPolicyFailed.Value;
  s.ssInvalidVerificationCode = obj.AttrInvalidVerificationCode == null ? false : obj.AttrInvalidVerificationCode.Value;
  s.ssInvalidEmail = obj.AttrInvalidEmail == null ? false : obj.AttrInvalidEmail.Value;
  }
  return s;
}

public static Func<ST_9b153b9b179efd305d9e3eb52006065fStructure, ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9b153b9b179efd305d9e3eb52006065fStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure FromStructure(ST_9b153b9b179efd305d9e3eb52006065fStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure(s, config);
}

}


