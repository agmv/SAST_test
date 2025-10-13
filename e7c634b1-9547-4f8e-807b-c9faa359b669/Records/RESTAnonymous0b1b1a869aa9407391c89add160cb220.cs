using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListGetRecord
public class RESTRC_49344a0c853da358d36b40a428b7e5a5 : AbstractRESTStructure<RC_49344a0c853da358d36b40a428b7e5a5> {
[JsonProperty("SampleListGet")]
public ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord AttrSampleListGet;

public RESTRC_49344a0c853da358d36b40a428b7e5a5() { }

public RESTRC_49344a0c853da358d36b40a428b7e5a5 (RC_49344a0c853da358d36b40a428b7e5a5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSampleListGet = ConvertToRestWithoutDefaults(s.ssENSampleListGet, new EN_80054628bf73dfa0a64914948a216302EntityRecord(), ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord.FromStructureDelegate(config));
  } else {
AttrSampleListGet = ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord.FromStructure(s.ssENSampleListGet, config);
  }
}

public static RC_49344a0c853da358d36b40a428b7e5a5 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_49344a0c853da358d36b40a428b7e5a5 obj) { 
  RC_49344a0c853da358d36b40a428b7e5a5 s = new RC_49344a0c853da358d36b40a428b7e5a5();
  if(obj != null) {
  s.ssENSampleListGet = ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord.ToStructure(obj.AttrSampleListGet);
  }
  return s;
}

public static Func<RC_49344a0c853da358d36b40a428b7e5a5, ssRuntimeDestroyer.RestRecords.RESTRC_49344a0c853da358d36b40a428b7e5a5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_49344a0c853da358d36b40a428b7e5a5 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_49344a0c853da358d36b40a428b7e5a5 FromStructure(RC_49344a0c853da358d36b40a428b7e5a5 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_49344a0c853da358d36b40a428b7e5a5(s, config);
}

}


