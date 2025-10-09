using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityStatusRecord
public class JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 : AbstractRESTStructure<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> {
[JsonProperty("ActivityStatus")]
[JsonPropertyName("ActivityStatus")]
public ssSystem_.RestRecords.JSONENActivityStatusEntityRecord AttrActivityStatus;

public JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4() { }

public JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityStatus = ConvertToRestWithoutDefaults(s.ssENActivityStatus, new ENActivityStatusEntityRecord(), ssSystem_.RestRecords.JSONENActivityStatusEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityStatus = ssSystem_.RestRecords.JSONENActivityStatusEntityRecord.FromStructure(s.ssENActivityStatus, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4, RC_36a7d48575a55c39ace8b7f6b0cd3ac4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 s) => ToStructure(s, config);
}
public static RC_36a7d48575a55c39ace8b7f6b0cd3ac4 ToStructure(ssSystem_.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 obj, IBehaviorsConfiguration config) { 
  RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s = new RC_36a7d48575a55c39ace8b7f6b0cd3ac4();
  if(obj != null) {
  s.ssENActivityStatus = ssSystem_.RestRecords.JSONENActivityStatusEntityRecord.ToStructure(obj.AttrActivityStatus, config);
  }
  return s;
}

public static Func<RC_36a7d48575a55c39ace8b7f6b0cd3ac4, ssSystem_.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 FromStructure(RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4(s, config);
}

}


