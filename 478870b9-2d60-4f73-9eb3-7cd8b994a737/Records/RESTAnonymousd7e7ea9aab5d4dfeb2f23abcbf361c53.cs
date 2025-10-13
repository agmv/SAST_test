using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ChangePasswordFailureReasonRecord
public class RESTRC_e5c662d406f83f7f791bd7e5c8b0c543 : AbstractRESTStructure<RC_e5c662d406f83f7f791bd7e5c8b0c543> {
[JsonProperty("ChangePasswordFailureReason")]
public ssSystem_.RestRecords.RESTST_896e066bc5a2d27c8f6a276746e82800Structure AttrChangePasswordFailureReason;

public RESTRC_e5c662d406f83f7f791bd7e5c8b0c543() { }

public RESTRC_e5c662d406f83f7f791bd7e5c8b0c543 (RC_e5c662d406f83f7f791bd7e5c8b0c543 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChangePasswordFailureReason = ConvertToRestWithoutDefaults(s.ssSTChangePasswordFailureReason, new ST_896e066bc5a2d27c8f6a276746e82800Structure(), ssSystem_.RestRecords.RESTST_896e066bc5a2d27c8f6a276746e82800Structure.FromStructureDelegate(config));
  } else {
AttrChangePasswordFailureReason = ssSystem_.RestRecords.RESTST_896e066bc5a2d27c8f6a276746e82800Structure.FromStructure(s.ssSTChangePasswordFailureReason, config);
  }
}

public static RC_e5c662d406f83f7f791bd7e5c8b0c543 ToStructure(ssSystem_.RestRecords.RESTRC_e5c662d406f83f7f791bd7e5c8b0c543 obj) { 
  RC_e5c662d406f83f7f791bd7e5c8b0c543 s = new RC_e5c662d406f83f7f791bd7e5c8b0c543();
  if(obj != null) {
  s.ssSTChangePasswordFailureReason = ssSystem_.RestRecords.RESTST_896e066bc5a2d27c8f6a276746e82800Structure.ToStructure(obj.AttrChangePasswordFailureReason);
  }
  return s;
}

public static Func<RC_e5c662d406f83f7f791bd7e5c8b0c543, ssSystem_.RestRecords.RESTRC_e5c662d406f83f7f791bd7e5c8b0c543> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e5c662d406f83f7f791bd7e5c8b0c543 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_e5c662d406f83f7f791bd7e5c8b0c543 FromStructure(RC_e5c662d406f83f7f791bd7e5c8b0c543 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_e5c662d406f83f7f791bd7e5c8b0c543(s, config);
}

}


