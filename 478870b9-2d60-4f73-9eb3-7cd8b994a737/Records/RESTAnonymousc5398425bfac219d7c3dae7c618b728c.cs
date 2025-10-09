using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionRecord
public class RESTRC_a04f94cfd410c813b8dee156f64b6537 : AbstractRESTStructure<RC_a04f94cfd410c813b8dee156f64b6537> {
[JsonProperty("ActivityDefinition")]
public ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord AttrActivityDefinition;

public RESTRC_a04f94cfd410c813b8dee156f64b6537() { }

public RESTRC_a04f94cfd410c813b8dee156f64b6537 (RC_a04f94cfd410c813b8dee156f64b6537 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinition = ConvertToRestWithoutDefaults(s.ssENActivityDefinition, new ENActivityDefinitionEntityRecord(), ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinition = ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord.FromStructure(s.ssENActivityDefinition, config);
  }
}

public static RC_a04f94cfd410c813b8dee156f64b6537 ToStructure(ssSystem_.RestRecords.RESTRC_a04f94cfd410c813b8dee156f64b6537 obj) { 
  RC_a04f94cfd410c813b8dee156f64b6537 s = new RC_a04f94cfd410c813b8dee156f64b6537();
  if(obj != null) {
  s.ssENActivityDefinition = ssSystem_.RestRecords.RESTENActivityDefinitionEntityRecord.ToStructure(obj.AttrActivityDefinition);
  }
  return s;
}

public static Func<RC_a04f94cfd410c813b8dee156f64b6537, ssSystem_.RestRecords.RESTRC_a04f94cfd410c813b8dee156f64b6537> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a04f94cfd410c813b8dee156f64b6537 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_a04f94cfd410c813b8dee156f64b6537 FromStructure(RC_a04f94cfd410c813b8dee156f64b6537 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_a04f94cfd410c813b8dee156f64b6537(s, config);
}

}


