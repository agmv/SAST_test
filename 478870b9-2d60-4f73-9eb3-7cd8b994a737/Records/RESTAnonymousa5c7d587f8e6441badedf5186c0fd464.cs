using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// UserRecord
public class RESTRC_ced013358a82a813f1d9a5108f17ce79 : AbstractRESTStructure<RC_ced013358a82a813f1d9a5108f17ce79> {
[JsonProperty("User")]
public ssSystem_.RestRecords.RESTENUserEntityRecord AttrUser;

public RESTRC_ced013358a82a813f1d9a5108f17ce79() { }

public RESTRC_ced013358a82a813f1d9a5108f17ce79 (RC_ced013358a82a813f1d9a5108f17ce79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssSystem_.RestRecords.RESTENUserEntityRecord.FromStructureDelegate(config));
  } else {
AttrUser = ssSystem_.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
  }
}

public static RC_ced013358a82a813f1d9a5108f17ce79 ToStructure(ssSystem_.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79 obj) { 
  RC_ced013358a82a813f1d9a5108f17ce79 s = new RC_ced013358a82a813f1d9a5108f17ce79();
  if(obj != null) {
  s.ssENUser = ssSystem_.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  }
  return s;
}

public static Func<RC_ced013358a82a813f1d9a5108f17ce79, ssSystem_.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ced013358a82a813f1d9a5108f17ce79 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79 FromStructure(RC_ced013358a82a813f1d9a5108f17ce79 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79(s, config);
}

}


