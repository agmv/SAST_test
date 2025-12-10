using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIModelUsage
public class JSONSTAIModelUsageStructure : AbstractRESTStructure<STAIModelUsageStructure> {
[JsonProperty("ResponseTokens")]
[JsonPropertyName("ResponseTokens")]
public long? AttrResponseTokens;

[JsonProperty("InputTokens")]
[JsonPropertyName("InputTokens")]
public long? AttrInputTokens;

[JsonProperty("TotalTokens")]
[JsonPropertyName("TotalTokens")]
public long? AttrTotalTokens;

public JSONSTAIModelUsageStructure() { }

public JSONSTAIModelUsageStructure (STAIModelUsageStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrResponseTokens = ConvertToRestWithoutDefaults(s.ssResponseTokens, 0L);
AttrInputTokens = ConvertToRestWithoutDefaults(s.ssInputTokens, 0L);
AttrTotalTokens = ConvertToRestWithoutDefaults(s.ssTotalTokens, 0L);
  } else {
AttrResponseTokens = (long?) s.ssResponseTokens;
AttrInputTokens = (long?) s.ssInputTokens;
AttrTotalTokens = (long?) s.ssTotalTokens;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure, STAIModelUsageStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure s) => ToStructure(s, config);
}
public static STAIModelUsageStructure ToStructure(ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure obj, IBehaviorsConfiguration config) { 
  STAIModelUsageStructure s = new STAIModelUsageStructure();
  if(obj != null) {
  s.ssResponseTokens = obj.AttrResponseTokens == null ? 0L : obj.AttrResponseTokens.Value;
  s.ssInputTokens = obj.AttrInputTokens == null ? 0L : obj.AttrInputTokens.Value;
  s.ssTotalTokens = obj.AttrTotalTokens == null ? 0L : obj.AttrTotalTokens.Value;
  }
  return s;
}

public static Func<STAIModelUsageStructure, ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAIModelUsageStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure FromStructure(STAIModelUsageStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure(s, config);
}

}


