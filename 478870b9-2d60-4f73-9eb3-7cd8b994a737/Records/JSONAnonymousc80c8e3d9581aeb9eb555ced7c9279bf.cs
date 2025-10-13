using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinitionRecord
public class JSONRC_80c865ccf1b0df95391817b0ddc45e18 : AbstractRESTStructure<RC_80c865ccf1b0df95391817b0ddc45e18> {
[JsonProperty("ProcessDefinition")]
[JsonPropertyName("ProcessDefinition")]
public ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord AttrProcessDefinition;

public JSONRC_80c865ccf1b0df95391817b0ddc45e18() { }

public JSONRC_80c865ccf1b0df95391817b0ddc45e18 (RC_80c865ccf1b0df95391817b0ddc45e18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessDefinition = ConvertToRestWithoutDefaults(s.ssENProcessDefinition, new ENProcessDefinitionEntityRecord(), ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessDefinition = ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord.FromStructure(s.ssENProcessDefinition, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_80c865ccf1b0df95391817b0ddc45e18, RC_80c865ccf1b0df95391817b0ddc45e18> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_80c865ccf1b0df95391817b0ddc45e18 s) => ToStructure(s, config);
}
public static RC_80c865ccf1b0df95391817b0ddc45e18 ToStructure(ssSystem_.RestRecords.JSONRC_80c865ccf1b0df95391817b0ddc45e18 obj, IBehaviorsConfiguration config) { 
  RC_80c865ccf1b0df95391817b0ddc45e18 s = new RC_80c865ccf1b0df95391817b0ddc45e18();
  if(obj != null) {
  s.ssENProcessDefinition = ssSystem_.RestRecords.JSONENProcessDefinitionEntityRecord.ToStructure(obj.AttrProcessDefinition, config);
  }
  return s;
}

public static Func<RC_80c865ccf1b0df95391817b0ddc45e18, ssSystem_.RestRecords.JSONRC_80c865ccf1b0df95391817b0ddc45e18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80c865ccf1b0df95391817b0ddc45e18 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_80c865ccf1b0df95391817b0ddc45e18 FromStructure(RC_80c865ccf1b0df95391817b0ddc45e18 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_80c865ccf1b0df95391817b0ddc45e18(s, config);
}

}


