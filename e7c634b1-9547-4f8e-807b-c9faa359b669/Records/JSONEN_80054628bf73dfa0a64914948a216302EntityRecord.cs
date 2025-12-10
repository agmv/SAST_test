using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListGet
public class JSONEN_80054628bf73dfa0a64914948a216302EntityRecord : AbstractRESTStructure<EN_80054628bf73dfa0a64914948a216302EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

public JSONEN_80054628bf73dfa0a64914948a216302EntityRecord() { }

public JSONEN_80054628bf73dfa0a64914948a216302EntityRecord (EN_80054628bf73dfa0a64914948a216302EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
  } else {
AttrId = (int?) s.ssId;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONEN_80054628bf73dfa0a64914948a216302EntityRecord, EN_80054628bf73dfa0a64914948a216302EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONEN_80054628bf73dfa0a64914948a216302EntityRecord s) => ToStructure(s, config);
}
public static EN_80054628bf73dfa0a64914948a216302EntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONEN_80054628bf73dfa0a64914948a216302EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_80054628bf73dfa0a64914948a216302EntityRecord s = new EN_80054628bf73dfa0a64914948a216302EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  }
  return s;
}

public static Func<EN_80054628bf73dfa0a64914948a216302EntityRecord, ssRuntimeDestroyer.RestRecords.JSONEN_80054628bf73dfa0a64914948a216302EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_80054628bf73dfa0a64914948a216302EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONEN_80054628bf73dfa0a64914948a216302EntityRecord FromStructure(EN_80054628bf73dfa0a64914948a216302EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONEN_80054628bf73dfa0a64914948a216302EntityRecord(s, config);
}

}


