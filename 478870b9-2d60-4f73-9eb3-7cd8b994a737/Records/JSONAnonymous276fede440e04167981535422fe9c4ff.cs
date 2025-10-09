using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ExternalIdentityProviderRecord
public class JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 : AbstractRESTStructure<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> {
[JsonProperty("ExternalIdentityProvider")]
[JsonPropertyName("ExternalIdentityProvider")]
public ssSystem_.RestRecords.JSONST_7b0e31d9e5a94347cc99b90226c3a090Structure AttrExternalIdentityProvider;

public JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301() { }

public JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExternalIdentityProvider = ConvertToRestWithoutDefaults(s.ssSTExternalIdentityProvider, new ST_7b0e31d9e5a94347cc99b90226c3a090Structure(), ssSystem_.RestRecords.JSONST_7b0e31d9e5a94347cc99b90226c3a090Structure.FromStructureDelegate(config));
  } else {
AttrExternalIdentityProvider = ssSystem_.RestRecords.JSONST_7b0e31d9e5a94347cc99b90226c3a090Structure.FromStructure(s.ssSTExternalIdentityProvider, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301, RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s) => ToStructure(s, config);
}
public static RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 ToStructure(ssSystem_.RestRecords.JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 obj, IBehaviorsConfiguration config) { 
  RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s = new RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301();
  if(obj != null) {
  s.ssSTExternalIdentityProvider = ssSystem_.RestRecords.JSONST_7b0e31d9e5a94347cc99b90226c3a090Structure.ToStructure(obj.AttrExternalIdentityProvider, config);
  }
  return s;
}

public static Func<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301, ssSystem_.RestRecords.JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 FromStructure(RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301(s, config);
}

}


