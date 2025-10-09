using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUserRegistrationResultRecord
public class JSONRC_37cfc11aad68902b9d78f57915b7ae79 : AbstractRESTStructure<RC_37cfc11aad68902b9d78f57915b7ae79> {
[JsonProperty("StartUserRegistrationResult")]
[JsonPropertyName("StartUserRegistrationResult")]
public ssSystem_.RestRecords.JSONST_b465768a49759f20ddd40d498521c3aeStructure AttrStartUserRegistrationResult;

public JSONRC_37cfc11aad68902b9d78f57915b7ae79() { }

public JSONRC_37cfc11aad68902b9d78f57915b7ae79 (RC_37cfc11aad68902b9d78f57915b7ae79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUserRegistrationResult = ConvertToRestWithoutDefaults(s.ssSTStartUserRegistrationResult, new ST_b465768a49759f20ddd40d498521c3aeStructure(), ssSystem_.RestRecords.JSONST_b465768a49759f20ddd40d498521c3aeStructure.FromStructureDelegate(config));
  } else {
AttrStartUserRegistrationResult = ssSystem_.RestRecords.JSONST_b465768a49759f20ddd40d498521c3aeStructure.FromStructure(s.ssSTStartUserRegistrationResult, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_37cfc11aad68902b9d78f57915b7ae79, RC_37cfc11aad68902b9d78f57915b7ae79> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_37cfc11aad68902b9d78f57915b7ae79 s) => ToStructure(s, config);
}
public static RC_37cfc11aad68902b9d78f57915b7ae79 ToStructure(ssSystem_.RestRecords.JSONRC_37cfc11aad68902b9d78f57915b7ae79 obj, IBehaviorsConfiguration config) { 
  RC_37cfc11aad68902b9d78f57915b7ae79 s = new RC_37cfc11aad68902b9d78f57915b7ae79();
  if(obj != null) {
  s.ssSTStartUserRegistrationResult = ssSystem_.RestRecords.JSONST_b465768a49759f20ddd40d498521c3aeStructure.ToStructure(obj.AttrStartUserRegistrationResult, config);
  }
  return s;
}

public static Func<RC_37cfc11aad68902b9d78f57915b7ae79, ssSystem_.RestRecords.JSONRC_37cfc11aad68902b9d78f57915b7ae79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_37cfc11aad68902b9d78f57915b7ae79 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_37cfc11aad68902b9d78f57915b7ae79 FromStructure(RC_37cfc11aad68902b9d78f57915b7ae79 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_37cfc11aad68902b9d78f57915b7ae79(s, config);
}

}


