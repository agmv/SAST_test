using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListGet
public class RESTEN_80054628bf73dfa0a64914948a216302EntityRecord : AbstractRESTStructure<EN_80054628bf73dfa0a64914948a216302EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

public RESTEN_80054628bf73dfa0a64914948a216302EntityRecord() { }

public RESTEN_80054628bf73dfa0a64914948a216302EntityRecord (EN_80054628bf73dfa0a64914948a216302EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
  } else {
AttrId = (int?) s.ssId;
  }
}

public static EN_80054628bf73dfa0a64914948a216302EntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord obj) { 
  EN_80054628bf73dfa0a64914948a216302EntityRecord s = new EN_80054628bf73dfa0a64914948a216302EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  }
  return s;
}

public static Func<EN_80054628bf73dfa0a64914948a216302EntityRecord, ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_80054628bf73dfa0a64914948a216302EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord FromStructure(EN_80054628bf73dfa0a64914948a216302EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTEN_80054628bf73dfa0a64914948a216302EntityRecord(s, config);
}

}


