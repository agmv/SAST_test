using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUpdateEmailResultRecord
public class JSONRC_0cbd4d7610423d8899428a14f9ab38ee : AbstractRESTStructure<RC_0cbd4d7610423d8899428a14f9ab38ee> {
[JsonProperty("StartUpdateEmailResult")]
[JsonPropertyName("StartUpdateEmailResult")]
public ssSystem_.RestRecords.JSONST_f4b6c6eeb122dfa3165aeece838fd077Structure AttrStartUpdateEmailResult;

public JSONRC_0cbd4d7610423d8899428a14f9ab38ee() { }

public JSONRC_0cbd4d7610423d8899428a14f9ab38ee (RC_0cbd4d7610423d8899428a14f9ab38ee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUpdateEmailResult = ConvertToRestWithoutDefaults(s.ssSTStartUpdateEmailResult, new ST_f4b6c6eeb122dfa3165aeece838fd077Structure(), ssSystem_.RestRecords.JSONST_f4b6c6eeb122dfa3165aeece838fd077Structure.FromStructureDelegate(config));
  } else {
AttrStartUpdateEmailResult = ssSystem_.RestRecords.JSONST_f4b6c6eeb122dfa3165aeece838fd077Structure.FromStructure(s.ssSTStartUpdateEmailResult, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_0cbd4d7610423d8899428a14f9ab38ee, RC_0cbd4d7610423d8899428a14f9ab38ee> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_0cbd4d7610423d8899428a14f9ab38ee s) => ToStructure(s, config);
}
public static RC_0cbd4d7610423d8899428a14f9ab38ee ToStructure(ssSystem_.RestRecords.JSONRC_0cbd4d7610423d8899428a14f9ab38ee obj, IBehaviorsConfiguration config) { 
  RC_0cbd4d7610423d8899428a14f9ab38ee s = new RC_0cbd4d7610423d8899428a14f9ab38ee();
  if(obj != null) {
  s.ssSTStartUpdateEmailResult = ssSystem_.RestRecords.JSONST_f4b6c6eeb122dfa3165aeece838fd077Structure.ToStructure(obj.AttrStartUpdateEmailResult, config);
  }
  return s;
}

public static Func<RC_0cbd4d7610423d8899428a14f9ab38ee, ssSystem_.RestRecords.JSONRC_0cbd4d7610423d8899428a14f9ab38ee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0cbd4d7610423d8899428a14f9ab38ee s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_0cbd4d7610423d8899428a14f9ab38ee FromStructure(RC_0cbd4d7610423d8899428a14f9ab38ee s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_0cbd4d7610423d8899428a14f9ab38ee(s, config);
}

}


