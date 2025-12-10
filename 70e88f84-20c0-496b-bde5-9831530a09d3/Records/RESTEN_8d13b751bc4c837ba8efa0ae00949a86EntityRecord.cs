using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyerLib.RestRecords;

// HttpMethod
public class RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord : AbstractRESTStructure<EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord() { }

public RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord (EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord ToStructure(ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord obj) { 
  EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord s = new EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord, ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord FromStructure(EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyerLib.RestRecords.RESTEN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord(s, config);
}

}


