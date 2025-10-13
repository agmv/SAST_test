using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUserRegistrationResult
public class RESTST_b465768a49759f20ddd40d498521c3aeStructure : AbstractRESTStructure<ST_b465768a49759f20ddd40d498521c3aeStructure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("StartUserRegistrationFailureReason")]
public ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure AttrStartUserRegistrationFailureReason;

[JsonProperty("VerificationCode")]
public string AttrVerificationCode;

[JsonProperty("UserId")]
public string AttrUserId;

public RESTST_b465768a49759f20ddd40d498521c3aeStructure() { }

public RESTST_b465768a49759f20ddd40d498521c3aeStructure (ST_b465768a49759f20ddd40d498521c3aeStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrStartUserRegistrationFailureReason = ConvertToRestWithoutDefaults(s.ssStartUserRegistrationFailureReason, new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure(), ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure.FromStructureDelegate(config));
AttrVerificationCode = ConvertToRestWithoutDefaults(s.ssVerificationCode, "");
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrStartUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure.FromStructure(s.ssStartUserRegistrationFailureReason, config);
AttrVerificationCode = s.ssVerificationCode;
AttrUserId = s.ssUserId;
  }
}

public static ST_b465768a49759f20ddd40d498521c3aeStructure ToStructure(ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure obj) { 
  ST_b465768a49759f20ddd40d498521c3aeStructure s = new ST_b465768a49759f20ddd40d498521c3aeStructure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssStartUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure.ToStructure(obj.AttrStartUserRegistrationFailureReason);
  s.ssVerificationCode = obj.AttrVerificationCode == null ? "" : obj.AttrVerificationCode;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  }
  return s;
}

public static Func<ST_b465768a49759f20ddd40d498521c3aeStructure, ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b465768a49759f20ddd40d498521c3aeStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure FromStructure(ST_b465768a49759f20ddd40d498521c3aeStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure(s, config);
}

}


