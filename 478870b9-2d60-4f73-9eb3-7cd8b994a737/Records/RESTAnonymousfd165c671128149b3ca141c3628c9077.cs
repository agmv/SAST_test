using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// EntityRecord
public class RESTRC_05f199cf8f734662fa6eaa91568947ff : AbstractRESTStructure<RC_05f199cf8f734662fa6eaa91568947ff> {
[JsonProperty("Entity")]
public ssSystem_.RestRecords.RESTENEntityEntityRecord AttrEntity;

public RESTRC_05f199cf8f734662fa6eaa91568947ff() { }

public RESTRC_05f199cf8f734662fa6eaa91568947ff (RC_05f199cf8f734662fa6eaa91568947ff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntity = ConvertToRestWithoutDefaults(s.ssENEntity, new ENEntityEntityRecord(), ssSystem_.RestRecords.RESTENEntityEntityRecord.FromStructureDelegate(config));
  } else {
AttrEntity = ssSystem_.RestRecords.RESTENEntityEntityRecord.FromStructure(s.ssENEntity, config);
  }
}

public static RC_05f199cf8f734662fa6eaa91568947ff ToStructure(ssSystem_.RestRecords.RESTRC_05f199cf8f734662fa6eaa91568947ff obj) { 
  RC_05f199cf8f734662fa6eaa91568947ff s = new RC_05f199cf8f734662fa6eaa91568947ff();
  if(obj != null) {
  s.ssENEntity = ssSystem_.RestRecords.RESTENEntityEntityRecord.ToStructure(obj.AttrEntity);
  }
  return s;
}

public static Func<RC_05f199cf8f734662fa6eaa91568947ff, ssSystem_.RestRecords.RESTRC_05f199cf8f734662fa6eaa91568947ff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_05f199cf8f734662fa6eaa91568947ff s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_05f199cf8f734662fa6eaa91568947ff FromStructure(RC_05f199cf8f734662fa6eaa91568947ff s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_05f199cf8f734662fa6eaa91568947ff(s, config);
}

}


