using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Employee
public class JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord : AbstractRESTStructure<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Age")]
[JsonPropertyName("Age")]
public string AttrAge;

public JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord() { }

public JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrAge = ConvertToRestWithoutDefaults(s.ssAge, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrAge = s.ssAge;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s) => ToStructure(s, config);
}
public static EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s = new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssAge = obj.AttrAge == null ? "" : obj.AttrAge;
  }
  return s;
}

public static Func<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord FromStructure(EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord(s, config);
}

}


