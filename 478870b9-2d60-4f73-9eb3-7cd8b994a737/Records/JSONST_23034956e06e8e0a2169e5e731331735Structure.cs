using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUpdateEmailFailureReason
public class JSONST_23034956e06e8e0a2169e5e731331735Structure : AbstractRESTStructure<ST_23034956e06e8e0a2169e5e731331735Structure> {
[JsonProperty("InvalidVerificationCode")]
[JsonPropertyName("InvalidVerificationCode")]
public bool? AttrInvalidVerificationCode;

public JSONST_23034956e06e8e0a2169e5e731331735Structure() { }

public JSONST_23034956e06e8e0a2169e5e731331735Structure (ST_23034956e06e8e0a2169e5e731331735Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidVerificationCode = ConvertToRestWithoutDefaults(s.ssInvalidVerificationCode, false);
  } else {
AttrInvalidVerificationCode = (bool?) s.ssInvalidVerificationCode;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure, ST_23034956e06e8e0a2169e5e731331735Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure s) => ToStructure(s, config);
}
public static ST_23034956e06e8e0a2169e5e731331735Structure ToStructure(ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure obj, IBehaviorsConfiguration config) { 
  ST_23034956e06e8e0a2169e5e731331735Structure s = new ST_23034956e06e8e0a2169e5e731331735Structure();
  if(obj != null) {
  s.ssInvalidVerificationCode = obj.AttrInvalidVerificationCode == null ? false : obj.AttrInvalidVerificationCode.Value;
  }
  return s;
}

public static Func<ST_23034956e06e8e0a2169e5e731331735Structure, ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_23034956e06e8e0a2169e5e731331735Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure FromStructure(ST_23034956e06e8e0a2169e5e731331735Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure(s, config);
}

}


