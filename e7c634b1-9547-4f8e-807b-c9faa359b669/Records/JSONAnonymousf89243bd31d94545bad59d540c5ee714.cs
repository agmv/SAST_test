using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIItemRecord
public class JSONRCAIItemRecord : AbstractRESTStructure<RCAIItemRecord> {
[JsonProperty("AIItem")]
[JsonPropertyName("AIItem")]
public ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure AttrAIItem;

public JSONRCAIItemRecord() { }

public JSONRCAIItemRecord (RCAIItemRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIItem = ConvertToRestWithoutDefaults(s.ssSTAIItem, new STAIItemStructure(), ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure.FromStructureDelegate(config));
  } else {
AttrAIItem = ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure.FromStructure(s.ssSTAIItem, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRCAIItemRecord, RCAIItemRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRCAIItemRecord s) => ToStructure(s, config);
}
public static RCAIItemRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONRCAIItemRecord obj, IBehaviorsConfiguration config) { 
  RCAIItemRecord s = new RCAIItemRecord();
  if(obj != null) {
  s.ssSTAIItem = ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure.ToStructure(obj.AttrAIItem, config);
  }
  return s;
}

public static Func<RCAIItemRecord, ssRuntimeDestroyer.RestRecords.JSONRCAIItemRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIItemRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRCAIItemRecord FromStructure(RCAIItemRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRCAIItemRecord(s, config);
}

}


