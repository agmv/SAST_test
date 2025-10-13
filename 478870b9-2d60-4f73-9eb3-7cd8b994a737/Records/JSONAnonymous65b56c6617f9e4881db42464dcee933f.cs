using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutputDefinitionRecord
public class JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 : AbstractRESTStructure<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> {
[JsonProperty("ProcessOutputDefinition")]
[JsonPropertyName("ProcessOutputDefinition")]
public ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord AttrProcessOutputDefinition;

public JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4() { }

public JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 (RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessOutputDefinition = ConvertToRestWithoutDefaults(s.ssENProcessOutputDefinition, new ENProcessOutputDefinitionEntityRecord(), ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessOutputDefinition = ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord.FromStructure(s.ssENProcessOutputDefinition, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4, RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 s) => ToStructure(s, config);
}
public static RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 ToStructure(ssSystem_.RestRecords.JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 obj, IBehaviorsConfiguration config) { 
  RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 s = new RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4();
  if(obj != null) {
  s.ssENProcessOutputDefinition = ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord.ToStructure(obj.AttrProcessOutputDefinition, config);
  }
  return s;
}

public static Func<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4, ssSystem_.RestRecords.JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 FromStructure(RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4(s, config);
}

}


