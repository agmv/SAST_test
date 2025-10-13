using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinitionRecord
public class RESTRC_80c865ccf1b0df95391817b0ddc45e18 : AbstractRESTStructure<RC_80c865ccf1b0df95391817b0ddc45e18> {
[JsonProperty("ProcessDefinition")]
public ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord AttrProcessDefinition;

public RESTRC_80c865ccf1b0df95391817b0ddc45e18() { }

public RESTRC_80c865ccf1b0df95391817b0ddc45e18 (RC_80c865ccf1b0df95391817b0ddc45e18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessDefinition = ConvertToRestWithoutDefaults(s.ssENProcessDefinition, new ENProcessDefinitionEntityRecord(), ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessDefinition = ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord.FromStructure(s.ssENProcessDefinition, config);
  }
}

public static RC_80c865ccf1b0df95391817b0ddc45e18 ToStructure(ssSystem_.RestRecords.RESTRC_80c865ccf1b0df95391817b0ddc45e18 obj) { 
  RC_80c865ccf1b0df95391817b0ddc45e18 s = new RC_80c865ccf1b0df95391817b0ddc45e18();
  if(obj != null) {
  s.ssENProcessDefinition = ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord.ToStructure(obj.AttrProcessDefinition);
  }
  return s;
}

public static Func<RC_80c865ccf1b0df95391817b0ddc45e18, ssSystem_.RestRecords.RESTRC_80c865ccf1b0df95391817b0ddc45e18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80c865ccf1b0df95391817b0ddc45e18 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_80c865ccf1b0df95391817b0ddc45e18 FromStructure(RC_80c865ccf1b0df95391817b0ddc45e18 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_80c865ccf1b0df95391817b0ddc45e18(s, config);
}

}


