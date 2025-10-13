using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ChangePasswordResultRecord
public class JSONRC_53d491417faf149f9fb8a0dda9c12d06 : AbstractRESTStructure<RC_53d491417faf149f9fb8a0dda9c12d06> {
[JsonProperty("ChangePasswordResult")]
[JsonPropertyName("ChangePasswordResult")]
public ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure AttrChangePasswordResult;

public JSONRC_53d491417faf149f9fb8a0dda9c12d06() { }

public JSONRC_53d491417faf149f9fb8a0dda9c12d06 (RC_53d491417faf149f9fb8a0dda9c12d06 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChangePasswordResult = ConvertToRestWithoutDefaults(s.ssSTChangePasswordResult, new ST_368bb4a94e9c212b75f0247c9d3e6e37Structure(), ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure.FromStructureDelegate(config));
  } else {
AttrChangePasswordResult = ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure.FromStructure(s.ssSTChangePasswordResult, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_53d491417faf149f9fb8a0dda9c12d06, RC_53d491417faf149f9fb8a0dda9c12d06> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_53d491417faf149f9fb8a0dda9c12d06 s) => ToStructure(s, config);
}
public static RC_53d491417faf149f9fb8a0dda9c12d06 ToStructure(ssSystem_.RestRecords.JSONRC_53d491417faf149f9fb8a0dda9c12d06 obj, IBehaviorsConfiguration config) { 
  RC_53d491417faf149f9fb8a0dda9c12d06 s = new RC_53d491417faf149f9fb8a0dda9c12d06();
  if(obj != null) {
  s.ssSTChangePasswordResult = ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure.ToStructure(obj.AttrChangePasswordResult, config);
  }
  return s;
}

public static Func<RC_53d491417faf149f9fb8a0dda9c12d06, ssSystem_.RestRecords.JSONRC_53d491417faf149f9fb8a0dda9c12d06> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53d491417faf149f9fb8a0dda9c12d06 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_53d491417faf149f9fb8a0dda9c12d06 FromStructure(RC_53d491417faf149f9fb8a0dda9c12d06 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_53d491417faf149f9fb8a0dda9c12d06(s, config);
}

}


