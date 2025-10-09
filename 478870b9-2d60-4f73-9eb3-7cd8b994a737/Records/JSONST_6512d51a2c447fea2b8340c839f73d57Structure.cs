using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUserRegistrationFailureReason
public class JSONST_6512d51a2c447fea2b8340c839f73d57Structure : AbstractRESTStructure<ST_6512d51a2c447fea2b8340c839f73d57Structure> {
[JsonProperty("InvalidVerificationCode")]
[JsonPropertyName("InvalidVerificationCode")]
public bool? AttrInvalidVerificationCode;

[JsonProperty("PasswordComplexityPolicyFailed")]
[JsonPropertyName("PasswordComplexityPolicyFailed")]
public bool? AttrPasswordComplexityPolicyFailed;

[JsonProperty("InvalidEmail")]
[JsonPropertyName("InvalidEmail")]
public bool? AttrInvalidEmail;

public JSONST_6512d51a2c447fea2b8340c839f73d57Structure() { }

public JSONST_6512d51a2c447fea2b8340c839f73d57Structure (ST_6512d51a2c447fea2b8340c839f73d57Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidVerificationCode = ConvertToRestWithoutDefaults(s.ssInvalidVerificationCode, false);
AttrPasswordComplexityPolicyFailed = ConvertToRestWithoutDefaults(s.ssPasswordComplexityPolicyFailed, false);
AttrInvalidEmail = ConvertToRestWithoutDefaults(s.ssInvalidEmail, false);
  } else {
AttrInvalidVerificationCode = (bool?) s.ssInvalidVerificationCode;
AttrPasswordComplexityPolicyFailed = (bool?) s.ssPasswordComplexityPolicyFailed;
AttrInvalidEmail = (bool?) s.ssInvalidEmail;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_6512d51a2c447fea2b8340c839f73d57Structure, ST_6512d51a2c447fea2b8340c839f73d57Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_6512d51a2c447fea2b8340c839f73d57Structure s) => ToStructure(s, config);
}
public static ST_6512d51a2c447fea2b8340c839f73d57Structure ToStructure(ssSystem_.RestRecords.JSONST_6512d51a2c447fea2b8340c839f73d57Structure obj, IBehaviorsConfiguration config) { 
  ST_6512d51a2c447fea2b8340c839f73d57Structure s = new ST_6512d51a2c447fea2b8340c839f73d57Structure();
  if(obj != null) {
  s.ssInvalidVerificationCode = obj.AttrInvalidVerificationCode == null ? false : obj.AttrInvalidVerificationCode.Value;
  s.ssPasswordComplexityPolicyFailed = obj.AttrPasswordComplexityPolicyFailed == null ? false : obj.AttrPasswordComplexityPolicyFailed.Value;
  s.ssInvalidEmail = obj.AttrInvalidEmail == null ? false : obj.AttrInvalidEmail.Value;
  }
  return s;
}

public static Func<ST_6512d51a2c447fea2b8340c839f73d57Structure, ssSystem_.RestRecords.JSONST_6512d51a2c447fea2b8340c839f73d57Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6512d51a2c447fea2b8340c839f73d57Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_6512d51a2c447fea2b8340c839f73d57Structure FromStructure(ST_6512d51a2c447fea2b8340c839f73d57Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_6512d51a2c447fea2b8340c839f73d57Structure(s, config);
}

}


