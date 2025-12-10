using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIModelUsage
public class RESTSTAIModelUsageStructure : AbstractRESTStructure<STAIModelUsageStructure> {
[JsonProperty("ResponseTokens")]
public long? AttrResponseTokens;

[JsonProperty("InputTokens")]
public long? AttrInputTokens;

[JsonProperty("TotalTokens")]
public long? AttrTotalTokens;

public RESTSTAIModelUsageStructure() { }

public RESTSTAIModelUsageStructure (STAIModelUsageStructure s, IBehaviorsConfiguration config) {
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

public static STAIModelUsageStructure ToStructure(ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure obj) { 
  STAIModelUsageStructure s = new STAIModelUsageStructure();
  if(obj != null) {
  s.ssResponseTokens = obj.AttrResponseTokens == null ? 0L : obj.AttrResponseTokens.Value;
  s.ssInputTokens = obj.AttrInputTokens == null ? 0L : obj.AttrInputTokens.Value;
  s.ssTotalTokens = obj.AttrTotalTokens == null ? 0L : obj.AttrTotalTokens.Value;
  }
  return s;
}

public static Func<STAIModelUsageStructure, ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAIModelUsageStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure FromStructure(STAIModelUsageStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure(s, config);
}

}


