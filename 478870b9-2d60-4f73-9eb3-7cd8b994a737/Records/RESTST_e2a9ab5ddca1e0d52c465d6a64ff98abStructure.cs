using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserLoginFailureReason
public class RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure : AbstractRESTStructure<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure> {
[JsonProperty("InvalidCredentials")]
public bool? AttrInvalidCredentials;

[JsonProperty("TooManyFailedLoginAttempts")]
public bool? AttrTooManyFailedLoginAttempts;

public RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure() { }

public RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidCredentials = ConvertToRestWithoutDefaults(s.ssInvalidCredentials, false);
AttrTooManyFailedLoginAttempts = ConvertToRestWithoutDefaults(s.ssTooManyFailedLoginAttempts, false);
  } else {
AttrInvalidCredentials = (bool?) s.ssInvalidCredentials;
AttrTooManyFailedLoginAttempts = (bool?) s.ssTooManyFailedLoginAttempts;
  }
}

public static ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure ToStructure(ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure obj) { 
  ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure s = new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure();
  if(obj != null) {
  s.ssInvalidCredentials = obj.AttrInvalidCredentials == null ? false : obj.AttrInvalidCredentials.Value;
  s.ssTooManyFailedLoginAttempts = obj.AttrTooManyFailedLoginAttempts == null ? false : obj.AttrTooManyFailedLoginAttempts.Value;
  }
  return s;
}

public static Func<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure, ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure FromStructure(ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure(s, config);
}

}


