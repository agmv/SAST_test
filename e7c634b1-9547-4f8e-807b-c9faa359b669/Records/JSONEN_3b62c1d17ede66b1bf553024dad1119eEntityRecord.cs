using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Weekday
public class JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord : AbstractRESTStructure<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord() { }

public JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord s) => ToStructure(s, config);
}
public static EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord s = new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord, ssRuntimeDestroyer.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord FromStructure(EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord(s, config);
}

}


