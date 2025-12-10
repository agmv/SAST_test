using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIContentType
public class RESTENAIContentTypeEntityRecord : AbstractRESTStructure<ENAIContentTypeEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTENAIContentTypeEntityRecord() { }

public RESTENAIContentTypeEntityRecord (ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static ENAIContentTypeEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord obj) { 
  ENAIContentTypeEntityRecord s = new ENAIContentTypeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENAIContentTypeEntityRecord, ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENAIContentTypeEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord FromStructure(ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord(s, config);
}

}


