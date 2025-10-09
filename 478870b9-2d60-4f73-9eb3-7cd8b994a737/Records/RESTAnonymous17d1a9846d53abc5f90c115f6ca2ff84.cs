using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionLanguageRecord
public class RESTRC_eb90da5b34724818e84008409205001c : AbstractRESTStructure<RC_eb90da5b34724818e84008409205001c> {
[JsonProperty("ActivityDefinitionLanguage")]
public ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord AttrActivityDefinitionLanguage;

public RESTRC_eb90da5b34724818e84008409205001c() { }

public RESTRC_eb90da5b34724818e84008409205001c (RC_eb90da5b34724818e84008409205001c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinitionLanguage = ConvertToRestWithoutDefaults(s.ssENActivityDefinitionLanguage, new ENActivityDefinitionLanguageEntityRecord(), ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinitionLanguage = ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord.FromStructure(s.ssENActivityDefinitionLanguage, config);
  }
}

public static RC_eb90da5b34724818e84008409205001c ToStructure(ssSystem_.RestRecords.RESTRC_eb90da5b34724818e84008409205001c obj) { 
  RC_eb90da5b34724818e84008409205001c s = new RC_eb90da5b34724818e84008409205001c();
  if(obj != null) {
  s.ssENActivityDefinitionLanguage = ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord.ToStructure(obj.AttrActivityDefinitionLanguage);
  }
  return s;
}

public static Func<RC_eb90da5b34724818e84008409205001c, ssSystem_.RestRecords.RESTRC_eb90da5b34724818e84008409205001c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eb90da5b34724818e84008409205001c s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_eb90da5b34724818e84008409205001c FromStructure(RC_eb90da5b34724818e84008409205001c s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_eb90da5b34724818e84008409205001c(s, config);
}

}


