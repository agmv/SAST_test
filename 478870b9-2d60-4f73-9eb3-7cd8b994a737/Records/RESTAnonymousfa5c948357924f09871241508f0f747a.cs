using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// PasswordValidationResultRecord
public class RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27 : AbstractRESTStructure<RC_b27f0b968b0f7cea61506ac9d6ee7c27> {
[JsonProperty("PasswordValidationResult")]
public ssSystem_.RestRecords.RESTST_b9e6959231369ae517164f0fb8e8606dStructure AttrPasswordValidationResult;

public RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27() { }

public RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27 (RC_b27f0b968b0f7cea61506ac9d6ee7c27 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordValidationResult = ConvertToRestWithoutDefaults(s.ssSTPasswordValidationResult, new ST_b9e6959231369ae517164f0fb8e8606dStructure(), ssSystem_.RestRecords.RESTST_b9e6959231369ae517164f0fb8e8606dStructure.FromStructureDelegate(config));
  } else {
AttrPasswordValidationResult = ssSystem_.RestRecords.RESTST_b9e6959231369ae517164f0fb8e8606dStructure.FromStructure(s.ssSTPasswordValidationResult, config);
  }
}

public static RC_b27f0b968b0f7cea61506ac9d6ee7c27 ToStructure(ssSystem_.RestRecords.RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27 obj) { 
  RC_b27f0b968b0f7cea61506ac9d6ee7c27 s = new RC_b27f0b968b0f7cea61506ac9d6ee7c27();
  if(obj != null) {
  s.ssSTPasswordValidationResult = ssSystem_.RestRecords.RESTST_b9e6959231369ae517164f0fb8e8606dStructure.ToStructure(obj.AttrPasswordValidationResult);
  }
  return s;
}

public static Func<RC_b27f0b968b0f7cea61506ac9d6ee7c27, ssSystem_.RestRecords.RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b27f0b968b0f7cea61506ac9d6ee7c27 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27 FromStructure(RC_b27f0b968b0f7cea61506ac9d6ee7c27 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_b27f0b968b0f7cea61506ac9d6ee7c27(s, config);
}

}


