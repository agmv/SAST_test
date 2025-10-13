using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUserRegistrationFailureReasonRecord
public class RESTRC_3c619bc2cefd7ed268d81977413e1480 : AbstractRESTStructure<RC_3c619bc2cefd7ed268d81977413e1480> {
[JsonProperty("StartUserRegistrationFailureReason")]
public ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure AttrStartUserRegistrationFailureReason;

public RESTRC_3c619bc2cefd7ed268d81977413e1480() { }

public RESTRC_3c619bc2cefd7ed268d81977413e1480 (RC_3c619bc2cefd7ed268d81977413e1480 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUserRegistrationFailureReason = ConvertToRestWithoutDefaults(s.ssSTStartUserRegistrationFailureReason, new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure(), ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure.FromStructureDelegate(config));
  } else {
AttrStartUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure.FromStructure(s.ssSTStartUserRegistrationFailureReason, config);
  }
}

public static RC_3c619bc2cefd7ed268d81977413e1480 ToStructure(ssSystem_.RestRecords.RESTRC_3c619bc2cefd7ed268d81977413e1480 obj) { 
  RC_3c619bc2cefd7ed268d81977413e1480 s = new RC_3c619bc2cefd7ed268d81977413e1480();
  if(obj != null) {
  s.ssSTStartUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_8f28b651568fa9d5ba7b5b342de64a1cStructure.ToStructure(obj.AttrStartUserRegistrationFailureReason);
  }
  return s;
}

public static Func<RC_3c619bc2cefd7ed268d81977413e1480, ssSystem_.RestRecords.RESTRC_3c619bc2cefd7ed268d81977413e1480> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3c619bc2cefd7ed268d81977413e1480 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_3c619bc2cefd7ed268d81977413e1480 FromStructure(RC_3c619bc2cefd7ed268d81977413e1480 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_3c619bc2cefd7ed268d81977413e1480(s, config);
}

}


