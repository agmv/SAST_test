using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Enum_color
public class JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord : AbstractRESTStructure<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord() { }

public JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, 0);
  } else {
AttrValue = s.ssValue;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s) => ToStructure(s, config);
}
public static EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s = new EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord, ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord FromStructure(EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord(s, config);
}

}


