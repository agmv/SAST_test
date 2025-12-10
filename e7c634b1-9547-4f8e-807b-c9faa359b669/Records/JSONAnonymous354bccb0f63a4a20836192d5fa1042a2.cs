using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIMessageRecord
public class JSONRCAIMessageRecord : AbstractRESTStructure<RCAIMessageRecord> {
[JsonProperty("AIMessage")]
[JsonPropertyName("AIMessage")]
public ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure AttrAIMessage;

public JSONRCAIMessageRecord() { }

public JSONRCAIMessageRecord (RCAIMessageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIMessage = ConvertToRestWithoutDefaults(s.ssSTAIMessage, new STAIMessageStructure(), ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure.FromStructureDelegate(config));
  } else {
AttrAIMessage = ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure.FromStructure(s.ssSTAIMessage, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRCAIMessageRecord, RCAIMessageRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRCAIMessageRecord s) => ToStructure(s, config);
}
public static RCAIMessageRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONRCAIMessageRecord obj, IBehaviorsConfiguration config) { 
  RCAIMessageRecord s = new RCAIMessageRecord();
  if(obj != null) {
  s.ssSTAIMessage = ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure.ToStructure(obj.AttrAIMessage, config);
  }
  return s;
}

public static Func<RCAIMessageRecord, ssRuntimeDestroyer.RestRecords.JSONRCAIMessageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIMessageRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRCAIMessageRecord FromStructure(RCAIMessageRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRCAIMessageRecord(s, config);
}

}


