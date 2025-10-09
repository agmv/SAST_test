using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinitionLanguageRecord
public class JSONRC_b1f889a35d23518bfa5ab890a96efb52 : AbstractRESTStructure<RC_b1f889a35d23518bfa5ab890a96efb52> {
[JsonProperty("ProcessDefinitionLanguage")]
[JsonPropertyName("ProcessDefinitionLanguage")]
public ssSystem_.RestRecords.JSONENProcessDefinitionLanguageEntityRecord AttrProcessDefinitionLanguage;

public JSONRC_b1f889a35d23518bfa5ab890a96efb52() { }

public JSONRC_b1f889a35d23518bfa5ab890a96efb52 (RC_b1f889a35d23518bfa5ab890a96efb52 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessDefinitionLanguage = ConvertToRestWithoutDefaults(s.ssENProcessDefinitionLanguage, new ENProcessDefinitionLanguageEntityRecord(), ssSystem_.RestRecords.JSONENProcessDefinitionLanguageEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessDefinitionLanguage = ssSystem_.RestRecords.JSONENProcessDefinitionLanguageEntityRecord.FromStructure(s.ssENProcessDefinitionLanguage, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_b1f889a35d23518bfa5ab890a96efb52, RC_b1f889a35d23518bfa5ab890a96efb52> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_b1f889a35d23518bfa5ab890a96efb52 s) => ToStructure(s, config);
}
public static RC_b1f889a35d23518bfa5ab890a96efb52 ToStructure(ssSystem_.RestRecords.JSONRC_b1f889a35d23518bfa5ab890a96efb52 obj, IBehaviorsConfiguration config) { 
  RC_b1f889a35d23518bfa5ab890a96efb52 s = new RC_b1f889a35d23518bfa5ab890a96efb52();
  if(obj != null) {
  s.ssENProcessDefinitionLanguage = ssSystem_.RestRecords.JSONENProcessDefinitionLanguageEntityRecord.ToStructure(obj.AttrProcessDefinitionLanguage, config);
  }
  return s;
}

public static Func<RC_b1f889a35d23518bfa5ab890a96efb52, ssSystem_.RestRecords.JSONRC_b1f889a35d23518bfa5ab890a96efb52> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1f889a35d23518bfa5ab890a96efb52 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_b1f889a35d23518bfa5ab890a96efb52 FromStructure(RC_b1f889a35d23518bfa5ab890a96efb52 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_b1f889a35d23518bfa5ab890a96efb52(s, config);
}

}


