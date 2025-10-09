using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInputDefinition
public class RESTENProcessInputDefinitionEntityRecord : AbstractRESTStructure<ENProcessInputDefinitionEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Key")]
public string AttrKey;

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

[JsonProperty("IsMandatory")]
public bool? AttrIsMandatory;

[JsonProperty("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public RESTENProcessInputDefinitionEntityRecord() { }

public RESTENProcessInputDefinitionEntityRecord (ENProcessInputDefinitionEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENProcessInputDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord obj) { 
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

public static Func<ENProcessInputDefinitionEntityRecord, ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessInputDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord FromStructure(ENProcessInputDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENProcessInputDefinitionEntityRecord(s, config);
}

}


