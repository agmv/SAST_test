using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUserRegistrationResultRecord
public class RESTRC_37cfc11aad68902b9d78f57915b7ae79 : AbstractRESTStructure<RC_37cfc11aad68902b9d78f57915b7ae79> {
[JsonProperty("StartUserRegistrationResult")]
public ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure AttrStartUserRegistrationResult;

public RESTRC_37cfc11aad68902b9d78f57915b7ae79() { }

public RESTRC_37cfc11aad68902b9d78f57915b7ae79 (RC_37cfc11aad68902b9d78f57915b7ae79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUserRegistrationResult = ConvertToRestWithoutDefaults(s.ssSTStartUserRegistrationResult, new ST_b465768a49759f20ddd40d498521c3aeStructure(), ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure.FromStructureDelegate(config));
  } else {
AttrStartUserRegistrationResult = ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure.FromStructure(s.ssSTStartUserRegistrationResult, config);
  }
}

public static RC_37cfc11aad68902b9d78f57915b7ae79 ToStructure(ssSystem_.RestRecords.RESTRC_37cfc11aad68902b9d78f57915b7ae79 obj) { 
  RC_37cfc11aad68902b9d78f57915b7ae79 s = new RC_37cfc11aad68902b9d78f57915b7ae79();
  if(obj != null) {
  s.ssSTStartUserRegistrationResult = ssSystem_.RestRecords.RESTST_b465768a49759f20ddd40d498521c3aeStructure.ToStructure(obj.AttrStartUserRegistrationResult);
  }
  return s;
}

public static Func<RC_37cfc11aad68902b9d78f57915b7ae79, ssSystem_.RestRecords.RESTRC_37cfc11aad68902b9d78f57915b7ae79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_37cfc11aad68902b9d78f57915b7ae79 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_37cfc11aad68902b9d78f57915b7ae79 FromStructure(RC_37cfc11aad68902b9d78f57915b7ae79 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_37cfc11aad68902b9d78f57915b7ae79(s, config);
}

}


