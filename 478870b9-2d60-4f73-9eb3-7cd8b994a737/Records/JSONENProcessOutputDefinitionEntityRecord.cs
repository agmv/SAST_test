using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessOutputDefinition
public class JSONENProcessOutputDefinitionEntityRecord : AbstractRESTStructure<ENProcessOutputDefinitionEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("ProcessDefinitionId")]
[JsonPropertyName("ProcessDefinitionId")]
public int? AttrProcessDefinitionId;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("DataType")]
[JsonPropertyName("DataType")]
public string AttrDataType;

[JsonProperty("DefaultValue")]
[JsonPropertyName("DefaultValue")]
public string AttrDefaultValue;

[JsonProperty("ForeignKeyEntityId")]
[JsonPropertyName("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public JSONENProcessOutputDefinitionEntityRecord() { }

public JSONENProcessOutputDefinitionEntityRecord (ENProcessOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord, ENProcessOutputDefinitionEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord s) => ToStructure(s, config);
}
public static ENProcessOutputDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord obj, IBehaviorsConfiguration config) { 
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

public static Func<ENProcessOutputDefinitionEntityRecord, ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessOutputDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord FromStructure(ENProcessOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENProcessOutputDefinitionEntityRecord(s, config);
}

}


