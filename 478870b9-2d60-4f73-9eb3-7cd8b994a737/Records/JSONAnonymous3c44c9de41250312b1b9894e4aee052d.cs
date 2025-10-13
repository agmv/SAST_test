using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityDefinitionLinkRecord
public class JSONRC_c97a9c0cb896c874168b02efa3e48866 : AbstractRESTStructure<RC_c97a9c0cb896c874168b02efa3e48866> {
[JsonProperty("ActivityDefinitionLink")]
[JsonPropertyName("ActivityDefinitionLink")]
public ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord AttrActivityDefinitionLink;

public JSONRC_c97a9c0cb896c874168b02efa3e48866() { }

public JSONRC_c97a9c0cb896c874168b02efa3e48866 (RC_c97a9c0cb896c874168b02efa3e48866 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityDefinitionLink = ConvertToRestWithoutDefaults(s.ssENActivityDefinitionLink, new ENActivityDefinitionLinkEntityRecord(), ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityDefinitionLink = ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord.FromStructure(s.ssENActivityDefinitionLink, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_c97a9c0cb896c874168b02efa3e48866, RC_c97a9c0cb896c874168b02efa3e48866> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_c97a9c0cb896c874168b02efa3e48866 s) => ToStructure(s, config);
}
public static RC_c97a9c0cb896c874168b02efa3e48866 ToStructure(ssSystem_.RestRecords.JSONRC_c97a9c0cb896c874168b02efa3e48866 obj, IBehaviorsConfiguration config) { 
  RC_c97a9c0cb896c874168b02efa3e48866 s = new RC_c97a9c0cb896c874168b02efa3e48866();
  if(obj != null) {
  s.ssENActivityDefinitionLink = ssSystem_.RestRecords.JSONENActivityDefinitionLinkEntityRecord.ToStructure(obj.AttrActivityDefinitionLink, config);
  }
  return s;
}

public static Func<RC_c97a9c0cb896c874168b02efa3e48866, ssSystem_.RestRecords.JSONRC_c97a9c0cb896c874168b02efa3e48866> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c97a9c0cb896c874168b02efa3e48866 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_c97a9c0cb896c874168b02efa3e48866 FromStructure(RC_c97a9c0cb896c874168b02efa3e48866 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_c97a9c0cb896c874168b02efa3e48866(s, config);
}

}


