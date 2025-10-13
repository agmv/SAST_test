using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutputRecord
public class RESTRC_d5e6f13d187b5006f9f88b20f576700b : AbstractRESTStructure<RC_d5e6f13d187b5006f9f88b20f576700b> {
[JsonProperty("ProcessOutput")]
public ssSystem_.RestRecords.RESTENProcessOutputEntityRecord AttrProcessOutput;

public RESTRC_d5e6f13d187b5006f9f88b20f576700b() { }

public RESTRC_d5e6f13d187b5006f9f88b20f576700b (RC_d5e6f13d187b5006f9f88b20f576700b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessOutput = ConvertToRestWithoutDefaults(s.ssENProcessOutput, new ENProcessOutputEntityRecord(), ssSystem_.RestRecords.RESTENProcessOutputEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessOutput = ssSystem_.RestRecords.RESTENProcessOutputEntityRecord.FromStructure(s.ssENProcessOutput, config);
  }
}

public static RC_d5e6f13d187b5006f9f88b20f576700b ToStructure(ssSystem_.RestRecords.RESTRC_d5e6f13d187b5006f9f88b20f576700b obj) { 
  RC_d5e6f13d187b5006f9f88b20f576700b s = new RC_d5e6f13d187b5006f9f88b20f576700b();
  if(obj != null) {
  s.ssENProcessOutput = ssSystem_.RestRecords.RESTENProcessOutputEntityRecord.ToStructure(obj.AttrProcessOutput);
  }
  return s;
}

public static Func<RC_d5e6f13d187b5006f9f88b20f576700b, ssSystem_.RestRecords.RESTRC_d5e6f13d187b5006f9f88b20f576700b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5e6f13d187b5006f9f88b20f576700b s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_d5e6f13d187b5006f9f88b20f576700b FromStructure(RC_d5e6f13d187b5006f9f88b20f576700b s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_d5e6f13d187b5006f9f88b20f576700b(s, config);
}

}


