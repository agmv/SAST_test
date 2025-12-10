using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListEntity
public class RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord : AbstractRESTStructure<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

public RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord() { }

public RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
  } else {
AttrId = (long?) s.ssId;
  }
}

public static EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord obj) { 
  EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord s = new EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord, ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord FromStructure(EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord(s, config);
}

}


