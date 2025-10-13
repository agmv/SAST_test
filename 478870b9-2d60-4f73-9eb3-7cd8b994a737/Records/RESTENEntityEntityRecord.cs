using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Entity
public class RESTENEntityEntityRecord : AbstractRESTStructure<ENEntityEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("ApplicationId")]
public string AttrApplicationId;

[JsonProperty("IsStatic")]
public bool? AttrIsStatic;

[JsonProperty("PrimaryKeyAttribute")]
public string AttrPrimaryKeyAttribute;

public RESTENEntityEntityRecord() { }

public RESTENEntityEntityRecord (ENEntityEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrName = s.ssName;
AttrApplicationId = ConvertToRestWithoutDefaults(s.ssApplicationId, "");
AttrIsStatic = (bool?) s.ssIsStatic;
AttrPrimaryKeyAttribute = ConvertToRestWithoutDefaults(s.ssPrimaryKeyAttribute, "");
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
AttrApplicationId = s.ssApplicationId;
AttrIsStatic = (bool?) s.ssIsStatic;
AttrPrimaryKeyAttribute = s.ssPrimaryKeyAttribute;
  }
}

public static ENEntityEntityRecord ToStructure(ssSystem_.RestRecords.RESTENEntityEntityRecord obj) { 
  ENEntityEntityRecord s = new ENEntityEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssApplicationId = obj.AttrApplicationId == null ? "" : obj.AttrApplicationId;
  s.ssIsStatic = obj.AttrIsStatic == null ? false : obj.AttrIsStatic.Value;
  s.ssPrimaryKeyAttribute = obj.AttrPrimaryKeyAttribute == null ? "" : obj.AttrPrimaryKeyAttribute;
  }
  return s;
}

public static Func<ENEntityEntityRecord, ssSystem_.RestRecords.RESTENEntityEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENEntityEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENEntityEntityRecord FromStructure(ENEntityEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENEntityEntityRecord(s, config);
}

}


