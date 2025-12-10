using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIModelUsageRecord
public class RESTRCAIModelUsageRecord : AbstractRESTStructure<RCAIModelUsageRecord> {
[JsonProperty("AIModelUsage")]
public ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure AttrAIModelUsage;

public RESTRCAIModelUsageRecord() { }

public RESTRCAIModelUsageRecord (RCAIModelUsageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIModelUsage = ConvertToRestWithoutDefaults(s.ssSTAIModelUsage, new STAIModelUsageStructure(), ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure.FromStructureDelegate(config));
  } else {
AttrAIModelUsage = ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure.FromStructure(s.ssSTAIModelUsage, config);
  }
}

public static RCAIModelUsageRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTRCAIModelUsageRecord obj) { 
  RCAIModelUsageRecord s = new RCAIModelUsageRecord();
  if(obj != null) {
  s.ssSTAIModelUsage = ssRuntimeDestroyer.RestRecords.RESTSTAIModelUsageStructure.ToStructure(obj.AttrAIModelUsage);
  }
  return s;
}

public static Func<RCAIModelUsageRecord, ssRuntimeDestroyer.RestRecords.RESTRCAIModelUsageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIModelUsageRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRCAIModelUsageRecord FromStructure(RCAIModelUsageRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRCAIModelUsageRecord(s, config);
}

}


