using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UpdateUserResultRecord
public class RESTRC_bd573fb2cb521691dc6a8c4b02eeb054 : AbstractRESTStructure<RC_bd573fb2cb521691dc6a8c4b02eeb054> {
[JsonProperty("UpdateUserResult")]
public ssSystem_.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure AttrUpdateUserResult;

public RESTRC_bd573fb2cb521691dc6a8c4b02eeb054() { }

public RESTRC_bd573fb2cb521691dc6a8c4b02eeb054 (RC_bd573fb2cb521691dc6a8c4b02eeb054 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUpdateUserResult = ConvertToRestWithoutDefaults(s.ssSTUpdateUserResult, new ST_c57cc6bedbdc9e62046393fa735672cfStructure(), ssSystem_.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure.FromStructureDelegate(config));
  } else {
AttrUpdateUserResult = ssSystem_.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure.FromStructure(s.ssSTUpdateUserResult, config);
  }
}

public static RC_bd573fb2cb521691dc6a8c4b02eeb054 ToStructure(ssSystem_.RestRecords.RESTRC_bd573fb2cb521691dc6a8c4b02eeb054 obj) { 
  RC_bd573fb2cb521691dc6a8c4b02eeb054 s = new RC_bd573fb2cb521691dc6a8c4b02eeb054();
  if(obj != null) {
  s.ssSTUpdateUserResult = ssSystem_.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure.ToStructure(obj.AttrUpdateUserResult);
  }
  return s;
}

public static Func<RC_bd573fb2cb521691dc6a8c4b02eeb054, ssSystem_.RestRecords.RESTRC_bd573fb2cb521691dc6a8c4b02eeb054> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bd573fb2cb521691dc6a8c4b02eeb054 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_bd573fb2cb521691dc6a8c4b02eeb054 FromStructure(RC_bd573fb2cb521691dc6a8c4b02eeb054 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_bd573fb2cb521691dc6a8c4b02eeb054(s, config);
}

}


