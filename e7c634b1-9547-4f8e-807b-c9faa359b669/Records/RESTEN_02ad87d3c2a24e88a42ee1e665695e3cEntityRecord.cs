using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpMethod
public class RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord : AbstractRESTStructure<EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord() { }

public RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord (EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord obj) { 
  EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord s = new EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord, ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord FromStructure(EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTEN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord(s, config);
}

}


