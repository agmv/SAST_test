using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Application
public class RESTENApplicationEntityRecord : AbstractRESTStructure<ENApplicationEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Type")]
public string AttrType;

public RESTENApplicationEntityRecord() { }

public RESTENApplicationEntityRecord (ENApplicationEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrName = s.ssName;
AttrType = ConvertToRestWithoutDefaults(s.ssType, "");
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
AttrType = s.ssType;
  }
}

public static ENApplicationEntityRecord ToStructure(ssSystem_.RestRecords.RESTENApplicationEntityRecord obj) { 
  ENApplicationEntityRecord s = new ENApplicationEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<ENApplicationEntityRecord, ssSystem_.RestRecords.RESTENApplicationEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENApplicationEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENApplicationEntityRecord FromStructure(ENApplicationEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENApplicationEntityRecord(s, config);
}

}


