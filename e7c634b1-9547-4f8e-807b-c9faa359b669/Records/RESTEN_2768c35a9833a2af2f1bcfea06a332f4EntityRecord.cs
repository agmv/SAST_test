using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Employee
public class RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord : AbstractRESTStructure<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Age")]
public string AttrAge;

public RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord() { }

public RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord obj) { 
  EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s = new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssAge = obj.AttrAge == null ? "" : obj.AttrAge;
  }
  return s;
}

public static Func<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord FromStructure(EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTEN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord(s, config);
}

}


