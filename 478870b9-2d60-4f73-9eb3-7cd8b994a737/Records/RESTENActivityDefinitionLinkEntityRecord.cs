using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionLink
public class RESTENActivityDefinitionLinkEntityRecord : AbstractRESTStructure<ENActivityDefinitionLinkEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("SourceActivityDefinitionId")]
public int? AttrSourceActivityDefinitionId;

[JsonProperty("TargetActivityDefinitionId")]
public int? AttrTargetActivityDefinitionId;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("Outcome")]
public string AttrOutcome;

public RESTENActivityDefinitionLinkEntityRecord() { }

public RESTENActivityDefinitionLinkEntityRecord (ENActivityDefinitionLinkEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENActivityDefinitionLinkEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityDefinitionLinkEntityRecord obj) { 
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

public static Func<ENActivityDefinitionLinkEntityRecord, ssSystem_.RestRecords.RESTENActivityDefinitionLinkEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionLinkEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityDefinitionLinkEntityRecord FromStructure(ENActivityDefinitionLinkEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityDefinitionLinkEntityRecord(s, config);
}

}


