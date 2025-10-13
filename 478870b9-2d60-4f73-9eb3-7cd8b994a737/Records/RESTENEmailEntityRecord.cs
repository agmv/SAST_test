using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Email
public class RESTENEmailEntityRecord : AbstractRESTStructure<ENEmailEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Size")]
public int? AttrSize;

public RESTENEmailEntityRecord() { }

public RESTENEmailEntityRecord (ENEmailEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0);
  } else {
AttrId = (long?) s.ssId;
AttrSize = (int?) s.ssSize;
  }
}

public static ENEmailEntityRecord ToStructure(ssSystem_.RestRecords.RESTENEmailEntityRecord obj) { 
  ENEmailEntityRecord s = new ENEmailEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSize = obj.AttrSize == null ? 0 : obj.AttrSize.Value;
  }
  return s;
}

public static Func<ENEmailEntityRecord, ssSystem_.RestRecords.RESTENEmailEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENEmailEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENEmailEntityRecord FromStructure(ENEmailEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENEmailEntityRecord(s, config);
}

}


