using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUserRegistrationFailureReasonRecord
public class JSONRC_3c619bc2cefd7ed268d81977413e1480 : AbstractRESTStructure<RC_3c619bc2cefd7ed268d81977413e1480> {
[JsonProperty("StartUserRegistrationFailureReason")]
[JsonPropertyName("StartUserRegistrationFailureReason")]
public ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure AttrStartUserRegistrationFailureReason;

public JSONRC_3c619bc2cefd7ed268d81977413e1480() { }

public JSONRC_3c619bc2cefd7ed268d81977413e1480 (RC_3c619bc2cefd7ed268d81977413e1480 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUserRegistrationFailureReason = ConvertToRestWithoutDefaults(s.ssSTStartUserRegistrationFailureReason, new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure(), ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure.FromStructureDelegate(config));
  } else {
AttrStartUserRegistrationFailureReason = ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure.FromStructure(s.ssSTStartUserRegistrationFailureReason, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_3c619bc2cefd7ed268d81977413e1480, RC_3c619bc2cefd7ed268d81977413e1480> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_3c619bc2cefd7ed268d81977413e1480 s) => ToStructure(s, config);
}
public static RC_3c619bc2cefd7ed268d81977413e1480 ToStructure(ssSystem_.RestRecords.JSONRC_3c619bc2cefd7ed268d81977413e1480 obj, IBehaviorsConfiguration config) { 
  RC_3c619bc2cefd7ed268d81977413e1480 s = new RC_3c619bc2cefd7ed268d81977413e1480();
  if(obj != null) {
  s.ssSTStartUserRegistrationFailureReason = ssSystem_.RestRecords.JSONST_8f28b651568fa9d5ba7b5b342de64a1cStructure.ToStructure(obj.AttrStartUserRegistrationFailureReason, config);
  }
  return s;
}

public static Func<RC_3c619bc2cefd7ed268d81977413e1480, ssSystem_.RestRecords.JSONRC_3c619bc2cefd7ed268d81977413e1480> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3c619bc2cefd7ed268d81977413e1480 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_3c619bc2cefd7ed268d81977413e1480 FromStructure(RC_3c619bc2cefd7ed268d81977413e1480 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_3c619bc2cefd7ed268d81977413e1480(s, config);
}

}


