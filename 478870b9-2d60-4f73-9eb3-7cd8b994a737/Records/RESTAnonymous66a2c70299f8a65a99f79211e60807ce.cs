using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutputDefinitionRecord
public class RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 : AbstractRESTStructure<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> {
[JsonProperty("ActivityOutputDefinition")]
public ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord AttrActivityOutputDefinition;

public RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1() { }

public RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityOutputDefinition = ConvertToRestWithoutDefaults(s.ssENActivityOutputDefinition, new ENActivityOutputDefinitionEntityRecord(), ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityOutputDefinition = ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord.FromStructure(s.ssENActivityOutputDefinition, config);
  }
}

public static RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 ToStructure(ssSystem_.RestRecords.RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 obj) { 
  RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s = new RC_8535fa70cf0bfd6fa50f69a53d3b4ae1();
  if(obj != null) {
  s.ssENActivityOutputDefinition = ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord.ToStructure(obj.AttrActivityOutputDefinition);
  }
  return s;
}

public static Func<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1, ssSystem_.RestRecords.RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1 FromStructure(RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_8535fa70cf0bfd6fa50f69a53d3b4ae1(s, config);
}

}


