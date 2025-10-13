using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityInstanceRecord
public class JSONRC_880f0b08a77c1575f19f408e1fddc8c6 : AbstractRESTStructure<RC_880f0b08a77c1575f19f408e1fddc8c6> {
[JsonProperty("HumanActivityInstance")]
[JsonPropertyName("HumanActivityInstance")]
public ssSystem_.RestRecords.JSONENHumanActivityInstanceEntityRecord AttrHumanActivityInstance;

public JSONRC_880f0b08a77c1575f19f408e1fddc8c6() { }

public JSONRC_880f0b08a77c1575f19f408e1fddc8c6 (RC_880f0b08a77c1575f19f408e1fddc8c6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHumanActivityInstance = ConvertToRestWithoutDefaults(s.ssENHumanActivityInstance, new ENHumanActivityInstanceEntityRecord(), ssSystem_.RestRecords.JSONENHumanActivityInstanceEntityRecord.FromStructureDelegate(config));
  } else {
AttrHumanActivityInstance = ssSystem_.RestRecords.JSONENHumanActivityInstanceEntityRecord.FromStructure(s.ssENHumanActivityInstance, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_880f0b08a77c1575f19f408e1fddc8c6, RC_880f0b08a77c1575f19f408e1fddc8c6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_880f0b08a77c1575f19f408e1fddc8c6 s) => ToStructure(s, config);
}
public static RC_880f0b08a77c1575f19f408e1fddc8c6 ToStructure(ssSystem_.RestRecords.JSONRC_880f0b08a77c1575f19f408e1fddc8c6 obj, IBehaviorsConfiguration config) { 
  RC_880f0b08a77c1575f19f408e1fddc8c6 s = new RC_880f0b08a77c1575f19f408e1fddc8c6();
  if(obj != null) {
  s.ssENHumanActivityInstance = ssSystem_.RestRecords.JSONENHumanActivityInstanceEntityRecord.ToStructure(obj.AttrHumanActivityInstance, config);
  }
  return s;
}

public static Func<RC_880f0b08a77c1575f19f408e1fddc8c6, ssSystem_.RestRecords.JSONRC_880f0b08a77c1575f19f408e1fddc8c6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_880f0b08a77c1575f19f408e1fddc8c6 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_880f0b08a77c1575f19f408e1fddc8c6 FromStructure(RC_880f0b08a77c1575f19f408e1fddc8c6 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_880f0b08a77c1575f19f408e1fddc8c6(s, config);
}

}


