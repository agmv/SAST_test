using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInputDefinitionRecord
public class JSONRC_cbc07de8251245064bd8f80b6b35c7f6 : AbstractRESTStructure<RC_cbc07de8251245064bd8f80b6b35c7f6> {
[JsonProperty("ProcessInputDefinition")]
[JsonPropertyName("ProcessInputDefinition")]
public ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord AttrProcessInputDefinition;

public JSONRC_cbc07de8251245064bd8f80b6b35c7f6() { }

public JSONRC_cbc07de8251245064bd8f80b6b35c7f6 (RC_cbc07de8251245064bd8f80b6b35c7f6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessInputDefinition = ConvertToRestWithoutDefaults(s.ssENProcessInputDefinition, new ENProcessInputDefinitionEntityRecord(), ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessInputDefinition = ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord.FromStructure(s.ssENProcessInputDefinition, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_cbc07de8251245064bd8f80b6b35c7f6, RC_cbc07de8251245064bd8f80b6b35c7f6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_cbc07de8251245064bd8f80b6b35c7f6 s) => ToStructure(s, config);
}
public static RC_cbc07de8251245064bd8f80b6b35c7f6 ToStructure(ssSystem_.RestRecords.JSONRC_cbc07de8251245064bd8f80b6b35c7f6 obj, IBehaviorsConfiguration config) { 
  RC_cbc07de8251245064bd8f80b6b35c7f6 s = new RC_cbc07de8251245064bd8f80b6b35c7f6();
  if(obj != null) {
  s.ssENProcessInputDefinition = ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord.ToStructure(obj.AttrProcessInputDefinition, config);
  }
  return s;
}

public static Func<RC_cbc07de8251245064bd8f80b6b35c7f6, ssSystem_.RestRecords.JSONRC_cbc07de8251245064bd8f80b6b35c7f6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cbc07de8251245064bd8f80b6b35c7f6 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_cbc07de8251245064bd8f80b6b35c7f6 FromStructure(RC_cbc07de8251245064bd8f80b6b35c7f6 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_cbc07de8251245064bd8f80b6b35c7f6(s, config);
}

}


