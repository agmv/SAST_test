using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInputDefinition
public class JSONENProcessInputDefinitionEntityRecord : AbstractRESTStructure<ENProcessInputDefinitionEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("Key")]
[JsonPropertyName("Key")]
public string AttrKey;

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

[JsonProperty("IsMandatory")]
[JsonPropertyName("IsMandatory")]
public bool? AttrIsMandatory;

[JsonProperty("ForeignKeyEntityId")]
[JsonPropertyName("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public JSONENProcessInputDefinitionEntityRecord() { }

public JSONENProcessInputDefinitionEntityRecord (ENProcessInputDefinitionEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrDataType = s.ssDataType;
AttrDefaultValue = ConvertToRestWithoutDefaults(s.ssDefaultValue, "");
AttrIsMandatory = (bool?) s.ssIsMandatory;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  } else {
AttrId = s.ssId;
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrDescription = s.ssDescription;
AttrProcessDefinitionId = (int?) s.ssProcessDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrDataType = s.ssDataType;
AttrDefaultValue = s.ssDefaultValue;
AttrIsMandatory = (bool?) s.ssIsMandatory;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord, ENProcessInputDefinitionEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord s) => ToStructure(s, config);
}
public static ENProcessInputDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord obj, IBehaviorsConfiguration config) { 
  ENProcessInputDefinitionEntityRecord s = new ENProcessInputDefinitionEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssProcessDefinitionId = obj.AttrProcessDefinitionId == null ? 0 : obj.AttrProcessDefinitionId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssDataType = obj.AttrDataType == null ? "" : obj.AttrDataType;
  s.ssDefaultValue = obj.AttrDefaultValue == null ? "" : obj.AttrDefaultValue;
  s.ssIsMandatory = obj.AttrIsMandatory == null ? false : obj.AttrIsMandatory.Value;
  s.ssForeignKeyEntityId = obj.AttrForeignKeyEntityId == null ? "" : obj.AttrForeignKeyEntityId;
  }
  return s;
}

public static Func<ENProcessInputDefinitionEntityRecord, ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessInputDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord FromStructure(ENProcessInputDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENProcessInputDefinitionEntityRecord(s, config);
}

}


