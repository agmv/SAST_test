using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// HumanActivityInstance
public class RESTENHumanActivityInstanceEntityRecord : AbstractRESTStructure<ENHumanActivityInstanceEntityRecord> {
[JsonProperty("ActivityInstanceId")]
public long? AttrActivityInstanceId;

[JsonProperty("AssignedUserId")]
public string AttrAssignedUserId;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("URL")]
public string AttrURL;

public RESTENHumanActivityInstanceEntityRecord() { }

public RESTENHumanActivityInstanceEntityRecord (ENHumanActivityInstanceEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityInstanceId = (long?) s.ssActivityInstanceId;
AttrAssignedUserId = ConvertToRestWithoutDefaults(s.ssAssignedUserId, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrURL = ConvertToRestWithoutDefaults(s.ssURL, "");
  } else {
AttrActivityInstanceId = (long?) s.ssActivityInstanceId;
AttrAssignedUserId = s.ssAssignedUserId;
AttrMessage = s.ssMessage;
AttrURL = s.ssURL;
  }
}

public static ENHumanActivityInstanceEntityRecord ToStructure(ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord obj) { 
  ENHumanActivityInstanceEntityRecord s = new ENHumanActivityInstanceEntityRecord();
  if(obj != null) {
  s.ssActivityInstanceId = obj.AttrActivityInstanceId == null ? 0L : obj.AttrActivityInstanceId.Value;
  s.ssAssignedUserId = obj.AttrAssignedUserId == null ? "" : obj.AttrAssignedUserId;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssURL = obj.AttrURL == null ? "" : obj.AttrURL;
  }
  return s;
}

public static Func<ENHumanActivityInstanceEntityRecord, ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENHumanActivityInstanceEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord FromStructure(ENHumanActivityInstanceEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENHumanActivityInstanceEntityRecord(s, config);
}

}


