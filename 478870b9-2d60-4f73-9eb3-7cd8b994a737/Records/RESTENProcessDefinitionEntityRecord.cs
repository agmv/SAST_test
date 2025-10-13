using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessDefinition
public class RESTENProcessDefinitionEntityRecord : AbstractRESTStructure<ENProcessDefinitionEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Revision")]
public int? AttrRevision;

public RESTENProcessDefinitionEntityRecord() { }

public RESTENProcessDefinitionEntityRecord (ENProcessDefinitionEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, "");
AttrName = s.ssName;
AttrRevision = ConvertToRestWithoutDefaults(s.ssRevision, 0);
  } else {
AttrId = (int?) s.ssId;
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrRevision = (int?) s.ssRevision;
  }
}

public static ENProcessDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord obj) { 
  ENProcessDefinitionEntityRecord s = new ENProcessDefinitionEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRevision = obj.AttrRevision == null ? 0 : obj.AttrRevision.Value;
  }
  return s;
}

public static Func<ENProcessDefinitionEntityRecord, ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord FromStructure(ENProcessDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessDefinitionEntityRecord(s, config);
}

}


