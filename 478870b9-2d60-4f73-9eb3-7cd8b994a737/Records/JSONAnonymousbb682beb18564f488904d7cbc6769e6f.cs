using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// EmailRecord
public class JSONRC_c25115a84bc21f80350d8ea6536353ed : AbstractRESTStructure<RC_c25115a84bc21f80350d8ea6536353ed> {
[JsonProperty("Email")]
[JsonPropertyName("Email")]
public ssSystem_.RestRecords.JSONENEmailEntityRecord AttrEmail;

public JSONRC_c25115a84bc21f80350d8ea6536353ed() { }

public JSONRC_c25115a84bc21f80350d8ea6536353ed (RC_c25115a84bc21f80350d8ea6536353ed s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmail = ConvertToRestWithoutDefaults(s.ssENEmail, new ENEmailEntityRecord(), ssSystem_.RestRecords.JSONENEmailEntityRecord.FromStructureDelegate(config));
  } else {
AttrEmail = ssSystem_.RestRecords.JSONENEmailEntityRecord.FromStructure(s.ssENEmail, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_c25115a84bc21f80350d8ea6536353ed, RC_c25115a84bc21f80350d8ea6536353ed> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_c25115a84bc21f80350d8ea6536353ed s) => ToStructure(s, config);
}
public static RC_c25115a84bc21f80350d8ea6536353ed ToStructure(ssSystem_.RestRecords.JSONRC_c25115a84bc21f80350d8ea6536353ed obj, IBehaviorsConfiguration config) { 
  RC_c25115a84bc21f80350d8ea6536353ed s = new RC_c25115a84bc21f80350d8ea6536353ed();
  if(obj != null) {
  s.ssENEmail = ssSystem_.RestRecords.JSONENEmailEntityRecord.ToStructure(obj.AttrEmail, config);
  }
  return s;
}

public static Func<RC_c25115a84bc21f80350d8ea6536353ed, ssSystem_.RestRecords.JSONRC_c25115a84bc21f80350d8ea6536353ed> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c25115a84bc21f80350d8ea6536353ed s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_c25115a84bc21f80350d8ea6536353ed FromStructure(RC_c25115a84bc21f80350d8ea6536353ed s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_c25115a84bc21f80350d8ea6536353ed(s, config);
}

}


