using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInputRecord
public class JSONRC_d43fed74d1678e954ae3786a22cd1029 : AbstractRESTStructure<RC_d43fed74d1678e954ae3786a22cd1029> {
[JsonProperty("ProcessInput")]
[JsonPropertyName("ProcessInput")]
public ssSystem_.RestRecords.JSONENProcessInputEntityRecord AttrProcessInput;

public JSONRC_d43fed74d1678e954ae3786a22cd1029() { }

public JSONRC_d43fed74d1678e954ae3786a22cd1029 (RC_d43fed74d1678e954ae3786a22cd1029 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessInput = ConvertToRestWithoutDefaults(s.ssENProcessInput, new ENProcessInputEntityRecord(), ssSystem_.RestRecords.JSONENProcessInputEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessInput = ssSystem_.RestRecords.JSONENProcessInputEntityRecord.FromStructure(s.ssENProcessInput, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_d43fed74d1678e954ae3786a22cd1029, RC_d43fed74d1678e954ae3786a22cd1029> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_d43fed74d1678e954ae3786a22cd1029 s) => ToStructure(s, config);
}
public static RC_d43fed74d1678e954ae3786a22cd1029 ToStructure(ssSystem_.RestRecords.JSONRC_d43fed74d1678e954ae3786a22cd1029 obj, IBehaviorsConfiguration config) { 
  RC_d43fed74d1678e954ae3786a22cd1029 s = new RC_d43fed74d1678e954ae3786a22cd1029();
  if(obj != null) {
  s.ssENProcessInput = ssSystem_.RestRecords.JSONENProcessInputEntityRecord.ToStructure(obj.AttrProcessInput, config);
  }
  return s;
}

public static Func<RC_d43fed74d1678e954ae3786a22cd1029, ssSystem_.RestRecords.JSONRC_d43fed74d1678e954ae3786a22cd1029> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d43fed74d1678e954ae3786a22cd1029 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_d43fed74d1678e954ae3786a22cd1029 FromStructure(RC_d43fed74d1678e954ae3786a22cd1029 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_d43fed74d1678e954ae3786a22cd1029(s, config);
}

}


