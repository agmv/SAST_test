using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Tenant
public class JSONENTenantEntityRecord : AbstractRESTStructure<ENTenantEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENTenantEntityRecord() { }

public JSONENTenantEntityRecord (ENTenantEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssSystem_.RestRecords.JSONENTenantEntityRecord, ENTenantEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONENTenantEntityRecord s) => ToStructure(s, config);
}
public static ENTenantEntityRecord ToStructure(ssSystem_.RestRecords.JSONENTenantEntityRecord obj, IBehaviorsConfiguration config) { 
  ENTenantEntityRecord s = new ENTenantEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENTenantEntityRecord, ssSystem_.RestRecords.JSONENTenantEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENTenantEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONENTenantEntityRecord FromStructure(ENTenantEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONENTenantEntityRecord(s, config);
}

}


