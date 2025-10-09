using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInputRecord
public class RESTRC_d43fed74d1678e954ae3786a22cd1029 : AbstractRESTStructure<RC_d43fed74d1678e954ae3786a22cd1029> {
[JsonProperty("ProcessInput")]
public ssSystem_.RestRecords.RESTENProcessInputEntityRecord AttrProcessInput;

public RESTRC_d43fed74d1678e954ae3786a22cd1029() { }

public RESTRC_d43fed74d1678e954ae3786a22cd1029 (RC_d43fed74d1678e954ae3786a22cd1029 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessInput = ConvertToRestWithoutDefaults(s.ssENProcessInput, new ENProcessInputEntityRecord(), ssSystem_.RestRecords.RESTENProcessInputEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessInput = ssSystem_.RestRecords.RESTENProcessInputEntityRecord.FromStructure(s.ssENProcessInput, config);
  }
}

public static RC_d43fed74d1678e954ae3786a22cd1029 ToStructure(ssSystem_.RestRecords.RESTRC_d43fed74d1678e954ae3786a22cd1029 obj) { 
  RC_d43fed74d1678e954ae3786a22cd1029 s = new RC_d43fed74d1678e954ae3786a22cd1029();
  if(obj != null) {
  s.ssENProcessInput = ssSystem_.RestRecords.RESTENProcessInputEntityRecord.ToStructure(obj.AttrProcessInput);
  }
  return s;
}

public static Func<RC_d43fed74d1678e954ae3786a22cd1029, ssSystem_.RestRecords.RESTRC_d43fed74d1678e954ae3786a22cd1029> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d43fed74d1678e954ae3786a22cd1029 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_d43fed74d1678e954ae3786a22cd1029 FromStructure(RC_d43fed74d1678e954ae3786a22cd1029 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_d43fed74d1678e954ae3786a22cd1029(s, config);
}

}


