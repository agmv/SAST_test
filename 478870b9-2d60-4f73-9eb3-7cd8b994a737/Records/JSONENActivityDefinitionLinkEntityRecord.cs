using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionLink
public class JSONENActivityDefinitionLinkEntityRecord : AbstractRESTStructure<ENActivityDefinitionLinkEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("SourceActivityDefinitionId")]
[JsonPropertyName("SourceActivityDefinitionId")]
public int? AttrSourceActivityDefinitionId;

[JsonProperty("TargetActivityDefinitionId")]
[JsonPropertyName("TargetActivityDefinitionId")]
public int? AttrTargetActivityDefinitionId;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("Outcome")]
[JsonPropertyName("Outcome")]
public string AttrOutcome;

public JSONENActivityDefinitionLinkEntityRecord() { }

public JSONENActivityDefinitionLinkEntityRecord (ENActivityDefinitionLinkEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrSourceActivityDefinitionId = (int?) s.ssSourceActivityDefinitionId;
AttrTargetActivityDefinitionId = (int?) s.ssTargetActivityDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrOutcome = ConvertToRestWithoutDefaults(s.ssOutcome, "");
  } else {
AttrId = s.ssId;
AttrSourceActivityDefinitionId = (int?) s.ssSourceActivityDefinitionId;
AttrTargetActivityDefinitionId = (int?) s.ssTargetActivityDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrOutcome = s.ssOutcome;
  }
}

public static Func<ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord, ENActivityDefinitionLinkEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord s) => ToStructure(s, config);
}
public static ENActivityDefinitionLinkEntityRecord ToStructure(ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityDefinitionLinkEntityRecord s = new ENActivityDefinitionLinkEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssSourceActivityDefinitionId = obj.AttrSourceActivityDefinitionId == null ? 0 : obj.AttrSourceActivityDefinitionId.Value;
  s.ssTargetActivityDefinitionId = obj.AttrTargetActivityDefinitionId == null ? 0 : obj.AttrTargetActivityDefinitionId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssOutcome = obj.AttrOutcome == null ? "" : obj.AttrOutcome;
  }
  return s;
}

public static Func<ENActivityDefinitionLinkEntityRecord, ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionLinkEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord FromStructure(ENActivityDefinitionLinkEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord(s, config);
}

}


