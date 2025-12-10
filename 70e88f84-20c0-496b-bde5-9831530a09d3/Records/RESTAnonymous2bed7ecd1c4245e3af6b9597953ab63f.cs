using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyerLib.RestRecords;

// HttpMethodRecord
public class RESTRC_f7a56746c7bb090f072113e146ed4d38 : AbstractRESTStructure<RC_f7a56746c7bb090f072113e146ed4d38> {
[JsonProperty("HttpMethod")]
public ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord AttrHttpMethod;

public RESTRC_f7a56746c7bb090f072113e146ed4d38() { }

public RESTRC_f7a56746c7bb090f072113e146ed4d38 (RC_f7a56746c7bb090f072113e146ed4d38 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpMethod = ConvertToRestWithoutDefaults(s.ssENHttpMethod, new EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord(), ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.FromStructureDelegate(config));
  } else {
AttrHttpMethod = ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.FromStructure(s.ssENHttpMethod, config);
  }
}

public static RC_f7a56746c7bb090f072113e146ed4d38 ToStructure(ssRuntimeDestroyerLib.RestRecords.RESTRC_f7a56746c7bb090f072113e146ed4d38 obj) { 
  RC_f7a56746c7bb090f072113e146ed4d38 s = new RC_f7a56746c7bb090f072113e146ed4d38();
  if(obj != null) {
  s.ssENHttpMethod = ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.ToStructure(obj.AttrHttpMethod);
  }
  return s;
}

public static Func<RC_f7a56746c7bb090f072113e146ed4d38, ssRuntimeDestroyerLib.RestRecords.RESTRC_f7a56746c7bb090f072113e146ed4d38> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f7a56746c7bb090f072113e146ed4d38 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyerLib.RestRecords.RESTRC_f7a56746c7bb090f072113e146ed4d38 FromStructure(RC_f7a56746c7bb090f072113e146ed4d38 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyerLib.RestRecords.RESTRC_f7a56746c7bb090f072113e146ed4d38(s, config);
}

}


