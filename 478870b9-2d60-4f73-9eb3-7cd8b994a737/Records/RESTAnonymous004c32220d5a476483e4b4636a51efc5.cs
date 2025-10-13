using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishResetPasswordFailureReasonRecord
public class RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d : AbstractRESTStructure<RC_1ba3db8c7175cd095b4f1a36c3a1e53d> {
[JsonProperty("FinishResetPasswordFailureReason")]
public ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure AttrFinishResetPasswordFailureReason;

public RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d() { }

public RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d (RC_1ba3db8c7175cd095b4f1a36c3a1e53d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishResetPasswordFailureReason = ConvertToRestWithoutDefaults(s.ssSTFinishResetPasswordFailureReason, new ST_9b153b9b179efd305d9e3eb52006065fStructure(), ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructureDelegate(config));
  } else {
AttrFinishResetPasswordFailureReason = ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure(s.ssSTFinishResetPasswordFailureReason, config);
  }
}

public static RC_1ba3db8c7175cd095b4f1a36c3a1e53d ToStructure(ssSystem_.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d obj) { 
  RC_1ba3db8c7175cd095b4f1a36c3a1e53d s = new RC_1ba3db8c7175cd095b4f1a36c3a1e53d();
  if(obj != null) {
  s.ssSTFinishResetPasswordFailureReason = ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.ToStructure(obj.AttrFinishResetPasswordFailureReason);
  }
  return s;
}

public static Func<RC_1ba3db8c7175cd095b4f1a36c3a1e53d, ssSystem_.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ba3db8c7175cd095b4f1a36c3a1e53d s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d FromStructure(RC_1ba3db8c7175cd095b4f1a36c3a1e53d s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d(s, config);
}

}


