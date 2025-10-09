using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityStatusRecord
public class RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 : AbstractRESTStructure<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> {
[JsonProperty("ActivityStatus")]
public ssSystem_.RestRecords.RESTENActivityStatusEntityRecord AttrActivityStatus;

public RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4() { }

public RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityStatus = ConvertToRestWithoutDefaults(s.ssENActivityStatus, new ENActivityStatusEntityRecord(), ssSystem_.RestRecords.RESTENActivityStatusEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityStatus = ssSystem_.RestRecords.RESTENActivityStatusEntityRecord.FromStructure(s.ssENActivityStatus, config);
  }
}

public static RC_36a7d48575a55c39ace8b7f6b0cd3ac4 ToStructure(ssSystem_.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 obj) { 
  RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s = new RC_36a7d48575a55c39ace8b7f6b0cd3ac4();
  if(obj != null) {
  s.ssENActivityStatus = ssSystem_.RestRecords.RESTENActivityStatusEntityRecord.ToStructure(obj.AttrActivityStatus);
  }
  return s;
}

public static Func<RC_36a7d48575a55c39ace8b7f6b0cd3ac4, ssSystem_.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 FromStructure(RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4(s, config);
}

}


