using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUserRegistrationResultRecord
public class JSONRC_8a5dc374bf936f41e6af63789db6143f : AbstractRESTStructure<RC_8a5dc374bf936f41e6af63789db6143f> {
[JsonProperty("FinishUserRegistrationResult")]
[JsonPropertyName("FinishUserRegistrationResult")]
public ssSystem_.RestRecords.JSONST_6ae840a01e1abcf21a5dce7b68bc4d92Structure AttrFinishUserRegistrationResult;

public JSONRC_8a5dc374bf936f41e6af63789db6143f() { }

public JSONRC_8a5dc374bf936f41e6af63789db6143f (RC_8a5dc374bf936f41e6af63789db6143f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishUserRegistrationResult = ConvertToRestWithoutDefaults(s.ssSTFinishUserRegistrationResult, new ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure(), ssSystem_.RestRecords.JSONST_6ae840a01e1abcf21a5dce7b68bc4d92Structure.FromStructureDelegate(config));
  } else {
AttrFinishUserRegistrationResult = ssSystem_.RestRecords.JSONST_6ae840a01e1abcf21a5dce7b68bc4d92Structure.FromStructure(s.ssSTFinishUserRegistrationResult, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_8a5dc374bf936f41e6af63789db6143f, RC_8a5dc374bf936f41e6af63789db6143f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_8a5dc374bf936f41e6af63789db6143f s) => ToStructure(s, config);
}
public static RC_8a5dc374bf936f41e6af63789db6143f ToStructure(ssSystem_.RestRecords.JSONRC_8a5dc374bf936f41e6af63789db6143f obj, IBehaviorsConfiguration config) { 
  RC_8a5dc374bf936f41e6af63789db6143f s = new RC_8a5dc374bf936f41e6af63789db6143f();
  if(obj != null) {
  s.ssSTFinishUserRegistrationResult = ssSystem_.RestRecords.JSONST_6ae840a01e1abcf21a5dce7b68bc4d92Structure.ToStructure(obj.AttrFinishUserRegistrationResult, config);
  }
  return s;
}

public static Func<RC_8a5dc374bf936f41e6af63789db6143f, ssSystem_.RestRecords.JSONRC_8a5dc374bf936f41e6af63789db6143f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a5dc374bf936f41e6af63789db6143f s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_8a5dc374bf936f41e6af63789db6143f FromStructure(RC_8a5dc374bf936f41e6af63789db6143f s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_8a5dc374bf936f41e6af63789db6143f(s, config);
}

}


