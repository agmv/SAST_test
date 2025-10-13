using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutputDefinitionRecord
public class JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 : AbstractRESTStructure<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> {
[JsonProperty("ActivityOutputDefinition")]
[JsonPropertyName("ActivityOutputDefinition")]
public ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord AttrActivityOutputDefinition;

public JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1() { }

public JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityOutputDefinition = ConvertToRestWithoutDefaults(s.ssENActivityOutputDefinition, new ENActivityOutputDefinitionEntityRecord(), ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityOutputDefinition = ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord.FromStructure(s.ssENActivityOutputDefinition, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1, RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s) => ToStructure(s, config);
}
public static RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 ToStructure(ssSystem_.RestRecords.JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 obj, IBehaviorsConfiguration config) { 
  RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s = new RC_8535fa70cf0bfd6fa50f69a53d3b4ae1();
  if(obj != null) {
  s.ssENActivityOutputDefinition = ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord.ToStructure(obj.AttrActivityOutputDefinition, config);
  }
  return s;
}

public static Func<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1, ssSystem_.RestRecords.JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 FromStructure(RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_8535fa70cf0bfd6fa50f69a53d3b4ae1(s, config);
}

}


