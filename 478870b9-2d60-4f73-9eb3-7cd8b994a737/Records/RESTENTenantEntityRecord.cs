using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// Tenant
public class RESTENTenantEntityRecord : AbstractRESTStructure<ENTenantEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTENTenantEntityRecord() { }

public RESTENTenantEntityRecord (ENTenantEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static ENTenantEntityRecord ToStructure(ssSystem_.RestRecords.RESTENTenantEntityRecord obj) { 
  ENTenantEntityRecord s = new ENTenantEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENTenantEntityRecord, ssSystem_.RestRecords.RESTENTenantEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENTenantEntityRecord s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTENTenantEntityRecord FromStructure(ENTenantEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTENTenantEntityRecord(s, config);
}

}


