using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityKindRecord
public class RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 : AbstractRESTStructure<RC_99e7afb0bae555fcf70d1cd06f23ae14> {
[JsonProperty("ActivityKind")]
public ssSystem_.RestRecords.RESTENActivityKindEntityRecord AttrActivityKind;

public RESTRC_99e7afb0bae555fcf70d1cd06f23ae14() { }

public RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 (RC_99e7afb0bae555fcf70d1cd06f23ae14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityKind = ConvertToRestWithoutDefaults(s.ssENActivityKind, new ENActivityKindEntityRecord(), ssSystem_.RestRecords.RESTENActivityKindEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityKind = ssSystem_.RestRecords.RESTENActivityKindEntityRecord.FromStructure(s.ssENActivityKind, config);
  }
}

public static RC_99e7afb0bae555fcf70d1cd06f23ae14 ToStructure(ssSystem_.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 obj) { 
  RC_99e7afb0bae555fcf70d1cd06f23ae14 s = new RC_99e7afb0bae555fcf70d1cd06f23ae14();
  if(obj != null) {
  s.ssENActivityKind = ssSystem_.RestRecords.RESTENActivityKindEntityRecord.ToStructure(obj.AttrActivityKind);
  }
  return s;
}

public static Func<RC_99e7afb0bae555fcf70d1cd06f23ae14, ssSystem_.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_99e7afb0bae555fcf70d1cd06f23ae14 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14 FromStructure(RC_99e7afb0bae555fcf70d1cd06f23ae14 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_99e7afb0bae555fcf70d1cd06f23ae14(s, config);
}

}


