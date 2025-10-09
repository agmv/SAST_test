using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// EntityAttributeRecord
public class RESTRC_2efffbee03fccc31484e893e007e6c9a : AbstractRESTStructure<RC_2efffbee03fccc31484e893e007e6c9a> {
[JsonProperty("EntityAttribute")]
public ssSystem_.RestRecords.RESTENEntityAttributeEntityRecord AttrEntityAttribute;

public RESTRC_2efffbee03fccc31484e893e007e6c9a() { }

public RESTRC_2efffbee03fccc31484e893e007e6c9a (RC_2efffbee03fccc31484e893e007e6c9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntityAttribute = ConvertToRestWithoutDefaults(s.ssENEntityAttribute, new ENEntityAttributeEntityRecord(), ssSystem_.RestRecords.RESTENEntityAttributeEntityRecord.FromStructureDelegate(config));
  } else {
AttrEntityAttribute = ssSystem_.RestRecords.RESTENEntityAttributeEntityRecord.FromStructure(s.ssENEntityAttribute, config);
  }
}

public static RC_2efffbee03fccc31484e893e007e6c9a ToStructure(ssSystem_.RestRecords.RESTRC_2efffbee03fccc31484e893e007e6c9a obj) { 
  RC_2efffbee03fccc31484e893e007e6c9a s = new RC_2efffbee03fccc31484e893e007e6c9a();
  if(obj != null) {
  s.ssENEntityAttribute = ssSystem_.RestRecords.RESTENEntityAttributeEntityRecord.ToStructure(obj.AttrEntityAttribute);
  }
  return s;
}

public static Func<RC_2efffbee03fccc31484e893e007e6c9a, ssSystem_.RestRecords.RESTRC_2efffbee03fccc31484e893e007e6c9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2efffbee03fccc31484e893e007e6c9a s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_2efffbee03fccc31484e893e007e6c9a FromStructure(RC_2efffbee03fccc31484e893e007e6c9a s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_2efffbee03fccc31484e893e007e6c9a(s, config);
}

}


