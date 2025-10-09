using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityInstanceRecord
public class RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2 : AbstractRESTStructure<RC_faf38c2d2aeee71f293ad23cd32fa7e2> {
[JsonProperty("ActivityInstance")]
public ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord AttrActivityInstance;

public RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2() { }

public RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2 (RC_faf38c2d2aeee71f293ad23cd32fa7e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityInstance = ConvertToRestWithoutDefaults(s.ssENActivityInstance, new ENActivityInstanceEntityRecord(), ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityInstance = ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord.FromStructure(s.ssENActivityInstance, config);
  }
}

public static RC_faf38c2d2aeee71f293ad23cd32fa7e2 ToStructure(ssSystem_.RestRecords.RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2 obj) { 
  RC_faf38c2d2aeee71f293ad23cd32fa7e2 s = new RC_faf38c2d2aeee71f293ad23cd32fa7e2();
  if(obj != null) {
  s.ssENActivityInstance = ssSystem_.RestRecords.RESTENActivityInstanceEntityRecord.ToStructure(obj.AttrActivityInstance);
  }
  return s;
}

public static Func<RC_faf38c2d2aeee71f293ad23cd32fa7e2, ssSystem_.RestRecords.RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_faf38c2d2aeee71f293ad23cd32fa7e2 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2 FromStructure(RC_faf38c2d2aeee71f293ad23cd32fa7e2 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_faf38c2d2aeee71f293ad23cd32fa7e2(s, config);
}

}


