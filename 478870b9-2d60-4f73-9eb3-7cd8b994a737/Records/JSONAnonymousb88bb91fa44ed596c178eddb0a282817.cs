using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// EntityAttributeRecord
public class JSONRC_2efffbee03fccc31484e893e007e6c9a : AbstractRESTStructure<RC_2efffbee03fccc31484e893e007e6c9a> {
[JsonProperty("EntityAttribute")]
[JsonPropertyName("EntityAttribute")]
public ssSystem_.RestRecords.JSONENEntityAttributeEntityRecord AttrEntityAttribute;

public JSONRC_2efffbee03fccc31484e893e007e6c9a() { }

public JSONRC_2efffbee03fccc31484e893e007e6c9a (RC_2efffbee03fccc31484e893e007e6c9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntityAttribute = ConvertToRestWithoutDefaults(s.ssENEntityAttribute, new ENEntityAttributeEntityRecord(), ssSystem_.RestRecords.JSONENEntityAttributeEntityRecord.FromStructureDelegate(config));
  } else {
AttrEntityAttribute = ssSystem_.RestRecords.JSONENEntityAttributeEntityRecord.FromStructure(s.ssENEntityAttribute, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_2efffbee03fccc31484e893e007e6c9a, RC_2efffbee03fccc31484e893e007e6c9a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_2efffbee03fccc31484e893e007e6c9a s) => ToStructure(s, config);
}
public static RC_2efffbee03fccc31484e893e007e6c9a ToStructure(ssSystem_.RestRecords.JSONRC_2efffbee03fccc31484e893e007e6c9a obj, IBehaviorsConfiguration config) { 
  RC_2efffbee03fccc31484e893e007e6c9a s = new RC_2efffbee03fccc31484e893e007e6c9a();
  if(obj != null) {
  s.ssENEntityAttribute = ssSystem_.RestRecords.JSONENEntityAttributeEntityRecord.ToStructure(obj.AttrEntityAttribute, config);
  }
  return s;
}

public static Func<RC_2efffbee03fccc31484e893e007e6c9a, ssSystem_.RestRecords.JSONRC_2efffbee03fccc31484e893e007e6c9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2efffbee03fccc31484e893e007e6c9a s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_2efffbee03fccc31484e893e007e6c9a FromStructure(RC_2efffbee03fccc31484e893e007e6c9a s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_2efffbee03fccc31484e893e007e6c9a(s, config);
}

}


