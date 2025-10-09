using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUpdateEmailFailureReason
public class RESTST_23034956e06e8e0a2169e5e731331735Structure : AbstractRESTStructure<ST_23034956e06e8e0a2169e5e731331735Structure> {
[JsonProperty("InvalidVerificationCode")]
public bool? AttrInvalidVerificationCode;

public RESTST_23034956e06e8e0a2169e5e731331735Structure() { }

public RESTST_23034956e06e8e0a2169e5e731331735Structure (ST_23034956e06e8e0a2169e5e731331735Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidVerificationCode = ConvertToRestWithoutDefaults(s.ssInvalidVerificationCode, false);
  } else {
AttrInvalidVerificationCode = (bool?) s.ssInvalidVerificationCode;
  }
}

public static ST_23034956e06e8e0a2169e5e731331735Structure ToStructure(ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure obj) { 
  ST_23034956e06e8e0a2169e5e731331735Structure s = new ST_23034956e06e8e0a2169e5e731331735Structure();
  if(obj != null) {
  s.ssInvalidVerificationCode = obj.AttrInvalidVerificationCode == null ? false : obj.AttrInvalidVerificationCode.Value;
  }
  return s;
}

public static Func<ST_23034956e06e8e0a2169e5e731331735Structure, ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_23034956e06e8e0a2169e5e731331735Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure FromStructure(ST_23034956e06e8e0a2169e5e731331735Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure(s, config);
}

}


