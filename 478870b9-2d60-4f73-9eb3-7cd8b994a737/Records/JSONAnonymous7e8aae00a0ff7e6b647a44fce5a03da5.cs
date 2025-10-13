using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityInstanceRecord
public class JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2 : AbstractRESTStructure<RC_faf38c2d2aeee71f293ad23cd32fa7e2> {
[JsonProperty("ActivityInstance")]
[JsonPropertyName("ActivityInstance")]
public ssSystem_.RestRecords.JSONENActivityInstanceEntityRecord AttrActivityInstance;

public JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2() { }

public JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2 (RC_faf38c2d2aeee71f293ad23cd32fa7e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityInstance = ConvertToRestWithoutDefaults(s.ssENActivityInstance, new ENActivityInstanceEntityRecord(), ssSystem_.RestRecords.JSONENActivityInstanceEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityInstance = ssSystem_.RestRecords.JSONENActivityInstanceEntityRecord.FromStructure(s.ssENActivityInstance, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2, RC_faf38c2d2aeee71f293ad23cd32fa7e2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2 s) => ToStructure(s, config);
}
public static RC_faf38c2d2aeee71f293ad23cd32fa7e2 ToStructure(ssSystem_.RestRecords.JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2 obj, IBehaviorsConfiguration config) { 
  RC_faf38c2d2aeee71f293ad23cd32fa7e2 s = new RC_faf38c2d2aeee71f293ad23cd32fa7e2();
  if(obj != null) {
  s.ssENActivityInstance = ssSystem_.RestRecords.JSONENActivityInstanceEntityRecord.ToStructure(obj.AttrActivityInstance, config);
  }
  return s;
}

public static Func<RC_faf38c2d2aeee71f293ad23cd32fa7e2, ssSystem_.RestRecords.JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_faf38c2d2aeee71f293ad23cd32fa7e2 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2 FromStructure(RC_faf38c2d2aeee71f293ad23cd32fa7e2 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_faf38c2d2aeee71f293ad23cd32fa7e2(s, config);
}

}


