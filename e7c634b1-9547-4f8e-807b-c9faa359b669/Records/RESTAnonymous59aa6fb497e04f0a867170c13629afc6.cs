using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListEntityRecord
public class RESTRC_f58af668359cdeaaa540e4e6dadabd34 : AbstractRESTStructure<RC_f58af668359cdeaaa540e4e6dadabd34> {
[JsonProperty("SampleListEntity")]
public ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord AttrSampleListEntity;

public RESTRC_f58af668359cdeaaa540e4e6dadabd34() { }

public RESTRC_f58af668359cdeaaa540e4e6dadabd34 (RC_f58af668359cdeaaa540e4e6dadabd34 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSampleListEntity = ConvertToRestWithoutDefaults(s.ssENSampleListEntity, new EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord(), ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord.FromStructureDelegate(config));
  } else {
AttrSampleListEntity = ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord.FromStructure(s.ssENSampleListEntity, config);
  }
}

public static RC_f58af668359cdeaaa540e4e6dadabd34 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_f58af668359cdeaaa540e4e6dadabd34 obj) { 
  RC_f58af668359cdeaaa540e4e6dadabd34 s = new RC_f58af668359cdeaaa540e4e6dadabd34();
  if(obj != null) {
  s.ssENSampleListEntity = ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord.ToStructure(obj.AttrSampleListEntity);
  }
  return s;
}

public static Func<RC_f58af668359cdeaaa540e4e6dadabd34, ssRuntimeDestroyer.RestRecords.RESTRC_f58af668359cdeaaa540e4e6dadabd34> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f58af668359cdeaaa540e4e6dadabd34 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_f58af668359cdeaaa540e4e6dadabd34 FromStructure(RC_f58af668359cdeaaa540e4e6dadabd34 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_f58af668359cdeaaa540e4e6dadabd34(s, config);
}

}


