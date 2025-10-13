using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartResetPasswordResult
public class JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure : AbstractRESTStructure<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("VerificationCode")]
[JsonPropertyName("VerificationCode")]
public string AttrVerificationCode;

public JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure() { }

public JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = (bool?) s.ssSuccess;
AttrVerificationCode = ConvertToRestWithoutDefaults(s.ssVerificationCode, "");
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrVerificationCode = s.ssVerificationCode;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure, ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure s) => ToStructure(s, config);
}
public static ST_7df0b593cd1052614bf3d2f66d1ab2efStructure ToStructure(ssSystem_.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure obj, IBehaviorsConfiguration config) { 
  ST_7df0b593cd1052614bf3d2f66d1ab2efStructure s = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssVerificationCode = obj.AttrVerificationCode == null ? "" : obj.AttrVerificationCode;
  }
  return s;
}

public static Func<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure, ssSystem_.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure FromStructure(ST_7df0b593cd1052614bf3d2f66d1ab2efStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure(s, config);
}

}


