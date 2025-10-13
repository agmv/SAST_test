using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutputRecord
public class JSONRC_d5e6f13d187b5006f9f88b20f576700b : AbstractRESTStructure<RC_d5e6f13d187b5006f9f88b20f576700b> {
[JsonProperty("ProcessOutput")]
[JsonPropertyName("ProcessOutput")]
public ssSystem_.RestRecords.JSONENProcessOutputEntityRecord AttrProcessOutput;

public JSONRC_d5e6f13d187b5006f9f88b20f576700b() { }

public JSONRC_d5e6f13d187b5006f9f88b20f576700b (RC_d5e6f13d187b5006f9f88b20f576700b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessOutput = ConvertToRestWithoutDefaults(s.ssENProcessOutput, new ENProcessOutputEntityRecord(), ssSystem_.RestRecords.JSONENProcessOutputEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessOutput = ssSystem_.RestRecords.JSONENProcessOutputEntityRecord.FromStructure(s.ssENProcessOutput, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_d5e6f13d187b5006f9f88b20f576700b, RC_d5e6f13d187b5006f9f88b20f576700b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_d5e6f13d187b5006f9f88b20f576700b s) => ToStructure(s, config);
}
public static RC_d5e6f13d187b5006f9f88b20f576700b ToStructure(ssSystem_.RestRecords.JSONRC_d5e6f13d187b5006f9f88b20f576700b obj, IBehaviorsConfiguration config) { 
  RC_d5e6f13d187b5006f9f88b20f576700b s = new RC_d5e6f13d187b5006f9f88b20f576700b();
  if(obj != null) {
  s.ssENProcessOutput = ssSystem_.RestRecords.JSONENProcessOutputEntityRecord.ToStructure(obj.AttrProcessOutput, config);
  }
  return s;
}

public static Func<RC_d5e6f13d187b5006f9f88b20f576700b, ssSystem_.RestRecords.JSONRC_d5e6f13d187b5006f9f88b20f576700b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5e6f13d187b5006f9f88b20f576700b s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_d5e6f13d187b5006f9f88b20f576700b FromStructure(RC_d5e6f13d187b5006f9f88b20f576700b s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_d5e6f13d187b5006f9f88b20f576700b(s, config);
}

}


