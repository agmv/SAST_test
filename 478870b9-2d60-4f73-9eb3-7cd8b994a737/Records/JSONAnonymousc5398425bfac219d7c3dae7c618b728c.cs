using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionRecord
public class JSONRC_a04f94cfd410c813b8dee156f64b6537 : AbstractRESTStructure<RC_a04f94cfd410c813b8dee156f64b6537> {
[JsonProperty("ActivityDefinition")]
[JsonPropertyName("ActivityDefinition")]
public ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord AttrActivityDefinition;

public JSONRC_a04f94cfd410c813b8dee156f64b6537() { }

public JSONRC_a04f94cfd410c813b8dee156f64b6537 (RC_a04f94cfd410c813b8dee156f64b6537 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinition = ConvertToRestWithoutDefaults(s.ssENActivityDefinition, new ENActivityDefinitionEntityRecord(), ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinition = ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord.FromStructure(s.ssENActivityDefinition, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_a04f94cfd410c813b8dee156f64b6537, RC_a04f94cfd410c813b8dee156f64b6537> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_a04f94cfd410c813b8dee156f64b6537 s) => ToStructure(s, config);
}
public static RC_a04f94cfd410c813b8dee156f64b6537 ToStructure(ssSystem_.RestRecords.JSONRC_a04f94cfd410c813b8dee156f64b6537 obj, IBehaviorsConfiguration config) { 
  RC_a04f94cfd410c813b8dee156f64b6537 s = new RC_a04f94cfd410c813b8dee156f64b6537();
  if(obj != null) {
  s.ssENActivityDefinition = ssSystem_.RestRecords.JSONENActivityDefinitionEntityRecord.ToStructure(obj.AttrActivityDefinition, config);
  }
  return s;
}

public static Func<RC_a04f94cfd410c813b8dee156f64b6537, ssSystem_.RestRecords.JSONRC_a04f94cfd410c813b8dee156f64b6537> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a04f94cfd410c813b8dee156f64b6537 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_a04f94cfd410c813b8dee156f64b6537 FromStructure(RC_a04f94cfd410c813b8dee156f64b6537 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_a04f94cfd410c813b8dee156f64b6537(s, config);
}

}


