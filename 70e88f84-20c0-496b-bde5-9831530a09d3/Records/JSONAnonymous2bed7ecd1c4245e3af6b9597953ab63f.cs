using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyerLib.RestRecords;

// HttpMethodRecord
public class JSONRC_f7a56746c7bb090f072113e146ed4d38 : AbstractRESTStructure<RC_f7a56746c7bb090f072113e146ed4d38> {
[JsonProperty("HttpMethod")]
[JsonPropertyName("HttpMethod")]
public ssRuntimeDestroyerLib.RestRecords.JSONEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord AttrHttpMethod;

public JSONRC_f7a56746c7bb090f072113e146ed4d38() { }

public JSONRC_f7a56746c7bb090f072113e146ed4d38 (RC_f7a56746c7bb090f072113e146ed4d38 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpMethod = ConvertToRestWithoutDefaults(s.ssENHttpMethod, new EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord(), ssRuntimeDestroyerLib.RestRecords.JSONEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.FromStructureDelegate(config));
  } else {
AttrHttpMethod = ssRuntimeDestroyerLib.RestRecords.JSONEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.FromStructure(s.ssENHttpMethod, config);
  }
}

public static Func<ssRuntimeDestroyerLib.RestRecords.JSONRC_f7a56746c7bb090f072113e146ed4d38, RC_f7a56746c7bb090f072113e146ed4d38> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyerLib.RestRecords.JSONRC_f7a56746c7bb090f072113e146ed4d38 s) => ToStructure(s, config);
}
public static RC_f7a56746c7bb090f072113e146ed4d38 ToStructure(ssRuntimeDestroyerLib.RestRecords.JSONRC_f7a56746c7bb090f072113e146ed4d38 obj, IBehaviorsConfiguration config) { 
  RC_f7a56746c7bb090f072113e146ed4d38 s = new RC_f7a56746c7bb090f072113e146ed4d38();
  if(obj != null) {
  s.ssENHttpMethod = ssRuntimeDestroyerLib.RestRecords.JSONEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.ToStructure(obj.AttrHttpMethod, config);
  }
  return s;
}

public static Func<RC_f7a56746c7bb090f072113e146ed4d38, ssRuntimeDestroyerLib.RestRecords.JSONRC_f7a56746c7bb090f072113e146ed4d38> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f7a56746c7bb090f072113e146ed4d38 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyerLib.RestRecords.JSONRC_f7a56746c7bb090f072113e146ed4d38 FromStructure(RC_f7a56746c7bb090f072113e146ed4d38 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyerLib.RestRecords.JSONRC_f7a56746c7bb090f072113e146ed4d38(s, config);
}

}


