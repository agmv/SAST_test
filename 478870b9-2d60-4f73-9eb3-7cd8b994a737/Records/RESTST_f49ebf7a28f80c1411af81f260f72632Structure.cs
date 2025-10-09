using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishResetPasswordResult
public class RESTST_f49ebf7a28f80c1411af81f260f72632Structure : AbstractRESTStructure<ST_f49ebf7a28f80c1411af81f260f72632Structure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("FinishResetPasswordFailureReason")]
public ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure AttrFinishResetPasswordFailureReason;

public RESTST_f49ebf7a28f80c1411af81f260f72632Structure() { }

public RESTST_f49ebf7a28f80c1411af81f260f72632Structure (ST_f49ebf7a28f80c1411af81f260f72632Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrFinishResetPasswordFailureReason = ConvertToRestWithoutDefaults(s.ssFinishResetPasswordFailureReason, new ST_9b153b9b179efd305d9e3eb52006065fStructure(), ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrFinishResetPasswordFailureReason = ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure(s.ssFinishResetPasswordFailureReason, config);
  }
}

public static ST_f49ebf7a28f80c1411af81f260f72632Structure ToStructure(ssSystem_.RestRecords.RESTST_f49ebf7a28f80c1411af81f260f72632Structure obj) { 
  ST_f49ebf7a28f80c1411af81f260f72632Structure s = new ST_f49ebf7a28f80c1411af81f260f72632Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssFinishResetPasswordFailureReason = ssSystem_.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.ToStructure(obj.AttrFinishResetPasswordFailureReason);
  }
  return s;
}

public static Func<ST_f49ebf7a28f80c1411af81f260f72632Structure, ssSystem_.RestRecords.RESTST_f49ebf7a28f80c1411af81f260f72632Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f49ebf7a28f80c1411af81f260f72632Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_f49ebf7a28f80c1411af81f260f72632Structure FromStructure(ST_f49ebf7a28f80c1411af81f260f72632Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_f49ebf7a28f80c1411af81f260f72632Structure(s, config);
}

}


