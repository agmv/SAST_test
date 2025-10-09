using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityInstanceRecord
public class RESTRC_880f0b08a77c1575f19f408e1fddc8c6 : AbstractRESTStructure<RC_880f0b08a77c1575f19f408e1fddc8c6> {
[JsonProperty("HumanActivityInstance")]
public ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord AttrHumanActivityInstance;

public RESTRC_880f0b08a77c1575f19f408e1fddc8c6() { }

public RESTRC_880f0b08a77c1575f19f408e1fddc8c6 (RC_880f0b08a77c1575f19f408e1fddc8c6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHumanActivityInstance = ConvertToRestWithoutDefaults(s.ssENHumanActivityInstance, new ENHumanActivityInstanceEntityRecord(), ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord.FromStructureDelegate(config));
  } else {
AttrHumanActivityInstance = ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord.FromStructure(s.ssENHumanActivityInstance, config);
  }
}

public static RC_880f0b08a77c1575f19f408e1fddc8c6 ToStructure(ssSystem_.RestRecords.RESTRC_880f0b08a77c1575f19f408e1fddc8c6 obj) { 
  RC_880f0b08a77c1575f19f408e1fddc8c6 s = new RC_880f0b08a77c1575f19f408e1fddc8c6();
  if(obj != null) {
  s.ssENHumanActivityInstance = ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord.ToStructure(obj.AttrHumanActivityInstance);
  }
  return s;
}

public static Func<RC_880f0b08a77c1575f19f408e1fddc8c6, ssSystem_.RestRecords.RESTRC_880f0b08a77c1575f19f408e1fddc8c6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_880f0b08a77c1575f19f408e1fddc8c6 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_880f0b08a77c1575f19f408e1fddc8c6 FromStructure(RC_880f0b08a77c1575f19f408e1fddc8c6 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_880f0b08a77c1575f19f408e1fddc8c6(s, config);
}

}


