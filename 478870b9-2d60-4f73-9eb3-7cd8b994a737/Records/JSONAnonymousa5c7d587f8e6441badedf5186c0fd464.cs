using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserRecord
public class JSONRC_ced013358a82a813f1d9a5108f17ce79 : AbstractRESTStructure<RC_ced013358a82a813f1d9a5108f17ce79> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssSystem_.RestRecords.JSONENUserEntityRecord AttrUser;

public JSONRC_ced013358a82a813f1d9a5108f17ce79() { }

public JSONRC_ced013358a82a813f1d9a5108f17ce79 (RC_ced013358a82a813f1d9a5108f17ce79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssSystem_.RestRecords.JSONENUserEntityRecord.FromStructureDelegate(config));
  } else {
AttrUser = ssSystem_.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_ced013358a82a813f1d9a5108f17ce79, RC_ced013358a82a813f1d9a5108f17ce79> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_ced013358a82a813f1d9a5108f17ce79 s) => ToStructure(s, config);
}
public static RC_ced013358a82a813f1d9a5108f17ce79 ToStructure(ssSystem_.RestRecords.JSONRC_ced013358a82a813f1d9a5108f17ce79 obj, IBehaviorsConfiguration config) { 
  RC_ced013358a82a813f1d9a5108f17ce79 s = new RC_ced013358a82a813f1d9a5108f17ce79();
  if(obj != null) {
  s.ssENUser = ssSystem_.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  }
  return s;
}

public static Func<RC_ced013358a82a813f1d9a5108f17ce79, ssSystem_.RestRecords.JSONRC_ced013358a82a813f1d9a5108f17ce79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ced013358a82a813f1d9a5108f17ce79 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_ced013358a82a813f1d9a5108f17ce79 FromStructure(RC_ced013358a82a813f1d9a5108f17ce79 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_ced013358a82a813f1d9a5108f17ce79(s, config);
}

}


