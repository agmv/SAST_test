using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUpdateEmailResult
public class RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure : AbstractRESTStructure<ST_f4b6c6eeb122dfa3165aeece838fd077Structure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("VerificationCode")]
public string AttrVerificationCode;

[JsonProperty("StartUpdateEmailFailureReason")]
public ssSystem_.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure AttrStartUpdateEmailFailureReason;

public RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure() { }

public RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure (ST_f4b6c6eeb122dfa3165aeece838fd077Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrVerificationCode = ConvertToRestWithoutDefaults(s.ssVerificationCode, "");
AttrStartUpdateEmailFailureReason = ConvertToRestWithoutDefaults(s.ssStartUpdateEmailFailureReason, new ST_265373b7ea713cad761986e9aec6548dStructure(), ssSystem_.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrVerificationCode = s.ssVerificationCode;
AttrStartUpdateEmailFailureReason = ssSystem_.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure.FromStructure(s.ssStartUpdateEmailFailureReason, config);
  }
}

public static ST_f4b6c6eeb122dfa3165aeece838fd077Structure ToStructure(ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure obj) { 
  ST_f4b6c6eeb122dfa3165aeece838fd077Structure s = new ST_f4b6c6eeb122dfa3165aeece838fd077Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssVerificationCode = obj.AttrVerificationCode == null ? "" : obj.AttrVerificationCode;
  s.ssStartUpdateEmailFailureReason = ssSystem_.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure.ToStructure(obj.AttrStartUpdateEmailFailureReason);
  }
  return s;
}

public static Func<ST_f4b6c6eeb122dfa3165aeece838fd077Structure, ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f4b6c6eeb122dfa3165aeece838fd077Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure FromStructure(ST_f4b6c6eeb122dfa3165aeece838fd077Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_f4b6c6eeb122dfa3165aeece838fd077Structure(s, config);
}

}


