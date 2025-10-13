using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutputDefinition
public class RESTENProcessOutputDefinitionEntityRecord : AbstractRESTStructure<ENProcessOutputDefinitionEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("DataType")]
public string AttrDataType;

[JsonProperty("DefaultValue")]
public string AttrDefaultValue;

[JsonProperty("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public RESTENProcessOutputDefinitionEntityRecord() { }

public RESTENProcessOutputDefinitionEntityRecord (ENProcessOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrName = s.ssName;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrDataType = s.ssDataType;
AttrDefaultValue = ConvertToRestWithoutDefaults(s.ssDefaultValue, "");
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
AttrDescription = s.ssDescription;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrDataType = s.ssDataType;
AttrDefaultValue = s.ssDefaultValue;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  }
}

public static ENProcessOutputDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessOutputDefinitionEntityRecord obj) { 
  ENProcessOutputDefinitionEntityRecord s = new ENProcessOutputDefinitionEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssDataType = obj.AttrDataType == null ? "" : obj.AttrDataType;
  s.ssDefaultValue = obj.AttrDefaultValue == null ? "" : obj.AttrDefaultValue;
  s.ssForeignKeyEntityId = obj.AttrForeignKeyEntityId == null ? "" : obj.AttrForeignKeyEntityId;
  }
  return s;
}

public static Func<ENProcessOutputDefinitionEntityRecord, ssSystem_.RestRecords.RESTENProcessOutputDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessOutputDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessOutputDefinitionEntityRecord FromStructure(ENProcessOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessOutputDefinitionEntityRecord(s, config);
}

}


