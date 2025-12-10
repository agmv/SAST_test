using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIItemRecord
public class RESTRCAIItemRecord : AbstractRESTStructure<RCAIItemRecord> {
[JsonProperty("AIItem")]
public ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure AttrAIItem;

public RESTRCAIItemRecord() { }

public RESTRCAIItemRecord (RCAIItemRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIItem = ConvertToRestWithoutDefaults(s.ssSTAIItem, new STAIItemStructure(), ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure.FromStructureDelegate(config));
  } else {
AttrAIItem = ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure.FromStructure(s.ssSTAIItem, config);
  }
}

public static RCAIItemRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTRCAIItemRecord obj) { 
  RCAIItemRecord s = new RCAIItemRecord();
  if(obj != null) {
  s.ssSTAIItem = ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure.ToStructure(obj.AttrAIItem);
  }
  return s;
}

public static Func<RCAIItemRecord, ssRuntimeDestroyer.RestRecords.RESTRCAIItemRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIItemRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRCAIItemRecord FromStructure(RCAIItemRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRCAIItemRecord(s, config);
}

}


