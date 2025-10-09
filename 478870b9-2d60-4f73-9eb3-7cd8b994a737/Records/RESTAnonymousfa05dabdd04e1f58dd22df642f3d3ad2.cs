using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionRoleRecord
public class RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae : AbstractRESTStructure<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> {
[JsonProperty("ActivityDefinitionRole")]
public ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord AttrActivityDefinitionRole;

public RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae() { }

public RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinitionRole = ConvertToRestWithoutDefaults(s.ssENActivityDefinitionRole, new ENActivityDefinitionRoleEntityRecord(), ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinitionRole = ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord.FromStructure(s.ssENActivityDefinitionRole, config);
  }
}

public static RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae ToStructure(ssSystem_.RestRecords.RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae obj) { 
  RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s = new RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae();
  if(obj != null) {
  s.ssENActivityDefinitionRole = ssSystem_.RestRecords.RESTENActivityDefinitionRoleEntityRecord.ToStructure(obj.AttrActivityDefinitionRole);
  }
  return s;
}

public static Func<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae, ssSystem_.RestRecords.RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae FromStructure(RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae(s, config);
}

}


