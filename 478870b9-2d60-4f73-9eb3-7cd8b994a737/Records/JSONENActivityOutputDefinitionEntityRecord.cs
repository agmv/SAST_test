using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutputDefinition
public class JSONENActivityOutputDefinitionEntityRecord : AbstractRESTStructure<ENActivityOutputDefinitionEntityRecord> {
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

[JsonProperty("ActivityDefinitionId")]
[JsonPropertyName("ActivityDefinitionId")]
public int? AttrActivityDefinitionId;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("DataType")]
[JsonPropertyName("DataType")]
public string AttrDataType;

[JsonProperty("IsInput")]
[JsonPropertyName("IsInput")]
public bool? AttrIsInput;

[JsonProperty("IsMandatory")]
[JsonPropertyName("IsMandatory")]
public bool? AttrIsMandatory;

[JsonProperty("DefaultValue")]
[JsonPropertyName("DefaultValue")]
public string AttrDefaultValue;

[JsonProperty("ForeignKeyEntityId")]
[JsonPropertyName("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public JSONENActivityOutputDefinitionEntityRecord() { }

public JSONENActivityOutputDefinitionEntityRecord (ENActivityOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrDataType = s.ssDataType;
AttrIsInput = (bool?) s.ssIsInput;
AttrIsMandatory = (bool?) s.ssIsMandatory;
AttrDefaultValue = ConvertToRestWithoutDefaults(s.ssDefaultValue, "");
AttrForeignKeyEntityId = ConvertToRestWithoutDefaults(s.ssForeignKeyEntityId, "");
  } else {
AttrId = s.ssId;
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrDescription = s.ssDescription;
AttrActivityDefinitionId = (int?) s.ssActivityDefinitionId;
AttrIsActive = (bool?) s.ssIsActive;
AttrDataType = s.ssDataType;
AttrIsInput = (bool?) s.ssIsInput;
AttrIsMandatory = (bool?) s.ssIsMandatory;
AttrDefaultValue = s.ssDefaultValue;
AttrForeignKeyEntityId = s.ssForeignKeyEntityId;
  }
}

public static Func<ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord, ENActivityOutputDefinitionEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord s) => ToStructure(s, config);
}
public static ENActivityOutputDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityOutputDefinitionEntityRecord s = new ENActivityOutputDefinitionEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssActivityDefinitionId = obj.AttrActivityDefinitionId == null ? 0 : obj.AttrActivityDefinitionId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssDataType = obj.AttrDataType == null ? "" : obj.AttrDataType;
  s.ssIsInput = obj.AttrIsInput == null ? false : obj.AttrIsInput.Value;
  s.ssIsMandatory = obj.AttrIsMandatory == null ? false : obj.AttrIsMandatory.Value;
  s.ssDefaultValue = obj.AttrDefaultValue == null ? "" : obj.AttrDefaultValue;
  s.ssForeignKeyEntityId = obj.AttrForeignKeyEntityId == null ? "" : obj.AttrForeignKeyEntityId;
  }
  return s;
}

public static Func<ENActivityOutputDefinitionEntityRecord, ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityOutputDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord FromStructure(ENActivityOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENActivityOutputDefinitionEntityRecord(s, config);
}

}


