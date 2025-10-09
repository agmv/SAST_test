using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUpdateEmailFailureReasonRecord
public class JSONRC_cd804aaddb98d881ac0e154d00c7a1ec : AbstractRESTStructure<RC_cd804aaddb98d881ac0e154d00c7a1ec> {
[JsonProperty("StartUpdateEmailFailureReason")]
[JsonPropertyName("StartUpdateEmailFailureReason")]
public ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure AttrStartUpdateEmailFailureReason;

public JSONRC_cd804aaddb98d881ac0e154d00c7a1ec() { }

public JSONRC_cd804aaddb98d881ac0e154d00c7a1ec (RC_cd804aaddb98d881ac0e154d00c7a1ec s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUpdateEmailFailureReason = ConvertToRestWithoutDefaults(s.ssSTStartUpdateEmailFailureReason, new ST_265373b7ea713cad761986e9aec6548dStructure(), ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure.FromStructureDelegate(config));
  } else {
AttrStartUpdateEmailFailureReason = ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure.FromStructure(s.ssSTStartUpdateEmailFailureReason, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_cd804aaddb98d881ac0e154d00c7a1ec, RC_cd804aaddb98d881ac0e154d00c7a1ec> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_cd804aaddb98d881ac0e154d00c7a1ec s) => ToStructure(s, config);
}
public static RC_cd804aaddb98d881ac0e154d00c7a1ec ToStructure(ssSystem_.RestRecords.JSONRC_cd804aaddb98d881ac0e154d00c7a1ec obj, IBehaviorsConfiguration config) { 
  RC_cd804aaddb98d881ac0e154d00c7a1ec s = new RC_cd804aaddb98d881ac0e154d00c7a1ec();
  if(obj != null) {
  s.ssSTStartUpdateEmailFailureReason = ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure.ToStructure(obj.AttrStartUpdateEmailFailureReason, config);
  }
  return s;
}

public static Func<RC_cd804aaddb98d881ac0e154d00c7a1ec, ssSystem_.RestRecords.JSONRC_cd804aaddb98d881ac0e154d00c7a1ec> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cd804aaddb98d881ac0e154d00c7a1ec s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_cd804aaddb98d881ac0e154d00c7a1ec FromStructure(RC_cd804aaddb98d881ac0e154d00c7a1ec s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_cd804aaddb98d881ac0e154d00c7a1ec(s, config);
}

}


