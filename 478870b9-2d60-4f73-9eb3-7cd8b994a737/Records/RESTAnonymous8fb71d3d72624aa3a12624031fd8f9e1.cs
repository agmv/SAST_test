using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserLoginFailureReasonRecord
public class RESTRC_f61c868ef053db94121ce89ee15a14fe : AbstractRESTStructure<RC_f61c868ef053db94121ce89ee15a14fe> {
[JsonProperty("UserLoginFailureReason")]
public ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure AttrUserLoginFailureReason;

public RESTRC_f61c868ef053db94121ce89ee15a14fe() { }

public RESTRC_f61c868ef053db94121ce89ee15a14fe (RC_f61c868ef053db94121ce89ee15a14fe s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserLoginFailureReason = ConvertToRestWithoutDefaults(s.ssSTUserLoginFailureReason, new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure(), ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.FromStructureDelegate(config));
  } else {
AttrUserLoginFailureReason = ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.FromStructure(s.ssSTUserLoginFailureReason, config);
  }
}

public static RC_f61c868ef053db94121ce89ee15a14fe ToStructure(ssSystem_.RestRecords.RESTRC_f61c868ef053db94121ce89ee15a14fe obj) { 
  RC_f61c868ef053db94121ce89ee15a14fe s = new RC_f61c868ef053db94121ce89ee15a14fe();
  if(obj != null) {
  s.ssSTUserLoginFailureReason = ssSystem_.RestRecords.RESTST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.ToStructure(obj.AttrUserLoginFailureReason);
  }
  return s;
}

public static Func<RC_f61c868ef053db94121ce89ee15a14fe, ssSystem_.RestRecords.RESTRC_f61c868ef053db94121ce89ee15a14fe> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f61c868ef053db94121ce89ee15a14fe s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_f61c868ef053db94121ce89ee15a14fe FromStructure(RC_f61c868ef053db94121ce89ee15a14fe s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_f61c868ef053db94121ce89ee15a14fe(s, config);
}

}


