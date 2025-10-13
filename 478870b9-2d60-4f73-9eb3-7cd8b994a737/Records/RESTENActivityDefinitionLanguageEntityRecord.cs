using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionLanguage
public class RESTENActivityDefinitionLanguageEntityRecord : AbstractRESTStructure<ENActivityDefinitionLanguageEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ActivityDefinitionId")]
public int? AttrActivityDefinitionId;

[JsonProperty("Locale")]
public string AttrLocale;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("InboxInstructions")]
public string AttrInboxInstructions;

public RESTENActivityDefinitionLanguageEntityRecord() { }

public RESTENActivityDefinitionLanguageEntityRecord (ENActivityDefinitionLanguageEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrActivityDefinitionId = ConvertToRestWithoutDefaults(s.ssActivityDefinitionId, 0);
AttrLocale = ConvertToRestWithoutDefaults(s.ssLocale, "");
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
AttrInboxInstructions = ConvertToRestWithoutDefaults(s.ssInboxInstructions, "");
  } else {
AttrId = (long?) s.ssId;
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
AttrLocale = s.ssLocale;
AttrLabel = s.ssLabel;
AttrInboxInstructions = s.ssInboxInstructions;
  }
}

public static ENActivityDefinitionLanguageEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord obj) { 
  ENActivityDefinitionLanguageEntityRecord s = new ENActivityDefinitionLanguageEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssActivityDefinitionId = obj.AttrActivityDefinitionId == null ? 0 : obj.AttrActivityDefinitionId.Value;
  s.ssLocale = obj.AttrLocale == null ? "" : obj.AttrLocale;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssInboxInstructions = obj.AttrInboxInstructions == null ? "" : obj.AttrInboxInstructions;
  }
  return s;
}

public static Func<ENActivityDefinitionLanguageEntityRecord, ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityDefinitionLanguageEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord FromStructure(ENActivityDefinitionLanguageEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityDefinitionLanguageEntityRecord(s, config);
}

}


