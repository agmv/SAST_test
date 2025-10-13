using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ApplicationRecord
public class JSONRC_a702e171772a9b89c17e2544ab6d1d29 : AbstractRESTStructure<RC_a702e171772a9b89c17e2544ab6d1d29> {
[JsonProperty("Application")]
[JsonPropertyName("Application")]
public ssSystem_.RestRecords.JSONENApplicationEntityRecord AttrApplication;

public JSONRC_a702e171772a9b89c17e2544ab6d1d29() { }

public JSONRC_a702e171772a9b89c17e2544ab6d1d29 (RC_a702e171772a9b89c17e2544ab6d1d29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplication = ConvertToRestWithoutDefaults(s.ssENApplication, new ENApplicationEntityRecord(), ssSystem_.RestRecords.JSONENApplicationEntityRecord.FromStructureDelegate(config));
  } else {
AttrApplication = ssSystem_.RestRecords.JSONENApplicationEntityRecord.FromStructure(s.ssENApplication, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_a702e171772a9b89c17e2544ab6d1d29, RC_a702e171772a9b89c17e2544ab6d1d29> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_a702e171772a9b89c17e2544ab6d1d29 s) => ToStructure(s, config);
}
public static RC_a702e171772a9b89c17e2544ab6d1d29 ToStructure(ssSystem_.RestRecords.JSONRC_a702e171772a9b89c17e2544ab6d1d29 obj, IBehaviorsConfiguration config) { 
  RC_a702e171772a9b89c17e2544ab6d1d29 s = new RC_a702e171772a9b89c17e2544ab6d1d29();
  if(obj != null) {
  s.ssENApplication = ssSystem_.RestRecords.JSONENApplicationEntityRecord.ToStructure(obj.AttrApplication, config);
  }
  return s;
}

public static Func<RC_a702e171772a9b89c17e2544ab6d1d29, ssSystem_.RestRecords.JSONRC_a702e171772a9b89c17e2544ab6d1d29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a702e171772a9b89c17e2544ab6d1d29 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_a702e171772a9b89c17e2544ab6d1d29 FromStructure(RC_a702e171772a9b89c17e2544ab6d1d29 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_a702e171772a9b89c17e2544ab6d1d29(s, config);
}

}


