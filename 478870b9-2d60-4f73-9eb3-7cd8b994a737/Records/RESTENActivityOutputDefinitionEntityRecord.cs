using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutputDefinition
public class RESTENActivityOutputDefinitionEntityRecord : AbstractRESTStructure<ENActivityOutputDefinitionEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("ActivityDefinitionId")]
public int? AttrActivityDefinitionId;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("DataType")]
public string AttrDataType;

[JsonProperty("IsInput")]
public bool? AttrIsInput;

[JsonProperty("IsMandatory")]
public bool? AttrIsMandatory;

[JsonProperty("DefaultValue")]
public string AttrDefaultValue;

[JsonProperty("ForeignKeyEntityId")]
public string AttrForeignKeyEntityId;

public RESTENActivityOutputDefinitionEntityRecord() { }

public RESTENActivityOutputDefinitionEntityRecord (ENActivityOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) {
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

public static ENActivityOutputDefinitionEntityRecord ToStructure(ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord obj) { 
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

public static Func<ENActivityOutputDefinitionEntityRecord, ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityOutputDefinitionEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord FromStructure(ENActivityOutputDefinitionEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENActivityOutputDefinitionEntityRecord(s, config);
}

}


