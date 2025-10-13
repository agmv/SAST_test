using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinitionLanguageRecord
public class RESTRC_b1f889a35d23518bfa5ab890a96efb52 : AbstractRESTStructure<RC_b1f889a35d23518bfa5ab890a96efb52> {
[JsonProperty("ProcessDefinitionLanguage")]
public ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord AttrProcessDefinitionLanguage;

public RESTRC_b1f889a35d23518bfa5ab890a96efb52() { }

public RESTRC_b1f889a35d23518bfa5ab890a96efb52 (RC_b1f889a35d23518bfa5ab890a96efb52 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessDefinitionLanguage = ConvertToRestWithoutDefaults(s.ssENProcessDefinitionLanguage, new ENProcessDefinitionLanguageEntityRecord(), ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessDefinitionLanguage = ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord.FromStructure(s.ssENProcessDefinitionLanguage, config);
  }
}

public static RC_b1f889a35d23518bfa5ab890a96efb52 ToStructure(ssSystem_.RestRecords.RESTRC_b1f889a35d23518bfa5ab890a96efb52 obj) { 
  RC_b1f889a35d23518bfa5ab890a96efb52 s = new RC_b1f889a35d23518bfa5ab890a96efb52();
  if(obj != null) {
  s.ssENProcessDefinitionLanguage = ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord.ToStructure(obj.AttrProcessDefinitionLanguage);
  }
  return s;
}

public static Func<RC_b1f889a35d23518bfa5ab890a96efb52, ssSystem_.RestRecords.RESTRC_b1f889a35d23518bfa5ab890a96efb52> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1f889a35d23518bfa5ab890a96efb52 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_b1f889a35d23518bfa5ab890a96efb52 FromStructure(RC_b1f889a35d23518bfa5ab890a96efb52 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_b1f889a35d23518bfa5ab890a96efb52(s, config);
}

}


