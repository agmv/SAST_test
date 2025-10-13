using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishResetPasswordResultRecord
public class JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e : AbstractRESTStructure<RC_9817a5747e4b09aa3a6a7eb35ce9f66e> {
[JsonProperty("FinishResetPasswordResult")]
[JsonPropertyName("FinishResetPasswordResult")]
public ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure AttrFinishResetPasswordResult;

public JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e() { }

public JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e (RC_9817a5747e4b09aa3a6a7eb35ce9f66e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishResetPasswordResult = ConvertToRestWithoutDefaults(s.ssSTFinishResetPasswordResult, new ST_f49ebf7a28f80c1411af81f260f72632Structure(), ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure.FromStructureDelegate(config));
  } else {
AttrFinishResetPasswordResult = ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure.FromStructure(s.ssSTFinishResetPasswordResult, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e, RC_9817a5747e4b09aa3a6a7eb35ce9f66e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e s) => ToStructure(s, config);
}
public static RC_9817a5747e4b09aa3a6a7eb35ce9f66e ToStructure(ssSystem_.RestRecords.JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e obj, IBehaviorsConfiguration config) { 
  RC_9817a5747e4b09aa3a6a7eb35ce9f66e s = new RC_9817a5747e4b09aa3a6a7eb35ce9f66e();
  if(obj != null) {
  s.ssSTFinishResetPasswordResult = ssSystem_.RestRecords.JSONST_f49ebf7a28f80c1411af81f260f72632Structure.ToStructure(obj.AttrFinishResetPasswordResult, config);
  }
  return s;
}

public static Func<RC_9817a5747e4b09aa3a6a7eb35ce9f66e, ssSystem_.RestRecords.JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9817a5747e4b09aa3a6a7eb35ce9f66e s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e FromStructure(RC_9817a5747e4b09aa3a6a7eb35ce9f66e s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_9817a5747e4b09aa3a6a7eb35ce9f66e(s, config);
}

}


