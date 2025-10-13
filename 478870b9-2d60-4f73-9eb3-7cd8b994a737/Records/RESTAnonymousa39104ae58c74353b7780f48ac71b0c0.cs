using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUpdateEmailFailureReasonRecord
public class RESTRC_9808e19d66784f7acd0d80b7d130df17 : AbstractRESTStructure<RC_9808e19d66784f7acd0d80b7d130df17> {
[JsonProperty("FinishUpdateEmailFailureReason")]
public ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure AttrFinishUpdateEmailFailureReason;

public RESTRC_9808e19d66784f7acd0d80b7d130df17() { }

public RESTRC_9808e19d66784f7acd0d80b7d130df17 (RC_9808e19d66784f7acd0d80b7d130df17 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishUpdateEmailFailureReason = ConvertToRestWithoutDefaults(s.ssSTFinishUpdateEmailFailureReason, new ST_23034956e06e8e0a2169e5e731331735Structure(), ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure.FromStructureDelegate(config));
  } else {
AttrFinishUpdateEmailFailureReason = ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure.FromStructure(s.ssSTFinishUpdateEmailFailureReason, config);
  }
}

public static RC_9808e19d66784f7acd0d80b7d130df17 ToStructure(ssSystem_.RestRecords.RESTRC_9808e19d66784f7acd0d80b7d130df17 obj) { 
  RC_9808e19d66784f7acd0d80b7d130df17 s = new RC_9808e19d66784f7acd0d80b7d130df17();
  if(obj != null) {
  s.ssSTFinishUpdateEmailFailureReason = ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure.ToStructure(obj.AttrFinishUpdateEmailFailureReason);
  }
  return s;
}

public static Func<RC_9808e19d66784f7acd0d80b7d130df17, ssSystem_.RestRecords.RESTRC_9808e19d66784f7acd0d80b7d130df17> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9808e19d66784f7acd0d80b7d130df17 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_9808e19d66784f7acd0d80b7d130df17 FromStructure(RC_9808e19d66784f7acd0d80b7d130df17 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_9808e19d66784f7acd0d80b7d130df17(s, config);
}

}


