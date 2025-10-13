using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishResetPasswordResult
public class JSONST_f49ebf7a28f80c1411af81f260f72632Structure : AbstractRESTStructure<ST_f49ebf7a28f80c1411af81f260f72632Structure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("FinishResetPasswordFailureReason")]
[JsonPropertyName("FinishResetPasswordFailureReason")]
public ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure AttrFinishResetPasswordFailureReason;

public JSONST_f49ebf7a28f80c1411af81f260f72632Structure() { }

public JSONST_f49ebf7a28f80c1411af81f260f72632Structure (ST_f49ebf7a28f80c1411af81f260f72632Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrFinishResetPasswordFailureReason = ConvertToRestWithoutDefaults(s.ssFinishResetPasswordFailureReason, new ST_9b153b9b179efd305d9e3eb52006065fStructure(), ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrFinishResetPasswordFailureReason = ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure(s.ssFinishResetPasswordFailureReason, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure, ST_f49ebf7a28f80c1411af81f260f72632Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure s) => ToStructure(s, config);
}
public static ST_f49ebf7a28f80c1411af81f260f72632Structure ToStructure(ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure obj, IBehaviorsConfiguration config) { 
  ST_f49ebf7a28f80c1411af81f260f72632Structure s = new ST_f49ebf7a28f80c1411af81f260f72632Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssFinishResetPasswordFailureReason = ssSystem_.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.ToStructure(obj.AttrFinishResetPasswordFailureReason, config);
  }
  return s;
}

public static Func<ST_f49ebf7a28f80c1411af81f260f72632Structure, ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f49ebf7a28f80c1411af81f260f72632Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure FromStructure(ST_f49ebf7a28f80c1411af81f260f72632Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure(s, config);
}

}


