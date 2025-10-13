using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIModelUsageRecord
public class JSONRCAIModelUsageRecord : AbstractRESTStructure<RCAIModelUsageRecord> {
[JsonProperty("AIModelUsage")]
[JsonPropertyName("AIModelUsage")]
public ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure AttrAIModelUsage;

public JSONRCAIModelUsageRecord() { }

public JSONRCAIModelUsageRecord (RCAIModelUsageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIModelUsage = ConvertToRestWithoutDefaults(s.ssSTAIModelUsage, new STAIModelUsageStructure(), ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure.FromStructureDelegate(config));
  } else {
AttrAIModelUsage = ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure.FromStructure(s.ssSTAIModelUsage, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRCAIModelUsageRecord, RCAIModelUsageRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRCAIModelUsageRecord s) => ToStructure(s, config);
}
public static RCAIModelUsageRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONRCAIModelUsageRecord obj, IBehaviorsConfiguration config) { 
  RCAIModelUsageRecord s = new RCAIModelUsageRecord();
  if(obj != null) {
  s.ssSTAIModelUsage = ssRuntimeDestroyer.RestRecords.JSONSTAIModelUsageStructure.ToStructure(obj.AttrAIModelUsage, config);
  }
  return s;
}

public static Func<RCAIModelUsageRecord, ssRuntimeDestroyer.RestRecords.JSONRCAIModelUsageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIModelUsageRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRCAIModelUsageRecord FromStructure(RCAIModelUsageRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRCAIModelUsageRecord(s, config);
}

}


