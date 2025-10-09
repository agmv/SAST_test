using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// TenantRecord
public class JSONRC_40d0f5c5ba630b105850cead15ae2223 : AbstractRESTStructure<RC_40d0f5c5ba630b105850cead15ae2223> {
[JsonProperty("Tenant")]
[JsonPropertyName("Tenant")]
public ssSystem_.RestRecords.JSONENTenantEntityRecord AttrTenant;

public JSONRC_40d0f5c5ba630b105850cead15ae2223() { }

public JSONRC_40d0f5c5ba630b105850cead15ae2223 (RC_40d0f5c5ba630b105850cead15ae2223 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTenant = ConvertToRestWithoutDefaults(s.ssENTenant, new ENTenantEntityRecord(), ssSystem_.RestRecords.JSONENTenantEntityRecord.FromStructureDelegate(config));
  } else {
AttrTenant = ssSystem_.RestRecords.JSONENTenantEntityRecord.FromStructure(s.ssENTenant, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_40d0f5c5ba630b105850cead15ae2223, RC_40d0f5c5ba630b105850cead15ae2223> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_40d0f5c5ba630b105850cead15ae2223 s) => ToStructure(s, config);
}
public static RC_40d0f5c5ba630b105850cead15ae2223 ToStructure(ssSystem_.RestRecords.JSONRC_40d0f5c5ba630b105850cead15ae2223 obj, IBehaviorsConfiguration config) { 
  RC_40d0f5c5ba630b105850cead15ae2223 s = new RC_40d0f5c5ba630b105850cead15ae2223();
  if(obj != null) {
  s.ssENTenant = ssSystem_.RestRecords.JSONENTenantEntityRecord.ToStructure(obj.AttrTenant, config);
  }
  return s;
}

public static Func<RC_40d0f5c5ba630b105850cead15ae2223, ssSystem_.RestRecords.JSONRC_40d0f5c5ba630b105850cead15ae2223> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_40d0f5c5ba630b105850cead15ae2223 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_40d0f5c5ba630b105850cead15ae2223 FromStructure(RC_40d0f5c5ba630b105850cead15ae2223 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_40d0f5c5ba630b105850cead15ae2223(s, config);
}

}


