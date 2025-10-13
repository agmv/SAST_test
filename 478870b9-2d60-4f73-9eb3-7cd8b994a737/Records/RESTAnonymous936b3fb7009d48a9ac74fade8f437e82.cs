using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ApplicationRecord
public class RESTRC_a702e171772a9b89c17e2544ab6d1d29 : AbstractRESTStructure<RC_a702e171772a9b89c17e2544ab6d1d29> {
[JsonProperty("Application")]
public ssSystem_.RestRecords.RESTENApplicationEntityRecord AttrApplication;

public RESTRC_a702e171772a9b89c17e2544ab6d1d29() { }

public RESTRC_a702e171772a9b89c17e2544ab6d1d29 (RC_a702e171772a9b89c17e2544ab6d1d29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplication = ConvertToRestWithoutDefaults(s.ssENApplication, new ENApplicationEntityRecord(), ssSystem_.RestRecords.RESTENApplicationEntityRecord.FromStructureDelegate(config));
  } else {
AttrApplication = ssSystem_.RestRecords.RESTENApplicationEntityRecord.FromStructure(s.ssENApplication, config);
  }
}

public static RC_a702e171772a9b89c17e2544ab6d1d29 ToStructure(ssSystem_.RestRecords.RESTRC_a702e171772a9b89c17e2544ab6d1d29 obj) { 
  RC_a702e171772a9b89c17e2544ab6d1d29 s = new RC_a702e171772a9b89c17e2544ab6d1d29();
  if(obj != null) {
  s.ssENApplication = ssSystem_.RestRecords.RESTENApplicationEntityRecord.ToStructure(obj.AttrApplication);
  }
  return s;
}

public static Func<RC_a702e171772a9b89c17e2544ab6d1d29, ssSystem_.RestRecords.RESTRC_a702e171772a9b89c17e2544ab6d1d29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a702e171772a9b89c17e2544ab6d1d29 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_a702e171772a9b89c17e2544ab6d1d29 FromStructure(RC_a702e171772a9b89c17e2544ab6d1d29 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_a702e171772a9b89c17e2544ab6d1d29(s, config);
}

}


