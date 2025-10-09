using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserLoginResult
public class RESTST_784fb57b420e5c0c2e1f611378088fbaStructure : AbstractRESTStructure<ST_784fb57b420e5c0c2e1f611378088fbaStructure> {
[JsonProperty("RetryAfterSeconds")]
public int? AttrRetryAfterSeconds;

[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("UserLoginFailureReason")]
public ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure AttrUserLoginFailureReason;

public RESTST_784fb57b420e5c0c2e1f611378088fbaStructure() { }

public RESTST_784fb57b420e5c0c2e1f611378088fbaStructure (ST_784fb57b420e5c0c2e1f611378088fbaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRetryAfterSeconds = ConvertToRestWithoutDefaults(s.ssRetryAfterSeconds, 0);
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrUserLoginFailureReason = ConvertToRestWithoutDefaults(s.ssUserLoginFailureReason, new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure(), ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.FromStructureDelegate(config));
  } else {
AttrRetryAfterSeconds = (int?) s.ssRetryAfterSeconds;
AttrSuccess = (bool?) s.ssSuccess;
AttrUserId = s.ssUserId;
AttrUserLoginFailureReason = ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.FromStructure(s.ssUserLoginFailureReason, config);
  }
}

public static ST_784fb57b420e5c0c2e1f611378088fbaStructure ToStructure(ssSystem_.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure obj) { 
  ST_784fb57b420e5c0c2e1f611378088fbaStructure s = new ST_784fb57b420e5c0c2e1f611378088fbaStructure();
  if(obj != null) {
  s.ssRetryAfterSeconds = obj.AttrRetryAfterSeconds == null ? 0 : obj.AttrRetryAfterSeconds.Value;
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssUserLoginFailureReason = ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.ToStructure(obj.AttrUserLoginFailureReason);
  }
  return s;
}

public static Func<ST_784fb57b420e5c0c2e1f611378088fbaStructure, ssSystem_.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_784fb57b420e5c0c2e1f611378088fbaStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure FromStructure(ST_784fb57b420e5c0c2e1f611378088fbaStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure(s, config);
}

}


