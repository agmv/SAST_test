using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionRoleRecord
public class JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae : AbstractRESTStructure<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> {
[JsonProperty("ActivityDefinitionRole")]
[JsonPropertyName("ActivityDefinitionRole")]
public ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord AttrActivityDefinitionRole;

public JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae() { }

public JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinitionRole = ConvertToRestWithoutDefaults(s.ssENActivityDefinitionRole, new ENActivityDefinitionRoleEntityRecord(), ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinitionRole = ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord.FromStructure(s.ssENActivityDefinitionRole, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae, RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s) => ToStructure(s, config);
}
public static RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae ToStructure(ssSystem_.RestRecords.JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae obj, IBehaviorsConfiguration config) { 
  RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s = new RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae();
  if(obj != null) {
  s.ssENActivityDefinitionRole = ssSystem_.RestRecords.JSONENActivityDefinitionRoleEntityRecord.ToStructure(obj.AttrActivityDefinitionRole, config);
  }
  return s;
}

public static Func<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae, ssSystem_.RestRecords.JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae FromStructure(RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_e6ef33ef6256e74a2c6e9f5dbfecc6ae(s, config);
}

}


