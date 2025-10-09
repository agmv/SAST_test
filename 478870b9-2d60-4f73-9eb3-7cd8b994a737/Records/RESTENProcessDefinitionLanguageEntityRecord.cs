using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinitionLanguage
public class RESTENProcessDefinitionLanguageEntityRecord : AbstractRESTStructure<ENProcessDefinitionLanguageEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("Locale")]
public string AttrLocale;

[JsonProperty("Label")]
public string AttrLabel;

public RESTENProcessDefinitionLanguageEntityRecord() { }

public RESTENProcessDefinitionLanguageEntityRecord (ENProcessDefinitionLanguageEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrLocale = ConvertToRestWithoutDefaults(s.ssLocale, "");
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
  } else {
AttrId = (long?) s.ssId;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrLocale = s.ssLocale;
AttrLabel = s.ssLabel;
  }
}

public static ENProcessDefinitionLanguageEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord obj) { 
  ENProcessDefinitionLanguageEntityRecord s = new ENProcessDefinitionLanguageEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssLocale = obj.AttrLocale == null ? "" : obj.AttrLocale;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<ENProcessDefinitionLanguageEntityRecord, ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessDefinitionLanguageEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord FromStructure(ENProcessDefinitionLanguageEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessDefinitionLanguageEntityRecord(s, config);
}

}


