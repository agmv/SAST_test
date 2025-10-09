using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// EntityRecord
public class JSONRC_05f199cf8f734662fa6eaa91568947ff : AbstractRESTStructure<RC_05f199cf8f734662fa6eaa91568947ff> {
[JsonProperty("Entity")]
[JsonPropertyName("Entity")]
public ssSystem_.RestRecords.JSONENEntityEntityRecord AttrEntity;

public JSONRC_05f199cf8f734662fa6eaa91568947ff() { }

public JSONRC_05f199cf8f734662fa6eaa91568947ff (RC_05f199cf8f734662fa6eaa91568947ff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntity = ConvertToRestWithoutDefaults(s.ssENEntity, new ENEntityEntityRecord(), ssSystem_.RestRecords.JSONENEntityEntityRecord.FromStructureDelegate(config));
  } else {
AttrEntity = ssSystem_.RestRecords.JSONENEntityEntityRecord.FromStructure(s.ssENEntity, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_05f199cf8f734662fa6eaa91568947ff, RC_05f199cf8f734662fa6eaa91568947ff> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_05f199cf8f734662fa6eaa91568947ff s) => ToStructure(s, config);
}
public static RC_05f199cf8f734662fa6eaa91568947ff ToStructure(ssSystem_.RestRecords.JSONRC_05f199cf8f734662fa6eaa91568947ff obj, IBehaviorsConfiguration config) { 
  RC_05f199cf8f734662fa6eaa91568947ff s = new RC_05f199cf8f734662fa6eaa91568947ff();
  if(obj != null) {
  s.ssENEntity = ssSystem_.RestRecords.JSONENEntityEntityRecord.ToStructure(obj.AttrEntity, config);
  }
  return s;
}

public static Func<RC_05f199cf8f734662fa6eaa91568947ff, ssSystem_.RestRecords.JSONRC_05f199cf8f734662fa6eaa91568947ff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_05f199cf8f734662fa6eaa91568947ff s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_05f199cf8f734662fa6eaa91568947ff FromStructure(RC_05f199cf8f734662fa6eaa91568947ff s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_05f199cf8f734662fa6eaa91568947ff(s, config);
}

}


