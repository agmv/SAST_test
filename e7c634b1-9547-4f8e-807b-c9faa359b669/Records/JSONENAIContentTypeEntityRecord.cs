using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIContentType
public class JSONENAIContentTypeEntityRecord : AbstractRESTStructure<ENAIContentTypeEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENAIContentTypeEntityRecord() { }

public JSONENAIContentTypeEntityRecord (ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord, ENAIContentTypeEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord s) => ToStructure(s, config);
}
public static ENAIContentTypeEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord obj, IBehaviorsConfiguration config) { 
  ENAIContentTypeEntityRecord s = new ENAIContentTypeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENAIContentTypeEntityRecord, ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENAIContentTypeEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord FromStructure(ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord(s, config);
}

}


