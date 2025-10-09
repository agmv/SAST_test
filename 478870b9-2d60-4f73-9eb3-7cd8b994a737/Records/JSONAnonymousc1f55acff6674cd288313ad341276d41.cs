using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UpdateUserResultRecord
public class JSONRC_bd573fb2cb521691dc6a8c4b02eeb054 : AbstractRESTStructure<RC_bd573fb2cb521691dc6a8c4b02eeb054> {
[JsonProperty("UpdateUserResult")]
[JsonPropertyName("UpdateUserResult")]
public ssSystem_.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure AttrUpdateUserResult;

public JSONRC_bd573fb2cb521691dc6a8c4b02eeb054() { }

public JSONRC_bd573fb2cb521691dc6a8c4b02eeb054 (RC_bd573fb2cb521691dc6a8c4b02eeb054 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUpdateUserResult = ConvertToRestWithoutDefaults(s.ssSTUpdateUserResult, new ST_c57cc6bedbdc9e62046393fa735672cfStructure(), ssSystem_.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure.FromStructureDelegate(config));
  } else {
AttrUpdateUserResult = ssSystem_.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure.FromStructure(s.ssSTUpdateUserResult, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_bd573fb2cb521691dc6a8c4b02eeb054, RC_bd573fb2cb521691dc6a8c4b02eeb054> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_bd573fb2cb521691dc6a8c4b02eeb054 s) => ToStructure(s, config);
}
public static RC_bd573fb2cb521691dc6a8c4b02eeb054 ToStructure(ssSystem_.RestRecords.JSONRC_bd573fb2cb521691dc6a8c4b02eeb054 obj, IBehaviorsConfiguration config) { 
  RC_bd573fb2cb521691dc6a8c4b02eeb054 s = new RC_bd573fb2cb521691dc6a8c4b02eeb054();
  if(obj != null) {
  s.ssSTUpdateUserResult = ssSystem_.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure.ToStructure(obj.AttrUpdateUserResult, config);
  }
  return s;
}

public static Func<RC_bd573fb2cb521691dc6a8c4b02eeb054, ssSystem_.RestRecords.JSONRC_bd573fb2cb521691dc6a8c4b02eeb054> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bd573fb2cb521691dc6a8c4b02eeb054 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_bd573fb2cb521691dc6a8c4b02eeb054 FromStructure(RC_bd573fb2cb521691dc6a8c4b02eeb054 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_bd573fb2cb521691dc6a8c4b02eeb054(s, config);
}

}


