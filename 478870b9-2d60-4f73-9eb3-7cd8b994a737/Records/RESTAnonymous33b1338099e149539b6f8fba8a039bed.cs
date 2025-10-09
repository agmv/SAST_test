using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// TenantRecord
public class RESTRC_40d0f5c5ba630b105850cead15ae2223 : AbstractRESTStructure<RC_40d0f5c5ba630b105850cead15ae2223> {
[JsonProperty("Tenant")]
public ssSystem_.RestRecords.RESTENTenantEntityRecord AttrTenant;

public RESTRC_40d0f5c5ba630b105850cead15ae2223() { }

public RESTRC_40d0f5c5ba630b105850cead15ae2223 (RC_40d0f5c5ba630b105850cead15ae2223 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTenant = ConvertToRestWithoutDefaults(s.ssENTenant, new ENTenantEntityRecord(), ssSystem_.RestRecords.RESTENTenantEntityRecord.FromStructureDelegate(config));
  } else {
AttrTenant = ssSystem_.RestRecords.RESTENTenantEntityRecord.FromStructure(s.ssENTenant, config);
  }
}

public static RC_40d0f5c5ba630b105850cead15ae2223 ToStructure(ssSystem_.RestRecords.RESTRC_40d0f5c5ba630b105850cead15ae2223 obj) { 
  RC_40d0f5c5ba630b105850cead15ae2223 s = new RC_40d0f5c5ba630b105850cead15ae2223();
  if(obj != null) {
  s.ssENTenant = ssSystem_.RestRecords.RESTENTenantEntityRecord.ToStructure(obj.AttrTenant);
  }
  return s;
}

public static Func<RC_40d0f5c5ba630b105850cead15ae2223, ssSystem_.RestRecords.RESTRC_40d0f5c5ba630b105850cead15ae2223> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_40d0f5c5ba630b105850cead15ae2223 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_40d0f5c5ba630b105850cead15ae2223 FromStructure(RC_40d0f5c5ba630b105850cead15ae2223 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_40d0f5c5ba630b105850cead15ae2223(s, config);
}

}


