using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionLanguageRecord
public class JSONRC_eb90da5b34724818e84008409205001c : AbstractRESTStructure<RC_eb90da5b34724818e84008409205001c> {
[JsonProperty("ActivityDefinitionLanguage")]
[JsonPropertyName("ActivityDefinitionLanguage")]
public ssSystem_.RestRecords.JSONENActivityDefinitionLanguageEntityRecord AttrActivityDefinitionLanguage;

public JSONRC_eb90da5b34724818e84008409205001c() { }

public JSONRC_eb90da5b34724818e84008409205001c (RC_eb90da5b34724818e84008409205001c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinitionLanguage = ConvertToRestWithoutDefaults(s.ssENActivityDefinitionLanguage, new ENActivityDefinitionLanguageEntityRecord(), ssSystem_.RestRecords.JSONENActivityDefinitionLanguageEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinitionLanguage = ssSystem_.RestRecords.JSONENActivityDefinitionLanguageEntityRecord.FromStructure(s.ssENActivityDefinitionLanguage, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_eb90da5b34724818e84008409205001c, RC_eb90da5b34724818e84008409205001c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_eb90da5b34724818e84008409205001c s) => ToStructure(s, config);
}
public static RC_eb90da5b34724818e84008409205001c ToStructure(ssSystem_.RestRecords.JSONRC_eb90da5b34724818e84008409205001c obj, IBehaviorsConfiguration config) { 
  RC_eb90da5b34724818e84008409205001c s = new RC_eb90da5b34724818e84008409205001c();
  if(obj != null) {
  s.ssENActivityDefinitionLanguage = ssSystem_.RestRecords.JSONENActivityDefinitionLanguageEntityRecord.ToStructure(obj.AttrActivityDefinitionLanguage, config);
  }
  return s;
}

public static Func<RC_eb90da5b34724818e84008409205001c, ssSystem_.RestRecords.JSONRC_eb90da5b34724818e84008409205001c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eb90da5b34724818e84008409205001c s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_eb90da5b34724818e84008409205001c FromStructure(RC_eb90da5b34724818e84008409205001c s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_eb90da5b34724818e84008409205001c(s, config);
}

}


