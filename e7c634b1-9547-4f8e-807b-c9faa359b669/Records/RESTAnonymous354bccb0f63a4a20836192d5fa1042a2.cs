using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIMessageRecord
public class RESTRCAIMessageRecord : AbstractRESTStructure<RCAIMessageRecord> {
[JsonProperty("AIMessage")]
public ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure AttrAIMessage;

public RESTRCAIMessageRecord() { }

public RESTRCAIMessageRecord (RCAIMessageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIMessage = ConvertToRestWithoutDefaults(s.ssSTAIMessage, new STAIMessageStructure(), ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure.FromStructureDelegate(config));
  } else {
AttrAIMessage = ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure.FromStructure(s.ssSTAIMessage, config);
  }
}

public static RCAIMessageRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTRCAIMessageRecord obj) { 
  RCAIMessageRecord s = new RCAIMessageRecord();
  if(obj != null) {
  s.ssSTAIMessage = ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure.ToStructure(obj.AttrAIMessage);
  }
  return s;
}

public static Func<RCAIMessageRecord, ssRuntimeDestroyer.RestRecords.RESTRCAIMessageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIMessageRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRCAIMessageRecord FromStructure(RCAIMessageRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRCAIMessageRecord(s, config);
}

}


