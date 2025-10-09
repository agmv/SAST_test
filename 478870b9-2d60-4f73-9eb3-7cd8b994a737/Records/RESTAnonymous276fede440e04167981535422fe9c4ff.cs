using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ExternalIdentityProviderRecord
public class RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 : AbstractRESTStructure<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> {
[JsonProperty("ExternalIdentityProvider")]
public ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure AttrExternalIdentityProvider;

public RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301() { }

public RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExternalIdentityProvider = ConvertToRestWithoutDefaults(s.ssSTExternalIdentityProvider, new ST_7b0e31d9e5a94347cc99b90226c3a090Structure(), ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure.FromStructureDelegate(config));
  } else {
AttrExternalIdentityProvider = ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure.FromStructure(s.ssSTExternalIdentityProvider, config);
  }
}

public static RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 ToStructure(ssSystem_.RestRecords.RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 obj) { 
  RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s = new RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301();
  if(obj != null) {
  s.ssSTExternalIdentityProvider = ssSystem_.RestRecords.RESTST_7b0e31d9e5a94347cc99b90226c3a090Structure.ToStructure(obj.AttrExternalIdentityProvider);
  }
  return s;
}

public static Func<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301, ssSystem_.RestRecords.RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 FromStructure(RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301(s, config);
}

}


