using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessStatus
public class RESTENProcessStatusEntityRecord : AbstractRESTStructure<ENProcessStatusEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTENProcessStatusEntityRecord() { }

public RESTENProcessStatusEntityRecord (ENProcessStatusEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static ENProcessStatusEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessStatusEntityRecord obj) { 
  ENProcessStatusEntityRecord s = new ENProcessStatusEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENProcessStatusEntityRecord, ssSystem_.RestRecords.RESTENProcessStatusEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessStatusEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessStatusEntityRecord FromStructure(ENProcessStatusEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessStatusEntityRecord(s, config);
}

}


