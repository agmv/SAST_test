using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInputDefinitionRecord
public class RESTRC_cbc07de8251245064bd8f80b6b35c7f6 : AbstractRESTStructure<RC_cbc07de8251245064bd8f80b6b35c7f6> {
[JsonProperty("ProcessInputDefinition")]
public ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord AttrProcessInputDefinition;

public RESTRC_cbc07de8251245064bd8f80b6b35c7f6() { }

public RESTRC_cbc07de8251245064bd8f80b6b35c7f6 (RC_cbc07de8251245064bd8f80b6b35c7f6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessInputDefinition = ConvertToRestWithoutDefaults(s.ssENProcessInputDefinition, new ENProcessInputDefinitionEntityRecord(), ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessInputDefinition = ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord.FromStructure(s.ssENProcessInputDefinition, config);
  }
}

public static RC_cbc07de8251245064bd8f80b6b35c7f6 ToStructure(ssSystem_.RestRecords.RESTRC_cbc07de8251245064bd8f80b6b35c7f6 obj) { 
  RC_cbc07de8251245064bd8f80b6b35c7f6 s = new RC_cbc07de8251245064bd8f80b6b35c7f6();
  if(obj != null) {
  s.ssENProcessInputDefinition = ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord.ToStructure(obj.AttrProcessInputDefinition);
  }
  return s;
}

public static Func<RC_cbc07de8251245064bd8f80b6b35c7f6, ssSystem_.RestRecords.RESTRC_cbc07de8251245064bd8f80b6b35c7f6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cbc07de8251245064bd8f80b6b35c7f6 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_cbc07de8251245064bd8f80b6b35c7f6 FromStructure(RC_cbc07de8251245064bd8f80b6b35c7f6 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_cbc07de8251245064bd8f80b6b35c7f6(s, config);
}

}


