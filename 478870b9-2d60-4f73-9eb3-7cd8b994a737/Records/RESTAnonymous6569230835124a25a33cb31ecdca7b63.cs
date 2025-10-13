using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUpdateEmailResultRecord
public class RESTRC_0cbd4d7610423d8899428a14f9ab38ee : AbstractRESTStructure<RC_0cbd4d7610423d8899428a14f9ab38ee> {
[JsonProperty("StartUpdateEmailResult")]
public ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure AttrStartUpdateEmailResult;

public RESTRC_0cbd4d7610423d8899428a14f9ab38ee() { }

public RESTRC_0cbd4d7610423d8899428a14f9ab38ee (RC_0cbd4d7610423d8899428a14f9ab38ee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUpdateEmailResult = ConvertToRestWithoutDefaults(s.ssSTStartUpdateEmailResult, new ST_f4b6c6eeb122dfa3165aeece838fd077Structure(), ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure.FromStructureDelegate(config));
  } else {
AttrStartUpdateEmailResult = ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure.FromStructure(s.ssSTStartUpdateEmailResult, config);
  }
}

public static RC_0cbd4d7610423d8899428a14f9ab38ee ToStructure(ssSystem_.RestRecords.RESTRC_0cbd4d7610423d8899428a14f9ab38ee obj) { 
  RC_0cbd4d7610423d8899428a14f9ab38ee s = new RC_0cbd4d7610423d8899428a14f9ab38ee();
  if(obj != null) {
  s.ssSTStartUpdateEmailResult = ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure.ToStructure(obj.AttrStartUpdateEmailResult);
  }
  return s;
}

public static Func<RC_0cbd4d7610423d8899428a14f9ab38ee, ssSystem_.RestRecords.RESTRC_0cbd4d7610423d8899428a14f9ab38ee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0cbd4d7610423d8899428a14f9ab38ee s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_0cbd4d7610423d8899428a14f9ab38ee FromStructure(RC_0cbd4d7610423d8899428a14f9ab38ee s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_0cbd4d7610423d8899428a14f9ab38ee(s, config);
}

}


