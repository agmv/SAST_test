using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityStatus
public class RESTENActivityStatusEntityRecord : AbstractRESTStructure<ENActivityStatusEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTENActivityStatusEntityRecord() { }

public RESTENActivityStatusEntityRecord (ENActivityStatusEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static ENActivityStatusEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityStatusEntityRecord obj) { 
  ENActivityStatusEntityRecord s = new ENActivityStatusEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENActivityStatusEntityRecord, ssSystem_.RestRecords.RESTENActivityStatusEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityStatusEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityStatusEntityRecord FromStructure(ENActivityStatusEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityStatusEntityRecord(s, config);
}

}


